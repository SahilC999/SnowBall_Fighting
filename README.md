# ❄️ Snow Ball Fighting 🎮

**Snow Ball Fighting** is a 2D winter-themed multiplayer game built using **Unity Engine**, where **two players** compete using the **same keyboard** to throw snowballs at each other. Each successful hit reduces the opponent's HP by 20 points. The first to reduce the opponent’s health to zero wins!

---

## 🧊 Features

- 🎮 2-Player local multiplayer
- ❄️ Snowball attack system with projectile damage
- ❤️ Health system with UI bars
- ⏸️ Pause and Resume menu with `Esc` key
- 📊 Game Manager for managing score and gameplay state
- 📋 Main menu and restart options
- ⌨️ Single-keyboard controls (split layout)

---

## 🧑‍💻 Controls

| Action         | Player 1 (Left) | Player 2 (Right) |
|----------------|----------------|------------------|
| Move Left      | A              | ← (Left Arrow)   |
| Move Right     | D              | → (Right Arrow)  |
| Jump           | SPACE          | ↑ (Up Arrow)     |
| Throw Snowball | S              | ↓ (Down Arrow)   |
| Pause          | `Esc` Key      | `Esc` Key        |

---

## 📁 Project Structure

SnowBallFighting/
├── Assets/
│ ├── Scripts/
│ │ ├── PlayerController.cs
│ │ ├── Snowball.cs
│ │ ├── GameManager.cs
│ │ ├── HealthBar.cs
│ │ ├── PauseMenu.cs
│ │ └── MenuManager.cs
│ ├── Scenes/
│ │ ├── MainMenu.unity
│ │ └── GameScene.unity
│ └── Prefabs/
│ ├── Player1.prefab
│ ├── Player2.prefab
│ └── Snowball.prefab
├── README.md
└── ProjectSettings/


---

## ▶️ How to Run This Game

1. **Install Unity Hub** and open it.
2. Create a new 2D project using **Unity version 2021.3.x LTS** or higher.
3. Copy the contents of this repository into your Unity project folder.
4. In Unity, go to:
   - `File > Open Scene` and load `Scenes/GameScene.unity`.
   - Or start with `MainMenu.unity` for full experience.
5. Press **Play** in Unity Editor to start the game.

---

## 🏆 How to Win

- Hit your opponent 5 times (each hit removes 20 HP).
- Watch their HP bar drain — when it hits 0, you win!

---

## 🧱 Built With

- Unity Engine (2D)
- C#
- Unity UI Toolkit
- Particle Systems
- Pixel Art (for visuals)

---

## 👨‍🔧 Developers

This project was built in the **2nd year of B.Tech** as a learning experience in:
- Unity game development
- Object-oriented programming with C#
- Game mechanics like health, input, and physics

---

## 📜 License

This project is for **educational and showcase purposes only**. You may use or modify it for personal learning or portfolio projects.

---

## 📷 Screenshots

<img width="988" height="543" alt="image" src="https://github.com/user-attachments/assets/a21cef7f-a101-4255-8aec-013a8db09282" />

<img width="992" height="536" alt="image" src="https://github.com/user-attachments/assets/34d01b51-ea49-4901-9c80-d2c9d3897924" />

<img width="990" height="536" alt="image" src="https://github.com/user-attachments/assets/42ac3043-cea8-47a0-aa1b-e479db82c33a" />

<img width="991" height="542" alt="image" src="https://github.com/user-attachments/assets/9326b3f2-dd43-4b54-8536-0da363037045" />








