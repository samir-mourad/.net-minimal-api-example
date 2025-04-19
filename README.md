# .NET Minimal API Example ⚡️

This repository provides a simple and functional example of how to build a REST API using the Minimal API approach introduced in .NET 6+, with a focus on clarity, clean organization, and best practices.

## 🧠 About the project

The goal of this project is to demonstrate how to:

- Build a RESTful API using the concise syntax of .NET Minimal APIs;
- Implement CRUD operations in a clean and scalable way.

## 🛠 Technologies used

- **.NET 9**
- **C#**
- **Entity Framework Core (InMemory)**
- **Minimal APIs**

## 🚀 How to run

1. Clone the repository:
   ```bash
   git clone https://github.com/samir-mourad/.net-minimal-api-example.git
   cd .net-minimal-api-example
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

3. Access the API:
   ```
   http://localhost:5000
   ```

🐳 Running with Docker

To run this project inside a Docker container, follow these steps:

1. Build the Docker image
```bash
docker build -t minimal-api-example .
```

2. Run the container
```bash
docker run -d -p 5000:80 --name minimal-api-app minimal-api-example
```
The API will be accessible at: http://localhost:5000

## 📦 Features

- Full CRUD for mock entities using an in-memory repository;
- Clean and simple endpoint organization;
- Lightweight structure ideal for small apps or scalable API prototypes.

## 🤝 Contributions

This project is intended for educational purposes and is open to suggestions, improvements, and pull requests!

## 🧔 About the author

Created by **[Samir Alviani Mourad](https://www.linkedin.com/in/samir-alviani-mourad/)** — Software Engineer passionate about clean architecture, modern APIs, and crunchy guitars 🎸
