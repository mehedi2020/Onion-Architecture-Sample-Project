# Onion Architecture Demo

This repository demonstrates the implementation of **Onion Architecture** in a .NET application. The solution is structured into multiple projects, each representing a different layer of the architecture. Below is a detailed guide to understanding and working with this solution.

---

## Table of Contents
1. [Solution Overview](#solution-overview)
2. [Project Structure](#project-structure)
3. [Technologies Used](#technologies-used)
4. [Setup and Installation](#setup-and-installation)
5. [Running the Application](#running-the-application)
6. [Testing](#testing)
7. [Contributing](#contributing)
8. [License](#license)

---

## Solution Overview

This solution follows the **Onion Architecture**, which emphasizes **separation of concerns**, **testability**, and **maintainability**. The architecture is divided into the following layers:

1. **Core Layer**: Contains domain entities, interfaces, and business logic.
2. **Application Layer**: Implements use cases, services, and DTOs.
3. **Infrastructure Layer**: Handles data access, repositories, and external services.
4. **Presentation Layer**: Provides the user interface (WebAPI and WebUI).
5. **Dependency Injection Layer**: Centralizes dependency registration.
6. **Tests Layer**: Contains unit and integration tests.

---

## Project Structure

The solution is organized into the following projects:

### **Core Layer**
- **Core.Domain**
  - **Entities**: Contains domain models (e.g., `Product`, `Customer`).
  - **Interfaces**: Defines abstractions for repositories and services.
- **Core.Application**
  - **DTOs**: Data Transfer Objects for transferring data between layers.
  - **Services**: Implements application services and use cases.

### **Infrastructure Layer**
- **Infrastructure.Persistence**: Handles database access and Entity Framework configurations.
- **Infrastructure.Repository**: Implements repository patterns for data access.

### **Presentation Layer**
- **WebAPI**: Provides RESTful API endpoints.
- **WebUI**: Contains the user interface (e.g., MVC, Razor Pages).

### **Dependency Injection Layer**
- **DependencyInjection**: Centralizes dependency registration for the application.

### **Tests Layer**
- **UnitTests**: Contains unit tests for the application.
- **IntegrationTests**: Contains integration tests for the application.

---

## Technologies Used

- **.NET 6**: The framework used for building the application.
- **Entity Framework Core**: For database access and ORM.
- **ASP.NET Core**: For building the WebAPI and WebUI.
- **xUnit**: For unit and integration testing.
- **Dependency Injection**: Built-in .NET Core DI container.
- **GitHub Actions**: For CI/CD pipeline.

---

## Setup and Installation

### **Prerequisites**
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [SQLite](https://sqlite.org/index.html) for database.

### **Steps**
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-username/OnionArchitectureDemo.git
   cd OnionArchitectureDemo