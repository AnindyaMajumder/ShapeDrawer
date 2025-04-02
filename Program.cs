using System;
using SplashKitSDK;
using DrawingShape;

namespace DrawingShape
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line
        }

        public static void Main()
        {
            Drawing drawShape = new Drawing();
            ShapeKind kindToAdd = ShapeKind.Rectangle;

            new Window("Drawing Shape", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                }
                if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                }
                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                }

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape shapeDrawn = kindToAdd switch
                    {
                        ShapeKind.Rectangle => new MyRectangle(),
                        ShapeKind.Circle => new MyCircle(),
                        ShapeKind.Line => new MyLine(),
                        _ => null
                    };

                    if (shapeDrawn != null)
                    {
                        shapeDrawn.X = SplashKit.MouseX();
                        shapeDrawn.Y = SplashKit.MouseY();
                        drawShape.AddShape(shapeDrawn);
                    }
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    drawShape.SelectedShapeAt(SplashKit.MousePosition());
                }

                if (SplashKit.KeyDown(KeyCode.EscapeKey))
                {
                    drawShape.ChangingShapeColor();
                }

                if (SplashKit.KeyTyped(KeyCode.BackspaceKey) || SplashKit.KeyTyped(KeyCode.DeleteKey))
                {
                    drawShape.RemoveShape();
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    drawShape.Background = SplashKit.RandomRGBColor(255);
                }

                drawShape.Draw();
                SplashKit.RefreshScreen();
            }
            while (!SplashKit.WindowCloseRequested("Drawing Shape"));
        }
    }
}