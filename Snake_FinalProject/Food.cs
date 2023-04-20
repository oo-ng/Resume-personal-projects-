using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using GameColor = Windows.UI.Color;
using GameColors = Windows.UI.Colors;

namespace Snake_FinalProject
{
    internal class Food : IDrawable, IDestroyable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Width { get; set; } // it's always a square ?
        public GameColor Color { get; set; }

        public Rectangle Bounds => new Rectangle(X, Y, Width, Width);

        private Random _random = new Random();

        public bool CollidesWith(ICollidable other)
        {
            return Bounds.IntersectsWith(other.Bounds);
        }
        public void GenerateNewLocation(int maxX, int maxY)
        {
            X = _random.Next(0 + Width, maxX - Width);
            Y = _random.Next(0 + Width, maxY - Width);
        }
        public void Draw(CanvasDrawingSession drawingSession)
        {
            drawingSession.FillRectangle(X, Y, Width, Width, Color);
        }

    }
}
