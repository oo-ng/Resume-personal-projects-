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
    internal class Brick : IDrawable, ICollidable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public GameColor Color { get; set; }

        public System.Drawing.Rectangle Bounds => new System.Drawing.Rectangle(X, Y, Width, Height);

        private Random _random = new Random();

        public Brick(int x, int y, int width, int height, GameColor color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Color = color;
        }
        // let the brick objects generate their own locations instead of the game class doing all the work
        //I tweaked your function a bit  to take the borders into account, with yours obstacles where being places on the border
        //public void GenerateNewLocation(int maxX, int maxY)
        //{
        //    X = _random.Next(Width, maxX - Width);
        //    Y = _random.Next(Height, maxY - Height);
        //}
        public void GenerateNewLocation(int maxX, int maxY)
        {
            X = _random.Next(Snake_game.LEFT_EDGE + Width, maxX - Width);
            Y = _random.Next(Snake_game.TOP_EDGE + Height, maxY - Height);
        }

        public void GenerateNewLocation(int maxX, int maxY, int avoidX, int avoidY, int radius)
        {
            do
            {
                GenerateNewLocation(maxX, maxY);
            } while (Math.Sqrt(Math.Pow(X - avoidX, 2) + Math.Pow(Y - avoidY, 2)) < radius);
        }

        public void Draw(CanvasDrawingSession drawingSession)
        {
            drawingSession.FillRectangle(X, Y, Width, Height, Color);
        }

        public bool CollidesWith(ICollidable other)
        {
            return Bounds.IntersectsWith(other.Bounds);
        }
    }

}
