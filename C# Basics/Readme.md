# C# vs .NET
    - C# is a programming language
    - .NET is a framework for building applications on Windows
    (There are different languages which can target and use .NET framework, C# is just one of them)

# The C language family

 - Before C#, C and C++, when compiled, would transform the code into the native machine readable code
 - i.e. A code run on x86 windows machine will be transformed to a x86 native code. Might be different for ARM architecture and others and so on.
 - So, When I try to run this code compiled on a Windows machine on some other system with a differrent architecture, it will not run.
 - So in C#, we borrow the compilation philosophy from JAVA, where the code isn't directly made into machine code but rather an intermediate language code (IL). It is independent of the platform or the architecture.
 - CLR which sits in the memory converts the IL into native code using a JIT (Just-In-Time) Method.

## Application

- Class is a container that has some attributes:
    - Data
    - Methods
- Eg: If Car is a class then you have
    - Data:
        - Make
        - Model
        - Color
    - Methods:
        - Start()
        - Move()
    etc.
- As the number of classes in an application grows, we need a way to organize these classes.That's where we use a **namespace**.

### Namespace
    - Namespace is a container for related classes. For example, in .NET framework we have namespaces containing tens of related classes. 
    - We have namespaces for working with data like databases
    - We also have namespaces for working with graphics and images, for working with security etc.

In the real world, as these namespaces grow, we need a different way of partitioning an application. That's where we use an Assembly (DLL or EXE).

### Assembly
    - An assembly is a container for related namespaces. Physically, its a file on the disk which can either be an executable or a DLL which stands for Dynamically Linked Library

So when you compile an application the compiler builds one or more assemblies depending on how you partition your code.