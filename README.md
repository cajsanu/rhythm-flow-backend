# RhythmFlow

## Project Overview

**RhythmFlow** is a backend application designed for managing IT-related projects efficiently. It manages workflows through workspaces, projects, and tickets requiring users to be authenticated. The system is built following the **CLEAN architecture** principles and utilizes **RESTful APIs** to ensure a scalable, maintainable, and robust backend.

With RhythmFlow you can signup and login to manage projects and tickets easily. As an authenticated user you can create your own workspaces and see workspaces of others. When you create a workspace you automatically become the owner of that workspace. As the owner you can then assign other users to your workspace and give them the role of either Developer or Project Manager. The roles are managed on the workspace level and the permissions of the user depends on their role in the workspace and their involvment in created projects.

## ERD
![ERD](/Images/ERD.png)

## Key Features

### Authentication

- Users can **register** _(POST /api/v1/users)_ and **log in** _(POST /api/v1/authentication/login)_ using their credentials.
- Passwords are securely **hashed using BCrypt**.
- Upon successful authentication, a **JWT token** is generated and returned to the user for subsequent requests.

### Workspace Management

- Authenticated users can create **workspaces** _(POST /api/v1/workspaces)_.
- The creator of the workspace automatically becomes the owner and the owner can assign other users to the wokspace
- Users can be assigned _(POST /api/v1/workspaces/{workspaceId}/user/{userId})_ to workspaces as:
  - **Developer**
  - **Project Manager**

### Project Management

- If a user is assigned the role of **Project Managers** they can manage (CRUD) projects within the workspace.
- Projects are linked to a specific workspace through the workspace id.
  - Users in a workspace can view the projects _(GET /api/v1/workspaces/{workspaceId}/projects)_
- Project Managers in the workspace can:
  - Create, update and delete projects.
  - Assign/ unassign users to projects _(POST/DELETE /api/v1/workspaces/{workspaceId}/projects/{projectId}/users/{userId})_.
- The user who creates the project is automatically assigned to the project

### Ticket Management

- Inside each project:
  - Users who are part of the project and have any role (Developer, Project Manager, Owner) in the workspace can create, update, delete, and view **tickets**.
  - Users in the project can assign/ unassign tickets to other users.

## More information about the API endpoints

- According to **RESTful APIs** best practices all the endpoints follow the _api/version/resource/{resourceId}..._ structure (except for the authentication endpoint). 
- Use **swagger** to get a more comprehensive view of all the available endpoints. 
  - The swagger documentation is available at _/swagger/index.html_ when the app is running. 

### Authorization

- Three custom **Authorization Handlers** ensure security:
  1. **Workspace Role Authorization**: Ensures the user has the correct role (Owner, Developer or Project Manager) to perform actions in a workspace/project/ticket.
  2. **Project Membership Authorization**: Confirms the user is a member of a specific project to perform relevant actions.
  3. **User is the correct user**: Makes sure the user who tries to delete or update a user is the same person. 

## Technology Stack

- **Programming Language**: C#
- **Framework**: ASP.NET Core
- **Database**: PostgreSQL
- **ORM**: Entity Framework Core
- **Authentication**: BCrypt for password hashing and JWT for token-based authentication
- **Architecture**: CLEAN Architecture
- **Testing**: Unit tests with XUnit
- **API Design**: RESTful APIs
- **CI**: GitHub Actions
- **Code checking**: Husky and Sonarlint

## Folder structure

- The project adheres to the CLEAN Architecture pattern, organized as follows:
  - **Domain**: Entities, value objects and interfaces.
  - **Application**: Service implementations, and DTOs.
  - **Controller**: Controllers for handling API requests and responses, middleware and authorization.
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

To enable authentication for the application in development mode, follow these steps:

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

### Running tests

- In the terminal cd into the project and run `dotnet test`

