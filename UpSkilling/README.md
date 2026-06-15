# Cognizant-DN5

This repository contains practice exercises and a final project for Cognizant DN5 upskilling.

## Repository Structure

- `CSharp/` - C# exercise programs covering basics, OOP, collections, LINQ, tuples, pattern matching, and null handling.
- `SQL/` - SQL database script for the Event Portal database.
- `Bootstrap/` - Bootstrap practice files and local Bootstrap assets.
- `jQuery/` - jQuery and PHP practice files.
- `Final-Project/` - Event Portal final project frontend and backend files.

## C# Exercises

The `CSharp` folder contains numbered exercise files from `Exercise1_HelloWorld.cs` through `Exercise22_Tuples.cs`.

These exercises cover:

- Basic C# syntax
- Value and reference types
- Type inference
- Control flow and loops
- Methods and parameters
- Object-oriented programming
- Inheritance, abstract classes, and interfaces
- Null handling
- Lists, dictionaries, LINQ, pattern matching, and tuples

## SQL Database

The SQL work is saved in:

```text
SQL/database.sql
```

This script creates the `event_portal` database with tables such as `Users`, `Events`, `Sessions`, `Registrations`, `Feedback`, and `Resources`, along with sample data and queries.

To run it in MySQL Workbench:

1. Open `SQL/database.sql`.
2. Connect to your MySQL server.
3. Run the script.

## Final Project

Open the final project homepage in a browser:

```text
Final-Project/index.html
```

If the project uses Node/npm (in `Final-Project`):

```bash
cd Final-Project
npm install
npm start
```

## Git Commands

```bash
git add .
git commit -m "describe change"
git push origin main
```
