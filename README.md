# Shape Drawer

## Overview
The **Shape Drawer** project is a graphical application that allows users to draw, manipulate, and interact with various shapes on a canvas. This project is built using C# and leverages the **SplashKitSDK** library for graphical rendering and event handling. The application supports drawing rectangles, circles, and lines, with features such as shape selection, color changes, and background customization.

## Features

### 1. **Shape Drawing**
   - Users can draw three types of shapes:
     - **Rectangle**: Drawn using the `MyRectangle` class.
     - **Circle**: Drawn using the `MyCircle` class.
     - **Line**: Drawn using the `MyLine` class.
   - Shapes are drawn at the mouse's position when the left mouse button is clicked.

### 2. **Shape Selection**
   - Shapes can be selected by right-clicking on them.
   - Selected shapes are highlighted with an outline for better visibility.

### 3. **Shape Manipulation**
   - **Change Shape Color**: Press the `Escape` key to change the color of the selected shape.
   - **Delete Shape**: Press the `Backspace` or `Delete` key to remove the selected shape.

### 4. **Background Customization**
   - Press the `Space` key to change the canvas background to a random color.

### 5. **Keyboard Shortcuts**
   - `R`: Switch to drawing rectangles.
   - `C`: Switch to drawing circles.
   - `L`: Switch to drawing lines.

### 6. **Dynamic Rendering**
   - The application continuously updates the canvas to reflect user interactions and changes.

## Technical Details

### 1. **Project Structure**
   - **Abstract Base Class (`Shape`)**:
     - Defines common properties (`X`, `Y`, `Color`, `Selected`) and methods (`Draw`, `DrawOutline`, `IsAt`) for all shapes.
   - **Derived Classes**:
     - `MyRectangle`: Implements rectangle-specific drawing and hit detection.
     - `MyCircle`: Implements circle-specific drawing and hit detection.
     - `MyLine`: Implements line-specific drawing and hit detection.
   - **Program Entry Point**:
     - The `Program` class contains the `Main` method, which handles user input, event processing, and rendering.

### 2. **Tools and Libraries**
   - **C#**: The programming language used for the project.
   - **SplashKitSDK**:
     - A lightweight graphics library for rendering shapes, handling user input, and managing the application window.
     - Provides methods like `FillRectangle`, `FillCircle`, `DrawLine`, and `PointInRectangle` for graphical operations.
   - **.NET 6.0**: The runtime environment for executing the application.

### 3. **Event Handling**
   - **Mouse Events**:
     - Left-click: Draws a new shape at the mouse position.
     - Right-click: Selects a shape at the mouse position.
   - **Keyboard Events**:
     - Key presses are used to switch shape types, change colors, delete shapes, and modify the background.

### 4. **Rendering Pipeline**
   - The `Drawing` class manages a collection of shapes and handles their rendering.
   - The `Draw` method iterates through all shapes and calls their respective `Draw` methods.
   - The `SelectedShapeAt` method identifies and selects a shape based on the mouse position.


## License
This project is licensed under the [Apache License](LICENSE).