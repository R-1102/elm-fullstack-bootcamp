# Employee Management System — ASP.NET

An ASP.NET Core MVC web application for managing employee records, demonstrating CRUD operations, database integration, and server-side validation using Entity Framework Core.

Developed as part of Elm's Full-Stack Development Bootcamp.

- **Project Date:** March 2, 2025
- **Technologies:** C#, ASP.NET Core MVC, .NET 9, Entity Framework Core, SQL Server, HTML5, CSS3, Razor

## Features

- Create, view, update, and delete employee records.
- Employee data management using Entity Framework Core.
- SQL Server database integration.
- Data validation using Data Annotations.
- Database schema management through EF Core Migrations.
- MVC architecture.

## Getting Started

### Prerequisites

- .NET 9 SDK
- SQL Server
- Entity Framework Core CLI (9.0.x)

Configure the database connection using the `ConnectionStrings__DefaultConnection` environment variable.

Run the following commands:

```bash
dotnet restore
dotnet ef database update
dotnet run --project W3D1.csproj
```

Open the local URL displayed in the terminal.

## Note

This is an educational full-stack application demonstrating CRUD operations and relational database integration. Database credentials should be configured locally and never committed to version control.
