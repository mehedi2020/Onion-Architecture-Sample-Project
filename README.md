
# 📌 Onion Architecture Demo

This repository demonstrates the implementation of **Onion Architecture** in a .NET application. The solution is structured into multiple layers to ensure **separation of concerns, testability, and maintainability**.

---

## 📜 Table of Contents

- [Solution Overview](#solution-overview)
- [Project Structure](#project-structure)
- [Technologies Used](#technologies-used)
- [Setup and Installation](#setup-and-installation)
- [Running the Application](#running-the-application)
- [Testing](#testing)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgments](#acknowledgments)

---

## 🎯 Solution Overview

The **Onion Architecture** ensures loose coupling between application layers. It consists of the following layers:

- **Core (Domain Layer)** - Contains **domain models, business rules, and interfaces**.
- **Application Layer** - Implements **use cases, services, and DTOs**.
- **Infrastructure Layer** - Handles **database, repository implementations, and external integrations**.
- **Presentation Layer** - Provides the **user interface (Web API, MVC, or Blazor UI)**.
- **Dependency Injection Layer** - Centralizes **dependency registration**.
- **Testing Layer** - Contains **unit and integration tests**.

---

## 📂 Project Structure

```
OnionArchitectureDemo
│── Core.Domain (Entities, Interfaces)
│── Core.Application (Services, DTOs)
│── Infrastructure.Persistence (Database, EF Core Configurations)
│── Infrastructure.Repository (Repositories)
│── Presentation.WebAPI (RESTful API Endpoints)
│── Presentation.WebUI (Web Interface - MVC, Razor Pages, or Blazor)
│── DependencyInjection (DI Configuration)
│── Tests.UnitTests (Unit Tests)
│── Tests.IntegrationTests (Integration Tests)
```

---

## 🛠 Technologies Used

| Technology | Purpose |
|------------|---------|
| **.NET 6+** | Core framework for application development |
| **Entity Framework Core** | ORM for data access |
| **ASP.NET Core** | Web API and Web UI development |
| **xUnit** | Unit and integration testing framework |
| **FluentValidation** | Request validation |
| **MediatR** | CQRS pattern implementation |
| **AutoMapper** | Object mapping |
| **Swagger (NSwag)** | API documentation |
| **GitHub Actions** | CI/CD pipeline |

---

## 🚀 Setup and Installation

### ✅ Prerequisites

- Install **.NET 6 SDK**
- Install **Visual Studio 2022** or **VS Code**
- Install **SQL Server** or **SQLite**

### 🔧 Steps to Install

1️⃣ **Clone the Repository**
```sh
Clone the repository >> https://github.com/mehedi2020/Onion-Architecture-Sample-Project.git
You can follow this one for that > https://learn.microsoft.com/en-us/azure/devops/repos/git/clone?view=azure-devops&tabs=visual-studio-2022
``` 

## 🙏 Acknowledgments

- Inspired by **Onion Architecture** principles
- Special thanks to the **.NET community** for providing excellent resources

### Workflow Diagram

```plaintext
+-------------------+       +-------------------+       +-------------------+
|   Core            |       |   Core.Application|       |   Core.Domain     |
|   - Core          |       |   - DTOs          |       |   - Entities      |
|   - Application   | ----> |   - Services      | ----> |   - Interfaces    |
+-------------------+       +-------------------+       +-------------------+
        |                           |                           |
        |                           |                           |
        v                           v                           v
+-------------------+       +-------------------+       +-------------------+
| Dependency        |       | Infrastructure    |       | Presentation      |
| Injection         |       | - Persistence     |       | - WebAPI          |
| - Dependency      | ----> | - Repositories    | ----> | - WebUI           |
|   Injection       |       |                   |       |                   |
+-------------------+       +-------------------+       +-------------------+
        |                           |                           |
        |                           |                           |
        v                           v                           v
+-------------------+       +-------------------+       +-------------------+
| Tests             |       | IntegrationTests  |       | UnitTests         |
| - Tests           |       | - IntegrationTests|       | - UnitTests       |
+-------------------+       +-------------------+       +-------------------+

---

🚀 **Happy Coding!** 🎉
