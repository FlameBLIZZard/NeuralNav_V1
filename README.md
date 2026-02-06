# Neural-Nav v1.0 | Operation Reconstruction: Project 01

NeuralNav_V1 is a student-led research project focused on **decoupling AI decision-making (The Brain) from the game engine (The Body)**. This repository serves as the foundational "Handshake" project within my 360-day **Operation Reconstruction** roadmap.

The primary objective is to establish a real-time, bidirectional communication bridge between **Unity (C#)** and a standalone **Python AI environment** using TCP/UDP sockets.

---

## 🚀 Project Status: [PHASE 1: FOUNDATIONS]
Current Focus: Environment stability, input handling, and coordinate streaming.

### Key Features (Implemented)
* **Custom Environment:** Modular obstacles and goal markers modeled in Blender specifically for collision testing.
* **Hybrid Input System:** Implemented C# movement logic that supports both the legacy and the New Unity Input System.
* **Independent Axis Movement:** Player movement is calculated relative to global axes, independent of facing direction, for cleaner navigation data.
* **Smooth-Follow Camera:** Custom script providing offset-based tracking for the agent during testing.
* **Real-time Telemetry:** C# Position Checker streaming world coordinates $(X, Y, Z)$ to the console in preparation for socket export.

---

## 🛠️ Technical Stack
* **Game Engine:** Unity 6 LTS
* **3D Modeling:** Blender 3.0+
* **Programming:** C# (Engine Logic) & Python (Planned Inference)
* **Protocol:** TCP/JSON Handshake (In Development)



---

## 🏗️ Technical Hurdles & Dev Logs
As I am currently a student learning the basics of Unity physics and asset optimization, I am documenting the "bruh" moments and logic shifts daily. 

Current research topics include:
* **Anti-Aliasing:** Resolving jagged edges on Blender-imported assets in the Game View.
* **Data Latency:** Minimizing the round-trip time between Python logic and Unity execution.

**Full Technical Logs:** [aditya-dev.com](https://aditya-dev.com)

---

## 📥 Getting Started
1. **Clone the Repo:**
   `git clone https://github.com/FlameBLIZZard/NeuralNav_V1.git`
2. **Open in Unity:** Select the `NeuralNav_V1` folder. Ensure you are using **Unity 6 LTS** or higher.
3. **Run the Scene:** Open `Scenes/Main_Prototype.unity` and press Play to test the current movement and camera follow logic.

---

## 👋 Contribution & Ideas
I am strictly focused on building a scalable AI foundation for gameplay programming while pursuing my Computer Engineering degree. Since I am still mastering Unity-specific pipelines, I am **open to suggestions, resources, or ideas** from anyone experienced in AI-to-Engine integration.

**Author:** Aditya Girish Bhoite
**Profile:** Computer Engineering Student | Aspiring AI Gameplay Programmer
