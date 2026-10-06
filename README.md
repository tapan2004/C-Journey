# C# Journey 🚀

A hands-on journey from **Java → C# → .NET**, focused on learning C# by mapping familiar Java concepts to their C# equivalents and implementing everything through practical examples.

> **Background:** Java Developer
> **Learning Path:** Java → C# → .NET → ASP.NET Core → gRPC → SQLite

The goal of this repository is not just to learn C# syntax, but to understand **how C#/.NET concepts compare with Java** and gradually become comfortable building real-world applications.

---

# 📚 Topics Covered

## 1. C# Fundamentals

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

---

# 2. Java → C# Fundamentals

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

# 🧱 Object-Oriented Programming

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

## Java → C# Property Difference

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

Properties are one of the important differences to understand when moving from Java to C#.

---

# 📦 Collections

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

## Java → C# Collection Mapping

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

### Example

Java:

```java
HashMap<Integer, String> cameras = new HashMap<>();
```

C#:

```csharp
Dictionary<int, string> cameras = new();
```

---

# 🧬 Generics

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

## Topics

* Generic Classes
* Generic Methods
* Generic Interfaces
* Generic Constraints
* `T`
* `where` constraints

---

# ⚡ Lambda Expressions

Java:

```java
x -> x * 2
```

C#:

```csharp
x => x * 2
```

Lambda expressions are especially important because they are heavily used with:

* LINQ
* Delegates
* Events
* Collections
* Asynchronous Programming

---

# 🔎 LINQ — C# Stream API Equivalent

One of the most important concepts for a Java developer moving to C# is **LINQ**.

## Java → C# Mapping

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

### Java

```java
var result = cameras.stream()
    .filter(c -> c.isConnected())
    .toList();
```

### C#

```csharp
var result = cameras
    .Where(c => c.IsConnected)
    .ToList();
```

## LINQ Topics

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

# 🚨 Exception Handling

* `try`
* `catch`
* `finally`
* `throw`
* Custom Exceptions
* Exception Filters
* No Checked Exceptions

## Java → C#

| Java               | C#                   |
| ------------------ | -------------------- |
| `try`              | `try`                |
| `catch`            | `catch`              |
| `finally`          | `finally`            |
| `throw`            | `throw`              |
| `Exception`        | `Exception`          |
| Checked Exceptions | No direct equivalent |

---

# 🔄 Async & Concurrency

This area is particularly important for backend and camera/RTSP applications.

## Java → C# Mapping

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

### Java

```java
CompletableFuture.runAsync(() -> {
    connectCamera();
});
```

### C#

```csharp
Task.Run(() =>
{
    ConnectCamera();
});
```

### C# async programming

```csharp
async Task ConnectCameraAsync()
{
    await ConnectAsync();
}
```

## Topics

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

# 🎯 Delegates & Events

Delegates and events are important C# concepts that do not have a direct one-to-one Java equivalent.

## Delegates

* `Action`
* `Func`
* `Predicate`
* Custom Delegates
* Lambda + Delegates

## Events

* Event declaration
* Event handlers
* Publisher / Subscriber pattern
* Event-driven programming

---

# 🧩 Important C# Concepts

These concepts should be learned separately rather than treated as simple Java equivalents.

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

### Common Commands

```bash
dotnet new console
dotnet build
dotnet run
dotnet test
dotnet clean
dotnet restore
```

## Java → .NET Mapping

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

# 📦 NuGet & Project Structure

## Topics

* `.csproj`
* Solution files
* Project files
* NuGet packages
* Package references
* Build configuration
* Debug / Release
* MSBuild
* Project references

### Example

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

After learning C# and .NET fundamentals, the next step is **ASP.NET Core**.

ASP.NET Core is the web framework in the .NET ecosystem used to build:

* REST APIs
* Web applications
* Backend services
* Real-time applications
* gRPC services

---

# ☕ Spring Boot → ASP.NET Core

| Java / Spring Boot       | C# / ASP.NET Core         |
| ------------------------ | ------------------------- |
| Spring Boot              | ASP.NET Core              |
| Controller               | Controller / Minimal API  |
| `@RestController`        | `[ApiController]`         |
| `@RequestMapping`        | `[Route]`                 |
| `@GetMapping`            | `[HttpGet]`               |
| `@PostMapping`           | `[HttpPost]`              |
| `@PutMapping`            | `[HttpPut]`               |
| `@PatchMapping`          | `[HttpPatch]`             |
| `@DeleteMapping`         | `[HttpDelete]`            |
| `@Autowired`             | Built-in .NET DI          |
| Spring DI                | .NET DI                   |
| `application.properties` | `appsettings.json`        |
| Spring Profiles          | ASP.NET Core Environments |
| Filter                   | Middleware / Filters      |
| Interceptor              | Middleware / Filters      |
| Jackson                  | `System.Text.Json`        |
| JPA / Hibernate          | EF Core                   |
| `CompletableFuture<T>`   | `Task<T>`                 |

---

# 🌐 ASP.NET Core Topics

* HTTP Fundamentals
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
* JSON Serialization
* Exception Handling
* API Validation
* HTTP Clients
* Model Binding
* Model Validation
* API Documentation
* Swagger / OpenAPI

---

# 🔌 REST API

ASP.NET Core supports all the standard HTTP operations required for CRUD-based REST APIs.

## CRUD Operations

| Operation         | HTTP Method | Spring Boot      | ASP.NET Core   |
| ----------------- | ----------- | ---------------- | -------------- |
| Read              | GET         | `@GetMapping`    | `[HttpGet]`    |
| Create            | POST        | `@PostMapping`   | `[HttpPost]`   |
| Update completely | PUT         | `@PutMapping`    | `[HttpPut]`    |
| Update partially  | PATCH       | `@PatchMapping`  | `[HttpPatch]`  |
| Delete            | DELETE      | `@DeleteMapping` | `[HttpDelete]` |

---

# 📝 ASP.NET Core CRUD Example

A typical ASP.NET Core Controller can look like this:

```csharp
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/cameras")]
public class CameraController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllCameras()
    {
        // Get all cameras
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetCamera(int id)
    {
        // Get specific camera
        return Ok();
    }

    [HttpPost]
    public IActionResult CreateCamera(Camera camera)
    {
        // Create camera
        return Ok(camera);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateCamera(int id, Camera camera)
    {
        // Update entire camera
        return Ok(camera);
    }

    [HttpPatch("{id}")]
    public IActionResult PartialUpdateCamera(int id, Camera camera)
    {
        // Update part of a camera
        return Ok(camera);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCamera(int id)
    {
        // Delete camera
        return NoContent();
    }
}
```

---

# 🔍 GET — Read Data

Spring Boot:

```java
@GetMapping
public List<Camera> getAll() {
    // ...
}
```

ASP.NET Core:

```csharp
[HttpGet]
public IActionResult GetAll()
{
    // ...
    return Ok();
}
```

Request:

```text
GET /api/cameras
```

---

# 🔎 GET By ID — Route Parameter

Spring Boot:

```java
@GetMapping("/{id}")
public Camera getById(@PathVariable int id) {
    // ...
}
```

ASP.NET Core:

```csharp
[HttpGet("{id}")]
public IActionResult GetById(int id)
{
    // ...
    return Ok();
}
```

Request:

```text
GET /api/cameras/100
```

Here:

```text
100 → id
```

The `{id}` in the route is bound to the `id` parameter.

---

# ➕ POST — Create Data

Spring Boot:

```java
@PostMapping
public Camera create(@RequestBody Camera camera) {
    // ...
}
```

ASP.NET Core:

```csharp
[HttpPost]
public IActionResult Create(Camera camera)
{
    // ...
    return Ok(camera);
}
```

You can explicitly specify the request body:

```csharp
[HttpPost]
public IActionResult Create([FromBody] Camera camera)
{
    // ...
    return Ok(camera);
}
```

With `[ApiController]`, ASP.NET Core can automatically infer that a complex object such as `Camera` comes from the request body.

---

# ✏️ PUT — Complete Update

PUT is normally used when replacing/updating a resource completely.

Spring Boot:

```java
@PutMapping("/{id}")
public Camera update(
        @PathVariable int id,
        @RequestBody Camera camera) {

    // ...
}
```

ASP.NET Core:

```csharp
[HttpPut("{id}")]
public IActionResult Update(int id, Camera camera)
{
    // ...
    return Ok(camera);
}
```

Request:

```text
PUT /api/cameras/100
```

---

# 🩹 PATCH — Partial Update

PATCH is normally used when updating only part of a resource.

Spring Boot:

```java
@PatchMapping("/{id}")
public Camera partialUpdate(
        @PathVariable int id,
        @RequestBody Camera camera) {

    // ...
}
```

ASP.NET Core:

```csharp
[HttpPatch("{id}")]
public IActionResult PartialUpdate(int id, Camera camera)
{
    // ...
    return Ok(camera);
}
```

Example resource:

```json
{
    "name": "Camera 100",
    "ipAddress": "192.168.1.100",
    "status": "Online",
    "resolution": "5MP"
}
```

A PATCH request could update only the status:

```json
{
    "status": "Offline"
}
```

---

# 🗑️ DELETE — Remove Data

Spring Boot:

```java
@DeleteMapping("/{id}")
public void delete(@PathVariable int id) {
    // ...
}
```

ASP.NET Core:

```csharp
[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    // ...
    return NoContent();
}
```

Request:

```text
DELETE /api/cameras/100
```

---

# 🔍 Query Parameters

There is normally **no `QUERY` HTTP method** in a standard CRUD REST API.

When developers say "query", they often mean **query parameters**.

Example:

```text
GET /api/cameras?status=online&page=1
```

Here:

```text
status=online
page=1
```

are query parameters.

Query parameters are commonly used for:

* Filtering
* Searching
* Sorting
* Pagination
* Optional parameters

---

# 🔎 Query Parameters — Spring Boot

```java
@GetMapping
public List<Camera> getCameras(
        @RequestParam String status,
        @RequestParam int page) {

    // ...
}
```

Request:

```text
GET /api/cameras?status=online&page=1
```

---

# 🔎 Query Parameters — ASP.NET Core

```csharp
[HttpGet]
public IActionResult GetCameras(
    string status,
    int page)
{
    // ...
    return Ok();
}
```

ASP.NET Core automatically binds:

```text
status → "online"
page   → 1
```

You can also explicitly specify query parameters:

```csharp
[HttpGet]
public IActionResult GetCameras(
    [FromQuery] string status,
    [FromQuery] int page)
{
    // ...
    return Ok();
}
```

---

# 📍 Route Parameters vs Query Parameters

This is an important distinction.

## Route Parameter

Used to identify a specific resource.

```text
GET /api/cameras/100
```

ASP.NET Core:

```csharp
[HttpGet("{id}")]
public IActionResult Get(int id)
{
    return Ok();
}
```

Here:

```text
{id} → route parameter
```

---

## Query Parameter

Used for filtering, searching, sorting, pagination, etc.

```text
GET /api/cameras?status=online&page=1
```

ASP.NET Core:

```csharp
[HttpGet]
public IActionResult Get(
    [FromQuery] string status,
    [FromQuery] int page)
{
    return Ok();
}
```

Here:

```text
status → query parameter
page   → query parameter
```

---

# 📦 Request Body

Spring Boot:

```java
@PostMapping
public Camera create(@RequestBody Camera camera)
```

ASP.NET Core:

```csharp
[HttpPost]
public IActionResult Create([FromBody] Camera camera)
```

Example JSON:

```json
{
    "name": "Camera 001",
    "ipAddress": "192.168.1.100",
    "resolution": "5MP"
}
```

---

# 📤 Response Handling

Spring Boot commonly uses:

```java
ResponseEntity<Camera>
```

ASP.NET Core can use:

```csharp
IActionResult
```

or:

```csharp
ActionResult<Camera>
```

Example:

```csharp
[HttpGet("{id}")]
public ActionResult<Camera> GetCamera(int id)
{
    var camera = GetCameraFromDatabase(id);

    if (camera == null)
    {
        return NotFound();
    }

    return Ok(camera);
}
```

Common HTTP responses:

```text
200 OK
201 Created
204 No Content
400 Bad Request
401 Unauthorized
403 Forbidden
404 Not Found
500 Internal Server Error
```

---

# 🏗️ Recommended ASP.NET Core Structure

For a larger application, the controller should not contain all business logic.

A common structure is:

```text
MyApplication/
│
├── Controllers/
│   └── CameraController.cs
│
├── Services/
│   └── CameraService.cs
│
├── Models/
│   └── Camera.cs
│
├── DTOs/
│   └── CameraDto.cs
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── Repositories/
│   └── CameraRepository.cs
│
├── Program.cs
├── appsettings.json
└── MyApplication.csproj
```

The general flow is:

```text
Client
   ↓
Controller
   ↓
Service
   ↓
Repository / EF Core
   ↓
Database
```

This is conceptually similar to the layered architecture commonly used in Spring Boot applications.

---

# 🔗 gRPC

The learning path also includes communication between services using **gRPC**.

## Topics

* What is RPC?
* Protocol Buffers
* `.proto` files
* Service definitions
* Client / Server
* Unary RPC
* Streaming RPC
* gRPC in .NET
* gRPC communication between services

Java gRPC concepts can be mapped to the .NET gRPC ecosystem.

---

# 🗄️ Database & SQLite

Database learning will focus on **SQLite** for lightweight application storage.

## Java → C# Mapping

| Java            | C# / .NET     |
| --------------- | ------------- |
| JDBC            | ADO.NET       |
| JPA             | EF Core       |
| Hibernate       | EF Core       |
| `EntityManager` | `DbContext`   |
| JPQL            | LINQ          |
| `@Entity`       | EF Core model |
| `@Id`           | `[Key]`       |

## Learning Path

```text
C#
 ↓
.NET
 ↓
EF Core
 ↓
SQLite
```

## Topics

* SQL Basics
* Tables
* Primary Keys
* Foreign Keys
* CRUD
* Relationships
* EF Core
* `DbContext`
* Migrations
* LINQ Queries
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
* Camera Status
* API Communication
* Service Communication
* Application Data

---

# 🧪 Testing

## Java → C#

| Java    | C#                     |
| ------- | ---------------------- |
| JUnit   | xUnit / NUnit / MSTest |
| `@Test` | `[Fact]` in xUnit      |
| Mockito | Moq / NSubstitute      |
| AssertJ | FluentAssertions       |

Primary testing framework for this journey:

**xUnit**

## Topics

* Unit Testing
* Integration Testing
* Assertions
* Test Fixtures
* Mocking
* Test-driven development basics
* Automated Testing

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

The long-term goal is to move from:

```text
Java Developer
      ↓
C# Developer
      ↓
.NET Developer
      ↓
ASP.NET Core Developer
      ↓
Productive .NET Engineer
```

and apply these skills to real-world software projects.

---

# 📈 Progress

This repository is continuously updated as I learn new C# and .NET concepts.

Each topic is implemented through practical examples so that the repository becomes both:

1. A **learning journey**
2. A **Java → C# reference guide**

---

# 🚀 Learning Philosophy

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

# 📌 Future Topics

* Advanced LINQ
* Advanced Async Programming
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
* Real-world .NET Projects

---

# 👨‍💻 Author

**Tapan Manna**

Learning and documenting the journey from:

**Java → C# → .NET**

through practical development.
