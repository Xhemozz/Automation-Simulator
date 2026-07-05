# 💊 Pharmacy Automation Simulator (Unity + C#)

A Unity-based simulation system that models a pharmacy prescription workflow using object-oriented design, service-layer architecture, and a centralized dispensing pipeline.

The project simulates drug storage, prescription queuing, and automated dispensing using a modular and extensible C# backend.

---
[![Watch the demo](https://www.youtube.com/watch?v=gXx3rWaOFig)
---

## 📌 Overview

This project simulates a simplified pharmacy automation system where:

- 💊 Drugs are created and stored in a repository
- 📝 Pharmacy staff enter prescriptions into a processing queue
- ⚙️ A central dispatcher processes prescriptions
- 📦 Drugs are dispensed via a cassette-based system
- 🖥️ A Unity UI layer allows interaction and input

The architecture emphasizes:

- Clean Architecture
- Separation of Concerns
- Dependency Injection
- Object-Oriented Design
- Service-Layer Architecture

---

## ✨ Features

### 🧾 Prescription System

- Prescription validation
- Queue-based processing
- Strongly typed prescription objects
- Input validation for:
  - Patient name
  - Drug name
  - Quantity

### 💊 Drug Management

- Centralized in-memory repository
- Dynamic drug creation
- Extensible drug model

### 🤖 Automated Dispensing

- Central dispatcher
- Cassette-based dispensing simulation
- Quantity-aware dispensing logic

### 🧩 Architecture

- Service-layer architecture
- Manual dependency injection
- Bootstrapper pattern
- Pure C# business logic separated from Unity UI

---

# 🏗️ Architecture

```text
GameBootstrapper
│
├── DrugRepository
├── DrugService
├── PrescriptionService
├── PharmacyDispatcher
│
├── DrugCreator
└── Cassette / DrugSpawner
      │
      ▼
Unity UI
```

---

# 🔄 System Workflow

```text
User Input (Unity UI)
        │
        ▼
PrescriptionService
        │
        ▼
PharmacyDispatcher
        │
        ▼
Cassette System
        │
        ▼
DrugRepository
```

---

# 🧪 Example Workflow

1. Pharmacy staff enter the patient's prescription.
2. Prescription details are validated.
3. The prescription is added to the processing queue.
4. The dispatcher processes queued prescriptions.
5. The cassette system dispenses the requested quantity of medication.

---

# ⚙️ Technologies

- Unity
- C#
- TextMeshPro (TMP)
- Object-Oriented Programming (OOP)
- Service Layer Architecture

---

# 📦 Core Systems

## 🧭 GameBootstrapper

Initializes every system and wires dependencies together.

---

## 💊 DrugRepository

Stores all drug data in memory.

Responsibilities:

- Add drugs
- Retrieve drugs
- Central data storage

---

## 🧪 DrugService

Business logic responsible for:

- Drug creation
- Validation
- Repository interaction

---

## 📋 PrescriptionService

Responsible for:

- Prescription validation
- Building prescription objects
- Input verification

---

## 📦 PharmacyDispatcher

Handles:

- Prescription queue
- Processing workflow
- Dispensing requests

---

## 💉 Cassette System

Simulates automated medication dispensing.

Features:

- Quantity-based dispensing
- Hardware simulation layer
- Drug spawning

---

## 🖥️ Unity UI

Built with:

- Unity UI
- TextMeshPro

UI Responsibilities:

- Drug creation form
- Prescription submission
- User interaction

No business logic exists inside the UI layer.

---

# 📂 Project Structure

```text
Scripts/
│
├── Bootstrap/
│   └── GameBootstrapper.cs
│
├── Core/
│   ├── DrugService.cs
│   ├── PrescriptionService.cs
│   └── PharmacyDispatcher.cs
│
├── Data/
│   └── DrugRepository.cs
│
├── Factory/
│   └── DrugCreator.cs
│
├── Models/
│   ├── Drug.cs
│   └── Prescription.cs
│
├── Simulation/
│   ├── Cassette.cs
│   └── DrugSpawner.cs
│
└── UI/
    └── InputFieldManager.cs
```

---

# 🧠 Design Principles

- Separation of Concerns
- Single Responsibility Principle (SRP)
- Dependency Injection
- Encapsulation
- Bootstrapper Pattern
- Modular Service Layer

---

# 🚧 Current Limitations

- In-memory data only (no persistence)
- No networking or multiplayer
- Basic UI focused on functionality
- Simplified queue processing logic

---

# 📜 License

This project was created for educational and portfolio purposes.
