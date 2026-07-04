💊 Pharmacy Automation Simulator (Unity + C#)

A Unity-based simulation system that models a pharmacy prescription workflow using object-oriented design, service-layer architecture, and a centralized dispensing pipeline. The project simulates drug storage, prescription queuing, and automated dispensing using a modular and extensible C# backend.

📌 Overview

This project simulates a simplified pharmacy automation system where:

Drugs are created and stored in a repository
Patients submit prescriptions into a processing queue
A central dispatcher processes prescriptions
Drugs are dispensed via a cassette-based system
A Unity UI layer allows interaction and input

The system emphasizes clean architecture principles, separation of concerns, and dependency-driven design.

🧠 Key Features
🧾 Prescription System
Patient prescriptions are validated and queued
Input validation for patient name, drug name, and quantity
Strongly typed prescription workflow

💊 Drug Management
Centralized drug repository
Dynamic drug creation system
Extensible drug data model

🤖 Automated Dispensing Pipeline
Central dispatcher processes prescription queue
Cassette system simulates physical dispensing hardware
Quantity-based dispensing logic

🧩 Architecture
Service-layer design (no logic in UI)
Dependency injection via Bootstrapper
Centralized system initialization
Clear separation between Unity and pure C# logic

🏗️ Architecture Overview
GameBootstrapper (System Core)
│
├── DrugRepository (Data Layer)
├── DrugService (Business Logic)
├── PrescriptionService (Validation Logic)
├── PharmacyDispatcher (Queue Processor)
│
├── DrugCreator (Factory)
└── Cassette / Spawner (Simulation Layer)
      ↓
   Unity UI Layer (Input & Display)

⚙️ Technologies Used
Unity Engine
C#
TMP (TextMeshPro UI)
Object-Oriented Programming (OOP)
Service Layer Architecture

🧱 Core Systems
🧭 GameBootstrapper

Central initialization point for all systems. Ensures all dependencies are created in the correct order.

💊 DrugRepository

Stores and retrieves all drug data in memory.

🧪 DrugService

Handles drug creation and validation logic.

📦 PrescriptionService

Validates and constructs prescription objects.

📋 PharmacyDispatcher

Manages prescription queue and triggers dispensing workflow.

💉 Cassette System

Simulates physical drug dispensing based on prescription quantity.
Dependency Injection (manual via Bootstrapper)

🖥️ UI System

Built using Unity UI + TextMeshPro:

Drug creation form
Prescription submission form
Queue visualization (optional expansion point)

UI acts purely as an input/output layer and does not contain business logic.

User Input (UI)
      ↓
PrescriptionService (Validation)
      ↓
PharmacyDispatcher (Queue)
      ↓
Cassette System (Dispensing)
      ↓
DrugRepository (Data Source)

🧪 Example Flow
User enters patient + medication details
Prescription is validated
Prescription is added to queue
Dispatcher processes queue
Cassette dispenses required quantity of medication

🧠 Design Principles Used
Separation of Concerns
Single Responsibility Principle (SRP)
Dependency Injection (manual)
Encapsulation of systems
Centralized initialization (Bootstrapper pattern)

🚧 Known Limitations
No persistent database (in-memory only)
No real-time multiplayer or networking
UI is basic and functional rather than production-polished
Dispatcher currently uses simplified queue processing

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
├── Models/
│   ├── Drug.cs
│   └── Prescription.cs
│
├── Factory/
│   └── DrugCreator.cs
│
├── UI/
│   └── InputFieldManager.cs
│
└── Simulation/
    ├── Cassette.cs
    └── DrugSpawner.cs

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
├── Models/
│   ├── Drug.cs
│   └── Prescription.cs
│
├── Factory/
│   └── DrugCreator.cs
│
├── UI/
│   └── InputFieldManager.cs
│
└── Simulation/
    ├── Cassette.cs
    └── DrugSpawner.cs

📜 License
This project is for educational and portfolio purposes.
