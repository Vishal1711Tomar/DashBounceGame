# 🎮 Bounce Dash — A Hyper-Casual 2D Game

**Bounce Dash** is a minimalist, hyper-casual 2D arcade game developed in Unity 6. In this game, you control a bouncing ball that navigates vertically through a series of obstacles while collecting coins to achieve the highest score possible.

---

## 🧠 Objective

Guide the bouncing ball as far as possible while dodging obstacles and collecting coins. The game becomes progressively challenging, testing the player's reflexes and timing.

---

## 📋 Core Gameplay

- 🔁 **Auto Bouncing**: The ball continuously bounces upward.
- ↔️ **Player Movement**: Use `A/D` keys, `Arrow Keys`, or mobile swipe to move left or right.
- 📈 **Vertical Scrolling**: The level scrolls upward as the player progresses.
- ⚠️ **Obstacles**: Avoid traps like rotating blades, spikes, and more.
- 💰 **Collectibles**: Pick up coins to increase your score.
- ☠️ **Game Over**: Hitting any obstacle ends the game.

---

## 🧩 Features

### 🎮 Game Mechanics

- 💥 Physics-based bouncing (using Rigidbody2D)
- 🧍 Smooth left/right movement with PC and mobile input
- 🧱 Dynamic obstacle & coin spawning
- 📊 Score system (based on survival time + collected coins)

### 💡 UI/UX

- 🕹️ Start screen with Play button
- 🔄 Game Over screen with final score & restart option
- ✨ Visual effects (score pop, coin sparkle)
- 🧘 Clean minimalist UI for maximum clarity

### 🧰 Technical Stack

- 🛠️ Developed with **Unity 6**
- 📱 Mobile input support for swipe control
- 📁 Modular C# scripts:
  - `PlayerMovement.cs`
  - `BouncePhysics.cs`
  - `ObstacleSpawner.cs`
  - `CoinSpawner.cs`
  - `GameManager.cs`
  - `UIManager.cs`
- 💬 Code includes clear comments and structure for maintainability

---

## 🚀 How to Run the Game

1. Clone the repository or download the source files.
2. Open the project in **Unity 6**.
3. Set the build target to PC or Android.
4. Press `Play` in the Editor or build to your target platform.
5. Enjoy the bounce!

## 🤝 Contributions

Feel free to fork this repository and add your own features or improvements! PRs are welcome.

---

## 📜 License

This project is open-source and available under the MIT License.


