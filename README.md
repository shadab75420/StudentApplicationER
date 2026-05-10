# Console App with SQL Server Database Connection

## Project Overview

This project is a C# Console Application developed using .NET and Microsoft SQL Server.

The application demonstrates the implementation of:

- SQL Server Database Connection
- Insert Operation
- Read Operation
- SQL Commands using ADO.NET
- Data Display in Console

The system allows users to connect with SQL Server, insert student records, and retrieve stored data from the database.

---

# Features Implemented

## 1. Database Connection

The application connects to Microsoft SQL Server using a connection string.

### Functionalities
- Connects Console Application with SQL Server
- Uses Windows Authentication
- Establishes secure database communication

### Example Usage
- Application starts
- Connection opens successfully
- Database operations begin

---

## 2. Insert Data Operation

The application inserts multiple student records into the database table.

### Functionalities
- Adds new student records
- Supports multiple insert statements
- Saves data permanently in SQL Server

### Example Inserted Records
- Shadab
- Abhi
- Rahul

---

## 3. Read Data Operation

The application retrieves all records from the database.

### Functionalities
- Executes SELECT query
- Reads table records using SqlDataReader
- Displays data in Console Window

### Displayed Information
- Student ID
- Student Name
- Student Age

---

## 4. Console Output Display

Database results are displayed directly in the console application.

### Functionalities
- Shows connection status
- Displays inserted row count
- Prints retrieved records

---

# Database Used

## Database Name

```text
NFSDB2
```

## Table Name

```text
Students
```

---

# Table Structure

| Column | Data Type |
|---|---|
| Id | INT |
| Name | VARCHAR |
| Age | INT |

---

# Technologies Used

- C#
- .NET Console Application
- Microsoft SQL Server
- SQL Server Management Studio (SSMS)
- ADO.NET
- Microsoft.Data.SqlClient
- Visual Studio

---

# Project Structure

```text
ConsoleDatabaseApp
│
├── Program.cs
├── ConsoleDatabaseApp.csproj
```

---

# Package Required

Install NuGet package:

```text
Microsoft.Data.SqlClient
```

---

# How the Application Works

## Connection Flow
1. Application starts
2. SQL connection string loads
3. Connection established with SQL Server

---

## Insert Flow
1. Insert query executes
2. Student records added into database
3. Insert status displayed

---

## Read Flow
1. SELECT query executes
2. Records fetched from Students table
3. Data displayed in Console Window

---

# Output Example

```text
Database Connected Successfully
3 Rows Inserted Successfully

1 Shadab 22
2 Abhi 21
3 Rahul 23
```

---

# Learning Outcomes

Through this project, the following concepts are demonstrated:

- SQL Server Connectivity
- SqlConnection
- SqlCommand
- SqlDataReader
- ExecuteNonQuery()
- ExecuteReader()
- Insert Operations
- Read Operations
- Basic CRUD Concepts using ADO.NET

---

# Conclusion

This Console Database Application demonstrates how C# Console Applications can interact with Microsoft SQL Server using ADO.NET. The project successfully performs database connection, data insertion, and data retrieval operations while following simple and reusable development practices.
