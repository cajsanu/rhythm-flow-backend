# RhythmFlow

## Project Overview

**RhythmFlow** is a backend application designed for managing IT-related projects efficiently. It manages workflows through workspaces, projects, and tickets requiring users to be authenticated. The system is built following the **CLEAN architecture** principles and utilizes **RESTful APIs** to ensure a scalable, maintainable, and robust backend.

## Key Features

### Authentication

- Users can **register** _(POST /api/v1/users)_ and **log in** _(POST /api/v1/authentication/login)_ using their credentials.
- Passwords are securely **hashed using BCrypt**.
- Upon successful authentication, a **JWT token** is generated and returned to the user for subsequent requests.

### Workspace Management

- Authenticated users can create **workspaces** _(POST /api/v1/workspaces)_.
- The creator of the workspace automatically becomes the owner and the owner can assign users to the wokspace
- Users can be assigned _(POST /api/v1/workspaces/adduser{userId})_/ unassigned _(DELETE /api/v1/workspaces/removeuser{userId})_ to workspaces with specific roles:
  - **Developer**
  - **Project Manager**
- If a user is assigned the role of **Project Managers** they can manage (CRUD) projects within the workspace.

### Project Management

- Projects are linked to a specific workspace.
  - Users in a workspace can view the projects _(GET /api/v1/workspaces/{workspaceId}/projects)_
- Project Managers can:
  - Create, update and delete projects.
  - Assign/ unassign users to projects.

### Ticket Management

- Inside each project:
  - Users who are part of the project can create, update, delete, and view **tickets**.
  - Users in the project can assign/ unassign tickets to users within the project.

### Authorization

- Two custom **Authorization Handlers** ensure security:
  1. **Workspace Role Authorization**: Ensures the user has the correct role (Owner, Developer or Project Manager) to perform actions in a workspace/project/ticket.
  2. **Project Membership Authorization**: Confirms the user is a member of a specific project to perform relevant actions.

## Technology Stack

- **Programming Language**: C#
- **Framework**: ASP.NET Core
- **Database**: PostgreSQL
- **ORM**: Entity Framework Core
- **Authentication**: BCrypt for password hashing and JWT for token-based authentication
- **Architecture**: CLEAN Architecture
- **Testing**: Unit tests with XUnit
- **API Design**: RESTful APIs
- **GitHub Actions**: For CI

## Folder structure

- The project adheres to the CLEAN Architecture pattern, organized as follows:
  - **Domain**: Core business logic, entities, value objects and interfaces.
  - **Application**: Authorization handlers, service implementations, and DTOs.
  - **Controller**: Controllers for handling API requests and responses and middleware.
  - **Framework**: DI container, repositories and database configurations

## Local Development Setup

### Set up the database

There are few things you need to do before getting the database up and running:

#### 1. Create the database

Use pgAdmin and create a database (rfDatabase is the name being used atm)

#### 2. Change connection strings

In app.settings.json in the Framework folder update the connectionstring with your name, password, databasename, host, and port there to match the one in your database (currently it is user postgres with password 1234)

```json
   "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=5432;Database=rfDatabase;User ID=postgres;Password=1234"
   }
```

#### 3. Run the migrations

Then cd into Framework, and run `dotnet ef database update`

### Authentication Configuration

To set up authentication for the application, follow these steps:

#### 1. Create a Configuration File

Add an **appsettings.Development.json** file to the **RhythmFlow.Framework** project.

#### 2. Populate the File

Copy and paste the following JSON content into the **appsettings.Development.json** file:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=5432;Database=rfDatabase;User ID=postgres;Password=1234"
  },
  "DetailedErrors": true,
  "SensitiveDataLogging": true,
  "Jwt": {
    "Secret": "OurSuperSecretKeyHere1234567890andSoOn",
    "Issuer": "Rhythmflow",
    "Audience": "Rhythmflow",
    "TokenLifetime": 60
  }
}
```

#### 3. Run the app in development mode

In the **RhythmFlow.Framework** project run `export ASPNETCORE_ENVIRONMENT=Development && dotnet run`

## More information about the API endpoints

- _(http://localhost:5110/swagger/index.html)_
