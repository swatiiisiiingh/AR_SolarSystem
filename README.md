# AR Solar System 🪐

An interactive Augmented Reality solar system application built in **Unity 6** using **AR Foundation** and the **XR Interaction Toolkit**. The application allows users to detect real-world surfaces, place an interactive planetary system into physical space, and observe planetary orbits and rotations with dynamic lighting estimation.

---

## 🌟 Key Features

* **Surface Detection & AR Placement:** Uses AR plane tracking to detect real-world horizontal surfaces and allows tap-to-place positioning of the solar system model via `ARTapToPlace.cs`.


* **Planetary Mechanics:**
* **Axial Rotation:** Individual planet rotation scripts (`SelfRotate.cs`) simulating real-world planetary spin.


* **Orbital Motion:** Pivot-based revolution mechanisms (`Orbit.cs`) simulating planetary orbits around the central Sun.




* **Realistic AR Lighting:** Integrated `LightEstimationApplier.cs` leveraging AR Foundation's ambient lighting data to match virtual planet illumination with physical real-world lighting conditions.


* **Unity Input System:** Powered by the modern Unity Input System for touch interaction and placement controls.



---

## 📁 Project Architecture

```text
AR_SolarSystem/
├── Assets/
│   ├── Scenes/
│   │   └── SampleScene.unity            # Main AR Solar System scene
│   ├── XR/                              # AR Plane and XR Configuration
│   ├── ARTapToPlace.cs                  # Raycasts against AR planes to place the system
│   ├── Orbit.cs                         # Handles orbital motion around pivot targets
│   ├── SelfRotate.cs                    # Handles continuous self-rotation on planetary axes
│   ├── LightEstimationApplier.cs        # Applies ambient intensity & color temperature from camera
│   ├── Mat_Planet1..8.mat               # Celestial body surface textures and materials
│   └── InputSystem_Actions.inputactions # Input action definitions for touch and interactions
├── Packages/                            # AR Foundation, XR Origin, Input System dependencies
└── ProjectSettings/                     # Project configuration and XR platform settings

```

(References:)

---

## 🛠️ Tech Stack & Requirements

* **Engine:** Unity 6 (6000.x)


* **Target Platform:** Android (ARCore supported device)


* **Render Pipeline:** Universal Render Pipeline (URP)


* **Key Packages:**
* `com.unity.xr.arfoundation`

* `com.unity.xr.openxr` / `Google ARCore XR Plugin`

* `com.unity.inputsystem`




---

## 🚀 Getting Started

### Prerequisites

1. Install **Unity 6 (6000.x)** via Unity Hub with the **Android Build Support** module (including Android SDK & NDK tools).


2. An ARCore-compatible Android phone connected via USB with **USB Debugging** enabled.

### Installation & Setup

1. **Clone the repository:**
```bash
git clone https://github.com/swatiiisiiingh/AR_SolarSystem.git
cd AR_SolarSystem

```


2. **Open in Unity:**
* Open **Unity Hub**.
* Click **Add** > **Add project from disk**.
* Select the cloned `AR_SolarSystem` folder.


* Open the project with **Unity 6**.




3. **Open the Scene:**
* Navigate to `Assets/Scenes/SampleScene.unity`.





---

## 📱 Building to Android

1. Go to **File** > **Build Profiles** (or **Build Settings**).


2. Switch platform to **Android**.


3. Ensure `SampleScene` is checked in the scenes list.


4. Connect your Android device via USB and click **Build and Run**.
5. Once launched on the phone:
* Scan an open horizontal floor or table until the AR plane grid appears.
* Tap on the detected plane to anchor the solar system into your room.





---

## 📜 License

This project is open-source and available under the [MIT License](https://www.google.com/search?q=LICENSE).
