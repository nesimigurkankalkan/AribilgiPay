# AribilgiPay
# Payment System – ASP.NET Core Web API (Hexagonal Architecture)

## Overview

This project is a **Payment System Web API** developed with **ASP.NET Core**, designed as a real-world example of applying **Hexagonal Architecture (Ports & Adapters)** principles. The main goal of this project is to demonstrate how to build a clean, maintainable, testable, and scalable backend system by enforcing a strong separation of concerns.

The architecture is structured into **Application**, **Domain**, and **Infrastructure** layers, ensuring that business logic remains independent of external frameworks, databases, and third-party services.

---

## Architectural Approach

This project follows **Hexagonal Architecture**, also known as **Ports and Adapters Architecture**. The core idea is to isolate the business logic from external dependencies such as databases, payment providers, and frameworks.

### Why Hexagonal Architecture?

* Keeps **business rules independent** from infrastructure concerns
* Improves **testability** by allowing easy mocking of external systems
* Encourages **clean code and maintainability**
* Makes the system **flexible and extensible** for future changes

---

## Project Structure

```
/src
 ├── PaymentSystem.Api           # API layer (Controllers, Middlewares)
 ├── PaymentSystem.Application   # Application layer (Use Cases, Ports)
 ├── PaymentSystem.Domain        # Domain layer (Entities, Value Objects, Rules)
 └── PaymentSystem.Infrastructure# Infrastructure layer (Adapters, Persistence)
```

---

## Layer Responsibilities

### Domain Layer

The **Domain layer** contains the core business logic of the payment system.

**Responsibilities:**

* Domain entities (e.g. Payment, Transaction)
* Value objects
* Business rules and domain services
* Domain interfaces (pure abstractions)

> This layer has **no dependency** on any other layer or external framework.

---

### Application Layer

The **Application layer** orchestrates business use cases and defines how the outside world interacts with the domain.

**Responsibilities:**

* Use cases (e.g. CreatePayment, CompletePayment)
* Application services
* Ports (interfaces for external dependencies)
* DTOs and mapping logic

> This layer depends only on the **Domain layer**.

---

### Infrastructure Layer

The **Infrastructure layer** contains technical implementations and external integrations.

**Responsibilities:**

* Database access (e.g. Entity Framework Core)
* Repository implementations
* External payment provider integrations
* Logging, caching, and other technical concerns

> This layer depends on **Application and Domain**, never the opposite.

---

### API Layer

The **API layer** acts as the entry point of the system.

**Responsibilities:**

* HTTP controllers
* Request/response handling
* Validation and exception handling
* Dependency Injection configuration

> The API layer communicates only with the **Application layer**.

---

## Key Concepts Implemented

* Hexagonal Architecture (Ports & Adapters)
* Clean Architecture principles
* Dependency Inversion
* Separation of Concerns
* SOLID principles
* Test-friendly design

---

## Technologies Used

* ASP.NET Core Web API
* C#
* Entity Framework Core
* Dependency Injection
* RESTful API principles

---

## Getting Started

### Prerequisites

* .NET SDK (latest LTS)
* Any IDE supporting .NET (Visual Studio / Rider / VS Code)

### Running the Project

1. Clone the repository

   ```bash
   git clone https://github.com/your-username/your-repository-name.git
   ```

2. Navigate to the project directory

   ```bash
   cd your-repository-name
   ```

3. Run the API

   ```bash
   dotnet run
   ```

---

## Future Improvements

* Add authentication and authorization
* Integrate real payment gateways
* Implement background processing
* Add unit and integration tests
* Improve logging and monitoring

---

## Purpose of This Project

This project was built as a **learning and portfolio project** to showcase:

* Real-world backend architecture skills
* Clean code practices
* Proper layering and abstraction
* Professional ASP.NET Core development approach

It is suitable as a reference for developers who want to understand and apply **Hexagonal Architecture** in modern .NET applications.

---

## License

This project is open-source and available under the MIT License.

