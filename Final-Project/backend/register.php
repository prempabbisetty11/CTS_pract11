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
        "CREATE TABLE IF NOT EXISTS event_registrations (
            id INT AUTO_INCREMENT PRIMARY KEY,
            username VARCHAR(100) NOT NULL,
            email VARCHAR(150) NOT NULL,
            phone VARCHAR(30) NOT NULL,
            event_date DATE NOT NULL,
            event_name VARCHAR(100) NOT NULL,
            message TEXT NULL,
            created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
        ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4"
    );

    if ($_SERVER["REQUEST_METHOD"] !== "POST") {
        sendJson(["success" => false, "message" => "Only POST requests are allowed."], 405);
    }

    $username = trim($_POST["username"] ?? "");
    $email = trim($_POST["email"] ?? "");
    $phone = trim($_POST["phone"] ?? "");
    $eventDate = trim($_POST["eventDate"] ?? "");
    $eventName = trim($_POST["eventName"] ?? "");
    $message = trim($_POST["message"] ?? "");

    if ($username === "" || $email === "" || $phone === "" || $eventDate === "" || $eventName === "") {
        sendJson(["success" => false, "message" => "Please fill all required fields."], 422);
    }

    if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
        sendJson(["success" => false, "message" => "Please enter a valid email address."], 422);
    }

    $statement = $conn->prepare(
        "INSERT INTO event_registrations
            (username, email, phone, event_date, event_name, message)
        VALUES (?, ?, ?, ?, ?, ?)"
    );
    $statement->bind_param("ssssss", $username, $email, $phone, $eventDate, $eventName, $message);
    $statement->execute();

    sendJson([
        "success" => true,
        "message" => "Registration saved successfully.",
        "registrationId" => $statement->insert_id
    ]);
} catch (Throwable $error) {
    sendJson(["success" => false, "message" => "Database error: " . $error->getMessage()], 500);
}
