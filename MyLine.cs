using System;
using System.Runtime.ConstrainedExecution;
using DrawingShape;
using SplashKitSDK;

namespace DrawingShape
{
    public class MyLine : Shape
    {
        private float _endX;
        private float _endY;

        public MyLine() : this(Color.Purple, 0, 0, 400, 300) { }
        public MyLine(Color color, float startX, float startY, float endX, float endY) : base(color)
        {
            X = startX;
            Y = startY;
            _endX = endX;
            _endY = endY;
        }

        public float EndX
        {
            get
            {
                return _endX;
            }
            set
            {
                _endX = value;
            }
        }

        public float EndY
        {
            get
            {
                return _endY;
            }
            set
            {
                _endY = value;
            }
        }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }

            SplashKit.DrawLine(Color, X, Y, EndX, EndY);
        }
        public override void DrawOutline()
        {
            
            float minX = Math.Min(X, EndX) - 2; 
            float minY = Math.Min(Y, EndY) - 2; 
            float maxX = Math.Max(X, EndX) + 2; 
            float maxY = Math.Max(Y, EndY) + 2; 

            SplashKit.DrawRectangle(SplashKit.ColorBlack(), minX, minY, maxX - minX, maxY - minY);
        }
        public override bool IsAt(Point2D pt)
        {
            bool flag = false;
            if (flag = SplashKit.PointOnLine(pt, SplashKit.LineFrom(X, Y, EndX, EndY)))
            {
                return true;
            }
            return flag;
        }
    }
}