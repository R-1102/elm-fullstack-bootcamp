# Employee CRUD Application

This is a simple CRUD application built using ASP.NET Core MVC with MySQL.

## Setup Instructions

1. Clone the repository:
    ```bash
    git clone https://github.com/username/repository-name.git
    ```
2. Open the project in Visual Studio or any other IDE.
3. Install the required dependencies:
    ```bash
    dotnet restore
    ```
4. Update the connection string in `appsettings.json` to point to your MySQL database.
5. Run the migration to set up the database:
    ```bash
    dotnet ef database update
    ```
6. Run the application:
    ```bash
    dotnet run
    ```

## CRUD Operations

- **Create**: Add new employees.
- **Read**: View a list of employees.
- **Update**: Edit employee details.
- **Delete**: Remove an employee from the system.
