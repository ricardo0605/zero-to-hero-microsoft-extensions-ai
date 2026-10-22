# Zero to Hero: Microsoft.Extensions.AI with .NET

A hands-on learning project exploring AI Engineering in the .NET ecosystem, with a focus on building practical applications using `Microsoft.Extensions.AI`, C#, ASP.NET Core, and locally hosted language models.

This repository documents my journey from understanding the fundamentals of AI integration in .NET to applying these concepts in a Web API through small, practical implementations.

## 🎯 Project Goals

- Understand the core abstractions provided by `Microsoft.Extensions.AI`.
- Build practical AI-powered features using ASP.NET Core Web API and .NET 10.
- Explore `IChatClient` and learn how to interact with language models through a consistent programming interface.
- Experiment with locally hosted language models using Ollama.
- Apply software engineering principles, including separation of concerns, maintainability, and automated testing, as the project evolves.
- Document technical decisions, challenges, and lessons learned throughout the process.

## 🛠️ Technology Stack

- **Language:** C#
- **Framework:** .NET 10
- **Web Framework:** ASP.NET Core Web API
- **AI Abstractions:** Microsoft.Extensions.AI
- **Local AI Runtime:** Ollama
- **Language Model:** Qwen 3.5 4B
- **Development Environment:** Visual Studio

The technology stack may evolve as I explore additional concepts and implementation approaches.

## 📚 Learning Roadmap

The project will evolve incrementally as I study and implement the concepts covered in the course.

- [ ] Getting started with `IChatClient`
- [ ] Creating a chat client and generating responses
- [ ] Managing conversation history
- [ ] Working with system instructions
- [ ] Exploring function calling and tool integration
- [ ] Adding automated tests
- [ ] Improving error handling and observability
- [ ] Exploring additional AI integration patterns as the project progresses

Progress will be reflected in the code and documentation as each topic is implemented.

## 🧠 Learning Approach

Rather than simply reproducing course examples, I aim to understand the underlying concepts and apply them to an independent ASP.NET Core Web API.

For each topic, the goal is to:

1. Understand the problem the concept solves.
2. Implement a small, working example.
3. Evaluate design choices and trade-offs.
4. Document relevant technical decisions and lessons learned.
5. Improve the implementation as my understanding grows.

This repository is both a learning workspace and a practical demonstration of my progress toward AI Engineering.

## 🚀 Getting Started

### Prerequisites

- Visual Studio with support for .NET 10
- .NET 10 SDK
- [Ollama](https://ollama.com/)
- A compatible language model available locally

### Run the local model

Install Ollama, then download the model used in the current experiments:

```bash
ollama pull qwen3.5:4b
```

Start the model:

```bash
ollama run qwen3.5:4b
```

### Run the Web API

1. Clone this repository.
2. Open the solution in Visual Studio.
3. Restore NuGet packages.
4. Build and run the ASP.NET Core Web API project.

Detailed API configuration and execution instructions will be added as the implementation evolves.

## 📖 Learning Reference

This project is inspired by the Dometrain course:

**From Zero to Hero: Microsoft.Extensions.AI in .NET**, by Brandon Minnick (Code Traveler, LLC).

- [Course page](https://dometrain.com/course/from-zero-to-hero-microsoft-extensions-ai-in-dotnet/)

The course is the learning reference. The implementations, experiments, and technical notes in this repository are intended to reflect my own practical work and understanding.

## 👨‍💻 About

I'm a software engineer with 15+ years of experience building software solutions, primarily in the .NET ecosystem.

My professional background includes C#, ASP.NET Core, REST APIs, SQL Server, data access, software architecture, and automated testing.

I'm expanding this experience into AI Engineering by exploring how language models and AI abstractions can be integrated into maintainable, production-oriented .NET applications.

**The goal is to combine established software engineering practices with practical AI development.**

---

*This is an evolving learning project. Features, documentation, and implementation details will be updated as new concepts are explored.*
