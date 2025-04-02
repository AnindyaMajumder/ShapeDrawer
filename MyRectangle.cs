﻿using System;
using SplashKitSDK;

namespace DrawingShape
{
    public class MyRectangle : Shape
    {
        private int _width, _height;

        public MyRectangle(Color clr, float x, float y, int width, int height) : base(clr)
        {
            X = x;
            Y = y;
            _width = width;
            _height = height;
        }

        public MyRectangle() : this(Color.Green, 0, 0, 100, 100) { }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
        {
            get { return _height; } 
            set { _height = value; }
        }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(Color, X, Y, _width, _height);
        }

        public override void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, X - 2, Y - 2, _width + 4, _height + 4);
        }

        public override bool IsAt(Point2D p)
        {
            return SplashKit.PointInRectangle(p, SplashKit.RectangleFrom(X, Y, _width, _height));
        }
    }
}