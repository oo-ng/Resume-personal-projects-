using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using GameColor = Windows.UI.Color;
using GameColors = Windows.UI.Colors;

namespace Snake_FinalProject
{
    public class Wall : IDrawable, ICollidable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public GameColor Color { get; set; }

        public System.Drawing.Rectangle Bounds => new System.Drawing.Rectangle(X, Y, Width, Height);

        public Wall(int x, int y, int width, int height, Color color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Color = color;
        }

        public void Draw(CanvasDrawingSession canvas)
        {
            canvas.FillRectangle(X, Y, Width, Height, Color);
        }

        public bool CollidesWith(ICollidable other) {
            return Bounds.IntersectsWith(other.Bounds);
        }
    }
}
