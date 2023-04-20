using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI;
using GameColor = Windows.UI.Color;
using GameColors = Windows.UI.Colors;

namespace Snake_FinalProject
{
    internal class Snake : IDrawable, ICollidable
    {
        //snake has a reference to the collidable objects
        private List<ICollidable> collidables;

        //the snake is made up of segments each segment has a position color and collision bounds etc.
        internal class Segment : IDrawable, ICollidable
        {
            public int X;
            public int Y;
            public GameColor color { get; set; }
            public System.Drawing.Rectangle Bounds => new System.Drawing.Rectangle(X, Y, 20, 20);
            public void Draw(CanvasDrawingSession canvas)
            {
                canvas.FillRectangle(X, Y, 20, 20, color);
            }
            public bool CollidesWith(ICollidable other)
            {
                return Bounds.IntersectsWith(other.Bounds);
            }
            //constructor
            public Segment(int x, int y, GameColor segColor)
            {
                X = x;
                Y = y;
                this.color = segColor;
            }
            //copy constructor
            public Segment(Segment s)
            {
                this.X = s.X;
                this.Y = s.Y;
                this.color = s.color;
            }
        }
        private List<Segment> Segments = new List<Segment>();
        public Segment head { get; private set; } = null;

        public Snake_game.Direction direction { get; set; }

        public Snake(int xPos, int yPos, List<ICollidable> collidables, GameColor snakeColor)
        {
            head = new Segment(xPos, yPos, snakeColor);
            Segments.Add(head);
            this.collidables = collidables;
            this.color = snakeColor;
        }



        public void Eat()
        {
            Segment lastSegment = Segments[Segments.Count - 1];
            int newX = lastSegment.X;
            int newY = lastSegment.Y;

            switch (direction)
            {
                case Snake_game.Direction.up:
                    newY += 20;
                    break;
                case Snake_game.Direction.down:
                    newY -= 20;
                    break;
                case Snake_game.Direction.left:
                    newX += 20;
                    break;
                case Snake_game.Direction.right:
                    newX -= 20;
                    break;
                case Snake_game.Direction.stop:
                    return;
            }

            Segment newSegment = new Segment(newX, newY, color);
            Segments.Add(newSegment);
        }


        public GameColor color { get; set; }

        public System.Drawing.Rectangle Bounds => throw new NotImplementedException();

        // game look more fun, after any user input we change color


        //update checks for collisions and if it's food we call eat, if it's not then we game over
        public void Update()
        {

            foreach (ICollidable c in collidables)
            {
                if (c != this && CollidesWith(c))
                {
                    if (c is Food)
                    {
                        Eat(); break;
                    }
                    else direction = Snake_game.Direction.stop;
                    return;
                }
            }
            //if no collision we move!
            Move();
        }

        // Move (currently not working, not sure why...)
        private void Move()
        {
            int headX = head.X; //keep track of the inital position before moving
            int headY = head.Y;
            switch (direction)
            {
                case Snake_game.Direction.up:
                    head.Y -= 10;
                    break;
                case Snake_game.Direction.down:
                    head.Y += 10;
                    break;
                case Snake_game.Direction.left:
                    head.X -= 10;
                    break;
                case Snake_game.Direction.right:
                    head.X += 10;
                    break;
                case Snake_game.Direction.stop:
                    return;
            }
            for (int i = Segments.Count - 1; i > 0; i--)
            {
                Segment cur = Segments[i];
                Segment next = Segments[i - 1];
                cur.X = next.X;
                cur.Y = next.Y;
            }

        }

        public void Draw(CanvasDrawingSession canvas)
        {
            foreach (Segment seg in Segments)
            {
                seg.Draw(canvas);
            }
//            canvas.FillRectangle(head.X, head.Y, 20, 20, color);
        }

        public bool CollidesWith(ICollidable other)
        {
            foreach (Segment cur in Segments)
            {
                if (cur.CollidesWith(other))
                    return true;
            }
            return false;
        }
    }





}
