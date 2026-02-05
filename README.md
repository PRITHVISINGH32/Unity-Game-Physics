# VectorExample – Unity Movement Script

This repository contains a simple Unity `MonoBehaviour` script demonstrating how to move a GameObject in 3D space using Unity’s built-in input system and vector math.  
The script shows how to:

- Read horizontal and vertical input
- Build a movement vector
- Normalize movement for consistent speed
- Apply movement over time
- Track and log positions

---

## 📌 Script Overview

The script listens for **WASD** / **Arrow Key** movement and moves the GameObject accordingly.  
It stores a separate `targetPosition` so movements accumulate over time instead of manipulating the transform directly each frame.

### 🔧 Core Functionality

- Uses Unity’s `Input.GetAxis`
- Normalizes diagonal movement
- Multiplies by speed and `Time.deltaTime` for smooth framerate-independent motion
- Updates `transform.position`
- Logs useful debug info to the console

---


