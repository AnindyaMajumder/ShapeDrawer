using System;
using SplashKitSDK;

namespace DrawingShape
{
    public abstract class Shape
    {
        private Color _color;
        private float _x, _y;
        private bool _selected;

        public Shape()
        {
            _color = Color.Purple;
        }
        public Shape(Color color)
        {
            _color = color;
        }

        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }
        public abstract void Draw();
        public abstract void DrawOutline();
        public abstract bool IsAt(Point2D p);

    }
}