<?php
header("Content-Type: application/json");

function sendJson($data, $statusCode = 200)
{
    http_response_code($statusCode);
    echo json_encode($data);
    exit;
}

try {
    require_once __DIR__ . "/db.php";

    $conn->query(
        "CREATE TABLE IF NOT EXISTS items (
            id INT AUTO_INCREMENT PRIMARY KEY,
            name VARCHAR(255) NOT NULL,
            created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
        ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4"
    );

    $action = $_POST["action"] ?? $_GET["action"] ?? "list";

    if ($action === "list") {
        $result = $conn->query("SELECT id, name FROM items ORDER BY id ASC");
        $items = [];

        while ($row = $result->fetch_assoc()) {
            $items[] = $row;
        }

        sendJson(["success" => true, "items" => $items]);
    }

    if ($action === "add") {
        $name = trim($_POST["name"] ?? "");

        if ($name === "") {
            sendJson(["success" => false, "message" => "Item name is required."], 422);
        }

        $statement = $conn->prepare("INSERT INTO items (name) VALUES (?)");
        $statement->bind_param("s", $name);
        $statement->execute();

        sendJson(["success" => true, "message" => "Item saved."]);
    }

    if ($action === "clear") {
        $conn->query("DELETE FROM items");
        sendJson(["success" => true, "message" => "All items removed."]);
    }

    sendJson(["success" => false, "message" => "Invalid action."], 400);
} catch (Throwable $error) {
    sendJson(["success" => false, "message" => "Database error: " . $error->getMessage()], 500);
}
