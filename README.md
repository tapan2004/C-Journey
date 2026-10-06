# C# Journey 🚀

A hands-on journey from **Java → C# → .NET**, focused on learning C# by mapping familiar Java concepts to their C# equivalents and implementing everything through practical examples.

> **Background:** Java Developer
> **Learning Path:** Java → C# → .NET → ASP.NET Core → gRPC → SQLite

The goal of this repository is not just to learn C# syntax, but to understand **how C#/.NET concepts compare with Java** and gradually become comfortable building real-world applications.

---

## 📚 Topics Covered

### 1. C# Fundamentals

* Variables and Data Types
* Operators
* Type Casting
* Strings
* `string` vs `String`
* `var`
* `const`
* `readonly`
* Conditional Statements
* Loops
* Methods
* Parameters
* Classes and Objects
* Namespaces
* Access Modifiers
* Console Input/Output

### 2. Java → C# Fundamentals

Since this repository is built from a Java developer's perspective, familiar Java concepts are mapped to their C# equivalents.

| Java                   | C#                    | Concept                    |
| ---------------------- | --------------------- | -------------------------- |
| `package`              | `namespace`           | Organizing classes         |
| `import`               | `using`               | Importing namespaces/types |
| `System.out.println()` | `Console.WriteLine()` | Console output             |
| `String`               | `string`              | String type                |
| `boolean`              | `bool`                | Boolean type               |
| `final`                | `readonly` / `const`  | Prevent reassignment       |
| `super`                | `base`                | Parent class access        |
| `instanceof`           | `is`                  | Type checking              |
| `extends`              | `:`                   | Inheritance                |
| `implements`           | `:`                   | Interface implementation   |

---

## 🧱 Object-Oriented Programming

* Classes
* Objects
* Constructors
* Encapsulation
* Abstraction
* Inheritance
* Polymorphism
* Interfaces
* Abstract Classes
* Sealed Classes
* Access Modifiers
* Properties
* Getters / Setters
* Method Overloading
* Method Overriding

### Java → C# Property Difference

Java commonly uses:

```java
private String name;

public String getName() {
    return name;
}

public void setName(String name) {
    this.name = name;
}
```

C# provides properties:

```csharp
public string Name { get; set; }
```

Understanding properties is one of the important differences when moving from Java to C#.

---

## 📦 Collections

* Arrays
* `List<T>`
* `Dictionary<TKey,TValue>`
* `HashSet<T>`
* `Queue<T>`
* `Stack<T>`
* `LinkedList<T>`
* `SortedDictionary<TKey,TValue>`
* `SortedSet<T>`
* Generic Collections
* Concurrent Collections

### Java → C# Collection Mapping

| Java                | C#                                  |
| ------------------- | ----------------------------------- |
| `ArrayList`         | `List<T>`                           |
| `LinkedList`        | `LinkedList<T>`                     |
| `HashMap`           | `Dictionary<TKey,TValue>`           |
| `TreeMap`           | `SortedDictionary<TKey,TValue>`     |
| `HashSet`           | `HashSet<T>`                        |
| `TreeSet`           | `SortedSet<T>`                      |
| `Queue`             | `Queue<T>`                          |
| `Stack`             | `Stack<T>`                          |
| `ConcurrentHashMap` | `ConcurrentDictionary<TKey,TValue>` |

Example:

```java
HashMap<Integer, String> cameras = new HashMap<>();
```

C#:

```csharp
Dictionary<int, string> cameras = new();
```

---

## 🧬 Generics

Java:

```java
List<String> names;
Map<Integer, String> students;
```

C#:

```csharp
List<string> names;
Dictionary<int, string> students;
```

Topics:

* Generic Classes
* Generic Methods
* Generic Interfaces
* Generic Constraints
* `T`
* `where` constraints

---

## ⚡ Lambda Expressions

Java:

```java
x -> x * 2
```

C#:

```csharp
x => x * 2
```

Lambda expressions are especially important because they are heavily used with **LINQ, delegates, events, collections, and asynchronous programming**.

---

## 🔎 LINQ — C# Stream API Equivalent

One of the most important concepts for a Java developer moving to C# is **LINQ**.

### Java → C# Mapping

| Java Stream API | C# LINQ                       |
| --------------- | ----------------------------- |
| `filter()`      | `Where()`                     |
| `map()`         | `Select()`                    |
| `sorted()`      | `OrderBy()`                   |
| `findFirst()`   | `First()`                     |
| `count()`       | `Count()`                     |
| `anyMatch()`    | `Any()`                       |
| `allMatch()`    | `All()`                       |
| `collect()`     | `ToList()` / `ToDictionary()` |
| `groupingBy()`  | `GroupBy()`                   |

Java:

```java
var result = cameras.stream()
    .filter(c -> c.isConnected())
    .toList();
```

C#:

```csharp
var result = cameras
    .Where(c => c.IsConnected)
    .ToList();
```

### LINQ Topics

* `Where`
* `Select`
* `OrderBy`
* `ThenBy`
* `First`
* `FirstOrDefault`
* `Single`
* `Any`
* `All`
* `Count`
* `GroupBy`
* `Join`
* `ToList`
* `ToDictionary`
* Deferred Execution
* `IEnumerable<T>`

---

## 🚨 Exception Handling

* `try`
* `catch`
* `finally`
* `throw`
* Custom Exceptions
* Exception Filters
* No Checked Exceptions

### Java → C#

| Java               | C#                   |
| ------------------ | -------------------- |
| `try`              | `try`                |
| `catch`            | `catch`              |
| `finally`          | `finally`            |
| `throw`            | `throw`              |
| `Exception`        | `Exception`          |
| Checked Exceptions | No direct equivalent |

---

## 🔄 Async & Concurrency

This area is particularly important for backend and camera/RTSP applications.

### Java → C# Mapping

| Java                  | C#                                   |
| --------------------- | ------------------------------------ |
| `Thread`              | `Thread`                             |
| `Runnable`            | `Action` / delegate / async patterns |
| `ExecutorService`     | `Task` / ThreadPool                  |
| `CompletableFuture`   | `Task` / `Task<T>`                   |
| `Future`              | `Task<T>`                            |
| `synchronized`        | `lock`                               |
| `volatile`            | `volatile`                           |
| `AtomicInteger`       | `Interlocked` / `Volatile`           |
| `CountDownLatch`      | `CountdownEvent`                     |
| `Semaphore`           | `SemaphoreSlim`                      |
| Cancellation patterns | `CancellationToken`                  |

Example:

Java:

```java
CompletableFuture.runAsync(() -> {
    connectCamera();
});
```

C#:

```csharp
Task.Run(() =>
{
    ConnectCamera();
});
```

C# async programming:

```csharp
async Task ConnectCameraAsync()
{
    await ConnectAsync();
}
```

### Topics

* `Thread`
* ThreadPool
* `Task`
* `Task<T>`
* `async`
* `await`
* `CancellationToken`
* `lock`
* `Monitor`
* `SemaphoreSlim`
* `Interlocked`
* Thread-safe programming
* Concurrent Collections

---

## 🎯 Delegates & Events

Important C# concepts that don't have a direct one-to-one Java equivalent.

### Delegates

* `Action`
* `Func`
* `Predicate`
* Custom Delegates

### Events

* Event declaration
* Event handlers
* Publisher / Subscriber pattern
* Event-driven programming

---

## 🧩 Important C# Concepts

These concepts need to be learned separately rather than treated as simple Java equivalents:

* Properties
* Delegates
* Events
* LINQ
* Nullable Reference Types
* `record`
* `struct`
* `ref`
* `out`
* `in`
* Pattern Matching
* Extension Methods
* Indexers
* Operator Overloading
* `yield`
* `IEnumerable<T>`
* `IAsyncEnumerable<T>`
* `Span<T>`
* `Memory<T>`

---

# 🛠️ .NET Ecosystem

## .NET CLI

Learning the .NET CLI is an important part of becoming comfortable with the .NET ecosystem.

Common commands:

```bash
dotnet new console
dotnet build
dotnet run
dotnet test
dotnet clean
dotnet restore
```

### Java → .NET Mapping

| Java             | C# / .NET           |
| ---------------- | ------------------- |
| JDK              | .NET SDK            |
| JVM              | CLR / .NET Runtime  |
| JRE              | .NET Runtime        |
| `javac`          | `dotnet build`      |
| `java`           | `dotnet run`        |
| Maven            | `dotnet` + MSBuild  |
| `mvn test`       | `dotnet test`       |
| `pom.xml`        | `.csproj`           |
| `.jar`           | `.dll` / executable |
| Maven dependency | NuGet package       |

---

## 📦 NuGet & Project Structure

Topics:

* `.csproj`
* Solution files
* Project files
* NuGet packages
* Package references
* Build configuration
* Debug / Release
* MSBuild
* Project references

Example:

```text
CSharpJourney/
│
├── CSharpBasics/
├── OOP/
├── Collections/
├── LINQ/
├── Async/
├── Exceptions/
├── Generics/
├── FileHandling/
├── Testing/
└── README.md
```

---

# 🌐 ASP.NET Core

After learning C# and the .NET fundamentals, the next step is **ASP.NET Core**.

### Spring Boot → ASP.NET Core

| Java / Spring            | C# / ASP.NET Core         |
| ------------------------ | ------------------------- |
| Spring Boot              | ASP.NET Core              |
| Controller               | Controller / Minimal API  |
| `@RestController`        | `[ApiController]`         |
| `@GetMapping`            | `[HttpGet]`               |
| `@PostMapping`           | `[HttpPost]`              |
| `@Autowired`             | Built-in .NET DI          |
| Spring DI                | .NET DI                   |
| `application.properties` | `appsettings.json`        |
| Spring Profiles          | ASP.NET Core Environments |
| Filter                   | Middleware / Filters      |
| Interceptor              | Middleware / Filters      |
| Jackson                  | `System.Text.Json`        |
| JPA / Hibernate          | EF Core                   |
| `CompletableFuture`      | `Task`                    |

### ASP.NET Core Topics

* HTTP fundamentals
* REST APIs
* Controllers
* Minimal APIs
* Routing
* Middleware
* Dependency Injection
* Configuration
* `appsettings.json`
* Environments
* Logging
* Authentication
* Authorization
* JSON serialization
* Exception handling
* API validation
* HTTP clients

---

# 🔌 REST API

### Java/Spring → ASP.NET Core

| Spring           | ASP.NET Core                        |
| ---------------- | ----------------------------------- |
| `@GetMapping`    | `[HttpGet]`                         |
| `@PostMapping`   | `[HttpPost]`                        |
| `@PutMapping`    | `[HttpPut]`                         |
| `@DeleteMapping` | `[HttpDelete]`                      |
| `@RequestBody`   | `[FromBody]`                        |
| `@PathVariable`  | `[FromRoute]`                       |
| `@RequestParam`  | `[FromQuery]`                       |
| `ResponseEntity` | `IActionResult` / `ActionResult<T>` |

---

# 🔗 gRPC

The learning path also includes communication between services using **gRPC**.

Topics:

* What is RPC?
* Protocol Buffers
* `.proto` files
* Service definitions
* Client / Server
* Unary RPC
* Streaming RPC
* gRPC in .NET
* gRPC communication between services

Java gRPC experience can be mapped to the .NET gRPC ecosystem.

---

# 🗄️ Database & SQLite

Database learning will focus on **SQLite** for lightweight application storage.

### Java → C# Mapping

| Java            | C# / .NET     |
| --------------- | ------------- |
| JDBC            | ADO.NET       |
| JPA             | EF Core       |
| Hibernate       | EF Core       |
| `EntityManager` | `DbContext`   |
| JPQL            | LINQ          |
| `@Entity`       | EF Core model |
| `@Id`           | `[Key]`       |

Learning path:

```text
C#
 ↓
.NET
 ↓
EF Core
 ↓
SQLite
```

Topics:

* SQL basics
* Tables
* Primary Keys
* Foreign Keys
* CRUD
* Relationships
* EF Core
* `DbContext`
* Migrations
* LINQ queries
* SQLite

---

# 📄 JSON

Java commonly uses:

* Jackson
* Gson

C# commonly uses:

```text
System.Text.Json
```

Example:

```csharp
string json = JsonSerializer.Serialize(camera);
```

JSON will be particularly useful for:

* Configuration
* Camera status
* API communication
* Service communication
* Application data

---

# 🧪 Testing

### Java → C#

| Java    | C#                     |
| ------- | ---------------------- |
| JUnit   | xUnit / NUnit / MSTest |
| `@Test` | `[Fact]` in xUnit      |
| Mockito | Moq / NSubstitute      |
| AssertJ | FluentAssertions       |

Primary testing framework for this journey:

**xUnit**

Topics:

* Unit Testing
* Integration Testing
* Assertions
* Test Fixtures
* Mocking
* Test-driven development basics
* Automated testing

---

# 💻 Development Tools

* C#
* .NET SDK
* ASP.NET Core
* Visual Studio
* Visual Studio Code
* .NET CLI
* NuGet
* Git
* GitHub
* SQLite
* EF Core
* gRPC
* xUnit

---

# 🗺️ Learning Roadmap

```text
Java Background
       │
       ▼
C# Fundamentals
       │
       ▼
OOP + Collections + Generics
       │
       ▼
Delegates + Events + LINQ
       │
       ▼
Async / Await + Concurrency
       │
       ▼
.NET CLI + Project Structure
       │
       ▼
Testing
       │
       ▼
ASP.NET Core
       │
       ▼
REST APIs
       │
       ▼
EF Core + SQLite
       │
       ▼
gRPC
       │
       ▼
Real-World .NET Applications
```

---

# ⭐ Most Important Java → C# Mappings

These are the concepts I am prioritizing as a Java developer moving to C#:

```text
JAVA                         C#
------------------------------------------------
package                 →    namespace
import                  →    using
System.out.println      →    Console.WriteLine
String                  →    string
boolean                 →    bool

ArrayList               →    List<T>
HashMap                 →    Dictionary<TKey,TValue>
HashSet                 →    HashSet<T>
TreeMap                 →    SortedDictionary<TKey,TValue>

extends                 →    :
implements              →    :

getter/setter            →    property

Stream API              →    LINQ
filter                  →    Where
map                     →    Select

Optional<T>             →    nullable / ? / null handling

CompletableFuture       →    Task<T>
ExecutorService         →    Task / ThreadPool
synchronized            →    lock

JDBC                    →    ADO.NET
Hibernate/JPA           →    EF Core

Maven                   →    dotnet / NuGet
pom.xml                 →    .csproj

JUnit                   →    xUnit
Jackson                 →    System.Text.Json

Spring Boot             →    ASP.NET Core
Spring DI               →    .NET DI

REST Controller         →    ASP.NET Core Controller
WebClient / HTTP Client →    HttpClient

gRPC Java               →    gRPC for .NET
```

---

# 🎯 Goal

The goal of this repository is to become productive in **C# and the .NET ecosystem while leveraging my existing Java knowledge**.

Instead of learning C# syntax in isolation, I am using familiar Java concepts as a bridge to understand:

* C#
* Object-Oriented Programming
* Collections
* LINQ
* Async/Await
* Concurrency
* .NET
* ASP.NET Core
* REST APIs
* gRPC
* EF Core
* SQLite
* Automated Testing

The long-term goal is to move from **Java developer → productive C#/.NET developer** and apply these skills to real-world software projects.

---

# 📈 Progress

This repository is continuously updated as I learn new C# and .NET concepts.

Each topic is implemented through practical examples so that the repository becomes both:

1. A **learning journey**
2. A **Java → C# reference guide**

---

## 🚀 Learning Philosophy

> **Don't just learn the syntax. Understand the concept, compare it with Java, implement it in C#, and use it in a real application.**

```text
Understand
    ↓
Compare Java ↔ C#
    ↓
Implement
    ↓
Practice
    ↓
Build
    ↓
Apply to real-world projects
```

---

## 📌 Future Topics

* Advanced LINQ
* Advanced async programming
* Dependency Injection
* Design Patterns
* ASP.NET Core Web APIs
* Authentication & Authorization
* gRPC
* EF Core
* SQLite
* Automated Testing
* Integration Testing
* Docker
* Production Environment Setup
* CI/CD
* Performance Optimization
* Real-world .NET projects

---

## 👨‍💻 Author

**Tapan**

Learning and documenting the journey from **Java → C# → .NET** through practical development.
