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

*Add your screenshots of gameplay here in the repo (e.g., under `/Screenshots`) and display them below.*

```markdown
![Main Menu](Screenshots/main_menu.png)
![Gameplay](Screenshots/gameplay.png)


