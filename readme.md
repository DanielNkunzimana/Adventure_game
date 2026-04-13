# Overview

As a software engineer, I am focused on mastering the C# ecosystem and understanding how its strong typing and object-oriented principles can be used to build scalable applications. This project served as an opportunity to move beyond basic syntax and explore architectural patterns like inheritance and memory-efficient data structures.

I developed a Text-Based Adventure Game where players can explore a dungeon, manage their health and gold, and encounter enemies. The software demonstrates core C# concepts including classes, structs, abstract methods, and the nullable reference type system introduced in recent versions of .NET.

The purpose of writing this software was to gain hands-on experience with the .NET 9 SDK and to understand the practical differences between value types (structs) and reference types (classes). Additionally, I aimed to implement a clean game loop that handles user input and state management effectively.

[Software Demo Video](http://youtube.link.goes.here)

# Development Environment

To develop this software, I used the following tools:
* **Visual Studio Code**: As the primary IDE for code editing and terminal management.
* **C# Dev Kit**: To provide IntelliSense and project management within VS Code.
* **Terminal / PowerShell**: For running .NET CLI commands.

The project was built using:
* **C# 12 / .NET 9**: The latest version of the C# language.
* **System Libraries**: Used `System` for console I/O and `System.Collections.Generic` for data management.

# Useful Websites

* [Microsoft C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
* [W3Schools C# Tutorial](https://www.w3schools.com/cs/index.php)
* [C# Corner - Abstract Classes vs Interfaces](https://www.c-sharpcorner.com/)

# Future Work

- **Persistence**: Implement a file-handling system (System.IO) to save player progress and high scores to a .txt or .json file.
- **Combat Depth**: Expand the `Entity` abstract class to include more complex battle mechanics and multiple enemy types.
- **Inventory System**: Transition from a simple `PlayerStats` struct to a more robust `List<Item>` collection to allow players to collect and use equipment.