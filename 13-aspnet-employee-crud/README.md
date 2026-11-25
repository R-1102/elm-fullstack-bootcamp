# ASP.NET Employee CRUD

Create, list, edit and delete employees with data annotations and EF Core SQL Server migrations.

Developed as part of Elm's Full-Stack Development Bootcamp.

- **Project Date:** March 2, 2025
- **Technologies:** C#, ASP.NET Core MVC, EF Core, SQL Server, .NET 9

## Getting Started

Requires a .NET 9 SDK, a reachable SQL Server and the matching EF CLI (9.0.x). Set `ConnectionStrings__DefaultConnection` in your environment to your own SQL Server connection string. Then run `dotnet restore`, `dotnet ef database update` and `dotnet run --project W3D1.csproj` from this folder. Never commit a real connection string.
