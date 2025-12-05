#  Batman 2D - Gotham Vigilance Training

A foundational 2D educational game built in Unity that demonstrates core game development mechanics through the lens of the Batman universe. This project focuses on implementing essential player controls, finite state machines, and inter-system communication patterns.

##  Project Purpose

This game serves as an excellent learning resource for understanding:

- **Finite State Machines (FSM)** for character behavior
- **Responsive 2D controls** and movement systems
- **Visual and audio feedback loops**
- **Component-based architecture** in Unity
- **System integration** and event-driven design

##  Getting Started

### Prerequisites

- **Unity Editor** (Recommended: 2021+)
- Basic familiarity with Unity interface

### Installation

1. Clone or download this repository
2. Open Unity Hub
3. Click "Add" and select the project folder
4. Open the project in Unity Editor
5. Navigate to `Assets/Scenes/MainScene.unity`
6. Press the **▶ Play** button to start

##  Controls

### Movement

| Key       | Action     | Description                   |
| --------- | ---------- | ----------------------------- |
| `A` / `←` | Move Left  | Change direction to Left      |
| `D` / `→` | Move Right | Change direction to right     |
| `W` / `↑` | Forward    | Move in facing direction      |
| `S` / `↓` | Backward   | Retreat from facing direction |

### State Switching

| Key     | State       | Description                 | Systems Affected |
| ------- | ----------- | --------------------------- | ---------------- |
| `N`     | **Normal**  | Balanced operational mode   | None             |
| `C`     | **Stealth** | Silent, low-profile mode    | None             |
| `Space` | **Alert**   | High-profile emergency mode | Alert Lights     |

### System Controls

| Key | System     | Action               |
| --- | ---------- | -------------------- |
| `B` | Bat-Signal | Toggle signal on/off |

##  Core Systems

### 1. Player Movement (`PlayerMovement.cs`)

Handles all character movement and input processing:

- Directional movement with sprite flipping
- Transform-based positioning
- Horizontal scale manipulation for facing direction

### 2. State Machine (`PlayerState.cs`)

Manages Batman's operational modes:

- **Normal State**: Default balanced mode
- **Stealth State**: Covert operations
- **Alert State**: Emergency response (triggers city-wide effects)

Clean FSM implementation with clear state transitions and event broadcasting.

### 3. Alert Lights System (`AlertLights.cs`)

Visual and audio response to Alert state:

- **Visual**: Alternating red/blue flashing lights
- **Audio**: Looping police siren
- **Activation**: Automatically triggered by Alert state
- **Customization**: Adjustable flash speed via Inspector

### 4. Bat-Signal Controller (`BatSignalController.cs`)

Gotham's iconic distress signal:

- Manual toggle with `B` key
- Yellow signal sprite with light effect
- Visual feedback for high-alert status

##  Project Structure

```
Assets/
├── Scripts/
│   ├── PlayerMovement.cs       # Input and movement logic
│   ├── PlayerState.cs          # FSM and state management
│   ├── AlertLights.cs          # Flashing lights and audio
│   └── BatSignalController.cs  # Signal toggle and events
│
├── Sprites/
│   ├── Batman/                 # Character sprites
│   ├── Background/             # Environment art
│   └── ...                     # Interface elements
│
├── Audio/
│   └── sax                     # Alert system sound
```

##  Technical Implementation

### Key Features

✅ **Directional Movement System** - Complete 2D movement with sprite flipping  
✅ **Finite State Machine** - Clean state management for Normal/Stealth/Alert modes  
✅ **Event-Driven Architecture** - Loose coupling between systems  
✅ **Inspector-Friendly** - Tunable parameters via `[SerializeField]`  
✅ **Modular Design** - Separated concerns across focused scripts

### Code Quality

- Clear separation of responsibilities
- Inspector-exposed parameters for rapid iteration
- Event-based communication between systems
- Extensible architecture for future features

## Learning Outcomes

By studying this project, you'll understand:

- How to implement a robust FSM in Unity
- Component-based game architecture patterns
- Synchronizing multiple systems through events
- Best practices for 2D character controllers
- Audio-visual feedback implementation

##  Future Expansion Ideas

- Combat system with enemies
- Mission objectives and progression
- Inventory and gadget system
- Multiple Gotham environments
- NPC interaction system
- Save/load functionality

##  License

This is an educational project. Feel free to use it as a learning resource or starting point for your own projects.

                    **Built with Unity** | *A learning project for aspiring game developers*
