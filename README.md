# CSE210 Student Template

I am currently reviewing past lessons to refamiliarize myself with C# and strengthen my understanding of core programming concepts. This repository serves as a workspace for practice, experimentation, and growth in software development.

---

## 📁 Project Structure

This repository contains starter code for students in CSE 210, organized as follows:

- `sandbox` - An empty project for experimenting with concepts.
- `csharp-prep` - Starter projects for each of the C# Prep assignments.
- `prepare` - Starter projects for preparation learning activities.
- `prove` - Starter projects for developer "prove" projects.
- `final` - Starter projects for the final project.

---

## 🚀 Getting Started

### Create and Run a Project

To create a new .NET (C#) project:

```bash
dotnet new console
````

To run a project:

```bash
dotnet run
```

---

## 🔍 Check .NET Version

To check your current installed SDK version:

```bash
dotnet --version
```

To see all installed SDKs:

```bash
dotnet --list-sdks
```

---

## ⬇️ Install / Update .NET

If you need to install or update to the latest version (currently using .NET 10):

1. Visit the official download page: [https://aka.ms/dotnet/download](https://aka.ms/dotnet/download)
2. Download the latest **.NET SDK** (not just the runtime)
3. Run the installer and follow the setup instructions
4. Restart your terminal after installation

---

## ⚠️ Important Note

Ensure your project’s `.csproj` file matches your installed SDK version.

Example:

```xml
<TargetFramework>net10.0</TargetFramework>
```

If you encounter errors, you may need to:

* Update your SDK
* Or change the target framework to match your installed version

---

## ⚙️ VS Code Configuration Fix

If your program is not reading input correctly, update your `launch.json` file:

Change this:

```json
"console": "internalConsole"
```

To this:

```json
"console": "integratedTerminal"
```

This allows the program to properly handle user input through the terminal.

---

## 🧠 Development Focus

The goal of this repository is to:

* Refresh C# fundamentals
* Practice object-oriented programming (OOP)
* Work with UML to design and plan applications
* Build and understand more complex systems
* Strengthen problem-solving and software design skills
* Prepare for advanced software development projects and real-world applications







