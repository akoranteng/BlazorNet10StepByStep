# Blazor .NET 10 Step-by-Step (MAUI Hybrid)

This repository contains a step-by-step learning path for building a .NET 10 MAUI Blazor Hybrid application.  
Each feature is developed in its own branch to support clean teaching, demos, and curriculum development.

---

## 🚀 Project Goals

- Teach .NET 10 and Blazor Hybrid concepts in a modular, incremental way  
- Provide clean, reproducible branches for each feature  
- Support blog articles, YouTube tutorials, and curriculum slide decks  
- Help learners avoid common pitfalls in MAUI + Git workflows  

---

## 🧱 Branch Structure

Each feature lives in its own branch:

- `main` – Stable, completed features  
- `01-model-creation` – Adding the Product model  
- `02-service-layer` – Creating the data service  
- `03-components` – Building UI components  
- `04-navigation` – Adding navigation and routing  
- (More branches coming…)  

This structure makes it easy for learners to follow along step-by-step.

---

## ⚠️ Gotchas & Best Practices

### 1. **Avoid OneDrive for MAUI Projects**
Storing MAUI or Visual Studio projects inside OneDrive causes:
- File locking  
- Build failures  
- Git conflicts  
- `.vs` corruption  
- Phantom untracked files  

**Fix:**  
Create a dedicated development folder outside OneDrive, such as:

Clone your repo there before creating your MAUI solution.

---

### 2. **Clone First, Create Project Second**
Always:

Then create your MAUI project **inside** the cloned folder.  
This keeps your Git history clean and avoids nested folder issues.

---

### 3. **Use “Auto” Interactivity Mode**
When creating the MAUI Blazor project:
- Choose **Auto** for Interactivity Render Mode  
- Leave **Page-per-component** options **off**  

This keeps the project clean and aligned with modern Blazor Hybrid patterns.

---

## 🛠 Requirements

- .NET 10 SDK  
- Visual Studio 2022 (latest)  
- MAUI workload installed  

---

## 🎯 Purpose

This repository supports:
- Blog articles  
- YouTube tutorials  
- Curriculum slides  
- Step-by-step teaching demos  

It is designed to be modular, clean, and beginner-friendly.

---

## 📚 License

MIT License.
Testing



