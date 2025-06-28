# Cybershield Guardian Unity Project Setup Instructions

This document guides you through setting up the Cybershield Guardian project in Unity Hub with the proper project structure and importing existing scripts.

## Step 1: Create a New Unity Project

1. Open **Unity Hub**.
2. Click **New Project**.
3. Select the **Universal Render Pipeline (URP) 3D** template.
4. Name the project `CybershieldGuardian`.
5. Choose a location to save the project.
6. Click **Create**.

## Step 2: Import Existing Scripts

1. After the project opens in Unity Editor, locate the `Assets` folder in the Project window.
2. Create a new folder inside `Assets` named `Scripts`.
3. Copy all `.cs` script files from your existing `CybershieldGuardian/Scripts` directory into the new `Assets/Scripts` folder.
4. In Unity Editor, the scripts will be automatically imported.

## Step 3: Configure Project Settings for Android

1. Go to **File > Build Settings**.
2. Select **Android** as the target platform.
3. Click **Switch Platform**.
4. Ensure you have the Android SDK and NDK installed via Unity Hub.
5. Configure Player Settings as needed (e.g., package name, minimum API level).

## Step 4: Build and Deploy APK

1. Connect your Samsung device with USB debugging enabled.
2. In **Build Settings**, click **Build and Run**.
3. Unity will build the APK and install it on your device.

---

If you encounter any issues or need further assistance, please let me know.
