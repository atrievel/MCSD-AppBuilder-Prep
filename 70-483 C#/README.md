# Exam 70-483 Programming in C# Outline

## Manage Program Flow (25-30%)

### Implement multithreading and asynchronous processing

* Task Parallel library
    * Tasks
    * Parallel.For
    * PLINQ
* Create continuation tasks
* Spawn threads by using ThreadPool
* Unblock the UI
* Use async and await keywords
* Manage data by using concurrent collections

### Manage multithreading

* Synchronize resources
* Implement locking 
* Cancel a long-running task
* Implement thread-safe methods to handle race conditions

### Implement program flow

* Iterate across collection and array items
* Program decisions
    * Switch statements
    * If/then
    * Operators
    * Evaluate expressions

### Create and implement events and callbacks

* Create event handlers
* Subscribe to and unsubscribe from events
* Use built-in delegate types to create events
* Create delegates
* Lambda expressions
* Anonymous methods

### Implement exception handling

* Handle exception types
    * SQL exceptions
    * Network exceptions
    * Communication exceptions
    * Network timeout exceptions
* Use catch statements 
* Use base class exceptions
* Implement try-catch-finally blocks
* Throw exceptions 
* Rethrow and exception
* Create custom exceptions
* Handle inner exceptions 
* Handle aggregate exception

## Create and Use Types (25-30%)

### Create types

* Create value types
    * Struct
    * Enum
* Create reference types
* Generics
* Constructors
* Static variables
* Methods
* Classes 
* Extension methods
* Create optional and named parameter
* Create indexed properties
* Create overloaded and overriden methods

### Consume types

* Box or unbox to convert between value types
* Cast types
* Convert types
* Handle **dynamic** types
* Ensure interoperability with code that accesses COM APIs

### Enforce encapsulation

* Enforce encapsulation by using properties
* Enforce encapsulation by using accessors
    * Public
    * Private
    * Protected
    * Internal
* Enforce encapsulation by using explicit interface implementation

### Create and implement a class hierarchy

* Design and implement an interface
* Inherit from a base class
* Create and implement classes based on interfaces:
    * IComparable
    * IEnumerable
    * IDisposable
    * IUnknown interfaces

### Find, execute, and create types at runtime by using reflection

* Create and apply attributes
* Read attributes
* Generate code at runtime by using CodeDom and Lambda expressions
* Use types from the System.Reflection namespace: 
    * Assembly
    * PropertyInfo
    * MethodInfo
    * Type

### Manage the object life cycle

* Manage unmanaged resources
* Implement IDisposable
    * Interaction with finalization 
* Manage IDisposable by using the Using statement
* Manage finalization and garbage collection

### [Manipulate strings] (https://github.com/atrievel/MCSD-AppBuilder-Prep/tree/master/70-483%20C%23/Manipulate.Strings)

* Manipulate strings by using classes:
    * StringBuilder
    * StringWriter
    * StringReader
* Search strings
* Enumerate string methods
* Format strings
* Use string interpolation

## Debug Applications and Implement Security (25-30%)

### Validate application input

* Validate JSON data
* Choose the appropriate data collection type
* Manage data integrity
* Evaluate a regular expression to validate the input format
* Use built-in functions to validate data type and content

### Perform symmetric and asymmetric encryption

* Choose an appropriate encryption algorithm
* Manage and create certificates
* Implement key management
* Implement the System.Security namespace
* Hash data
* Encrypt streams

### Manage assemblies

* Version assemblies
* Sign assemblies using strong names
* Implement side-by-side hosting
* Put an assembly in the global assembly cache
* Create a WinMD assembly

### Debug an application

* Create and manage preprocessor directives
* Choose an appropriate build type
* Manage program database files (debug symbols)

### Implement diagnostics in an application

* Implement logging and tracing
* Profiling applications
* Create and monitor performance counters
* Write to the event log

## Implement Data Access (25-30%)

### [Perform I/O operations] (https://github.com/atrievel/MCSD-AppBuilder-Prep/tree/master/70-483%20C%23/IO.Operations)

* Read and write files and streams
* Read and write from the network by using classes in the `System.Net` namespace
* Implement asynchronous I/O operations

### Consume data

* Retrieve data from a database
* Update data in a database
* Consume JSON and XML data
* Retrieve data by using web services

### Query and manipulate data and objects by using LINQ

* Query data by using operators
    * Projection
    * Join
    * Group
    * Take
    * Skip
    * Aggregate
* Create method based LINQ queries
* Query data by using query comprehension syntax
* Select data by using anonymous types; 
* Force execution of a query;
* LINQ to XML
    * Read
    * Filter
    * Create
    * Modify

### Serialize and deserialize data

* Serialize and deserialize data
    * Binary serialization 
    * Custom serialization
    * XML Serializer
    * JSON Serializer 
    * Data Contract Serializer

### Store data in and retrieve data from collections

* Store and retrieve data by using:
    * Dictionaries
    * Arrays
    * Lists
    * Sets
    * Queues 
* Choose a collection type
* Initialize a collection
* Add and remove items from a collection 
* Use typed vs. non-typed collections
* Implement custom collections
* Implement collection interfaces