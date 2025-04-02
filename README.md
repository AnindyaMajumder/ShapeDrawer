# Shape Drawer

## Overview
The **Shape Drawer** project is a graphical application that allows users to draw, manipulate, and interact with various shapes on a canvas. This project is built using C# and leverages the **SplashKitSDK** library for graphical rendering and event handling. The application supports drawing rectangles, circles, and lines, with features such as shape selection, color changes, and background customization.

## **How to Use**  

### **1. Drawing Shapes**  
- Left-click on the canvas to draw a shape at the cursor’s position.  
- Press `R` for rectangles, `C` for circles, and `L` for lines.  

### **2. Selecting and Editing Shapes**  
- Right-click on a shape to select it.  
- Press `Escape` to change the shape's colour.  
- Press `Backspace` or `Delete` to remove the selected shape.  

### **3. Customising the Background**  
- Press the `Space` key to apply a random background colour.  


## **Features**  

### **1. Shape Drawing**  
- Supports drawing rectangles, circles, and lines.  
- Shapes are placed on the canvas based on user input.  

### **2. Shape Selection**  
- Users can select individual shapes for modification.  
- Selected shapes are visually highlighted.  

### **3. Shape Manipulation**  
- Shapes can change colour.  
- Selected shapes can be deleted from the canvas.  

### **4. Background Customisation**  
- The canvas background can be modified.  

### **5. Keyboard Shortcuts**  
- Various shortcuts enable quick interaction and modifications.  

### **6. Dynamic Rendering**  
- The canvas updates dynamically to reflect changes.  

## Technical Details

### 1. **Object-Oriented Programming (OOP) Concepts**
This project is a great example of proper use of OOP principles:
   - **Encapsulation**:
     - Each shape class (`MyRectangle`, `MyCircle`, `MyLine`) encapsulates its own properties (e.g., dimensions, position, color) and behavior (e.g., drawing, hit detection).
   - **Inheritance**:
     - All shape classes inherit from the abstract base class `Shape`, which defines common properties and methods.
   - **Polymorphism**:
     - The `Shape` class defines abstract methods (`Draw`, `DrawOutline`, `IsAt`) that are overridden by the derived classes to provide shape-specific implementations.
   - **Abstraction**:
     - The `Shape` class abstracts the common functionality of all shapes, allowing the program to treat all shapes uniformly while delegating specific behavior to the derived classes.

### 2. **Project Structure**
   - **Abstract Base Class (`Shape`)**:
     - Defines common properties (`X`, `Y`, `Color`, `Selected`) and methods (`Draw`, `DrawOutline`, `IsAt`) for all shapes.
   - **Derived Classes**:
     - `MyRectangle`: Implements rectangle-specific drawing and hit detection.
     - `MyCircle`: Implements circle-specific drawing and hit detection.
     - `MyLine`: Implements line-specific drawing and hit detection.
   - **Program Entry Point**:
     - The `Program` class contains the `Main` method, which handles user input, event processing, and rendering.

### 3. **Tools and Libraries**
   - **C#**: The programming language used for the project.
   - **SplashKitSDK**:
     - A lightweight graphics library for rendering shapes, handling user input, and managing the application window.
     - Provides methods like `FillRectangle`, `FillCircle`, `DrawLine`, and `PointInRectangle` for graphical operations.
   - **.NET 6.0**: The runtime environment for executing the application.
 The integrated development environment (IDE) used for designing, coding, and debugging this project.

### 4. **Event Handling**
   - **Mouse Events**:
     - Left-click: Draws a new shape at the mouse position.
     - Right-click: Selects a shape at the mouse position.
   - **Keyboard Events**:
     - Key presses are used to switch shape types, change colors, delete shapes, and modify the background.

### 5. **Rendering Pipeline**
   - The `Drawing` class manages a collection of shapes and handles their rendering.
   - The `Draw` method iterates through all shapes and calls their respective `Draw` methods.
   - The `SelectedShapeAt` method identifies and selects a shape based on the mouse position.

## Demo
Below is a demonstration of the **Shape Drawer** in action:

![Demo Picture](Demo%20Pic.png)

## License
This project is licensed under the [Apache License](LICENSE).