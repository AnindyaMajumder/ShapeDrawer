using System;
using System.Collections.Generic;
using System.Linq;
using SplashKitSDK;

namespace DrawingShape
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }

        public Drawing() : this(Color.White)
        {

        }

        public List<Shape> SelectedShapes()
        {
            return _shapes.Where(s => s.Selected).ToList();
        }

        public int ShapeCount => _shapes.Count;

        public Color Background
        {
            get { return _background; }
            set { _background = value; }
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            _shapes.ForEach(s => s.Draw());
        }

        public void ChangingShapeColor()
        {
            _shapes.Where(s => s.Selected).ToList().ForEach(s => s.Color = Color.RandomRGB(255));
        }

        public void SelectedShapeAt(Point2D pt)
        {
            _shapes.ForEach(s => s.Selected = s.IsAt(pt));
        }

        public void AddShape(Shape s) => _shapes.Add(s);

        public void RemoveShape()
        {
            _shapes.RemoveAll(s => s.Selected);
        }
    }
}