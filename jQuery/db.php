<?php
$host = "127.0.0.1";
$username = "root";
$password = "root123";
$database = "cognizant";

mysqli_report(MYSQLI_REPORT_ERROR | MYSQLI_REPORT_STRICT);

if (!preg_match("/^[A-Za-z0-9_]+$/", $database)) {
    throw new Exception("Invalid database name.");
}

$conn = new mysqli($host, $username, $password);
$conn->set_charset("utf8mb4");
$conn->query("CREATE DATABASE IF NOT EXISTS `$database` CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci");
$conn->select_db($database);
