# Simple Desktop Wallpaper Changer - WinForms 🖼️

![C#](https://img.shields.io/badge/Language-C%23-blue?style=flat-square)
![.NET](https://img.shields.io/badge/.NET-7.0-purple?style=flat-square)
![Status](https://img.shields.io/badge/Status-Completed-green?style=flat-square)

A **simple C# Windows Forms application** that allows you to **select an image and set it as your Windows desktop wallpaper** with a friendly GUI.

---

## 📂 Features

- **Browse and select an image** using a File Dialog.
- Validates that the selected file is a **supported image format** (`.jpg`, `.jpeg`, `.png`, `.bmp`, `.gif`).
- Displays a **preview of the current wallpaper** and the **new wallpaper**.
- Provides a **confirmation dialog** before changing the wallpaper.
- Changes the wallpaper only if the user confirms.
- Automatically closes the second form after **4 seconds** using a background thread.

---

## ⚡ How to Use

1. Clone this repository:
```bash
git clone https://github.com/SilentDev-Na/API-Samples.git
Open the project in Visual Studio.

Build and run the project.

Workflow:

The first form contains a TextBox and a Browse button.

Click Browse to select an image.

If the image is valid, its path will be displayed in the TextBox.

The second form opens automatically with:

PictureBox for current wallpaper

PictureBox for new wallpaper

Set Wallpaper button

Click Set Wallpaper. A confirmation MessageBox appears:

Yes → Wallpaper changes.

No → Operation is canceled.

The second form closes automatically after 4 seconds.

🛠️ How It Works
Uses Platform Invocation (P/Invoke) with SystemParametersInfo from user32.dll to update the desktop wallpaper.

Uses File Dialog for selecting images.

Validates image extensions before allowing the wallpaper change.

Implements a thread to auto-close the second form after 4 seconds.

📌 Notes
Tested on Windows 10 / 11.

Only local images are supported by default.

This project is for learning and demonstration purposes.

🔔 Future Improvements
Add drag-and-drop support for selecting images.

Allow multiple wallpapers / slideshow.

Save favorite wallpapers for easy switching.

Add error handling for invalid paths or inaccessible images.
