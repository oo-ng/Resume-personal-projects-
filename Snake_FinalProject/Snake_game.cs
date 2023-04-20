using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
//using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Radios;
using Windows.Foundation;
using Microsoft.Graphics.Canvas.UI.Xaml;
using Windows.UI;
using Windows.Gaming.Input;
using Windows.UI.Xaml.Documents;
using System.Reflection;
using static Snake_FinalProject.Wall;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml.Input;
using System.Windows;
using System.Windows.Input;

using System.Drawing;
using GameColor = Windows.UI.Color;
using GameColors = Windows.UI.Colors;

using System.Threading;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

// some code is from mr eric charnesky
//modified by group 5


namespace Snake_FinalProject
{

    

    public interface IDrawable
    {
        void Draw(CanvasDrawingSession canvas);
    }

    public interface ICollidable
    {
        Rectangle Bounds { get; }                   //no need for edge specific collidables
        bool CollidesWith(ICollidable other);
    }
    


    public interface IDestroyable : ICollidable //Using this we can set the food to Idestroyable
    { }

    public class Snake_game
    {
        public event EventHandler GameOverEvent;
        public enum Direction { stop, left, right, up, down }
        public static int LEFT_EDGE = 30;           //so these edges need to be divisible by our movement size (whatever it ends up being) for collisions to behave.
        public static int TOP_EDGE = 30;
        public static int RIGHT_EDGE = 990;
        public static int BOTTOM_EDGE = 650;
        public static int OBSTACLE_MAX = 700;
        public Random random;
        private Gamepad controller;
        private Snake snake;
        private long obstacleCounter;
        public bool GameOver { get; private set; }

        private Food food;

        private List<Brick> obstacles;



        // private Food food; //needs to be implemented 
        private List<IDrawable> drawables;
        // keep track of all the collidable objects in a list.
        private List<ICollidable> collidables = new List<ICollidable>();

        public Wall leftWall {get; private set;}
        public Wall rightWall { get; private set; }
        public Wall topWall { get; private set; }
        public Wall bottomWall { get; private set; } 


        public Snake_game()
        {
           

             obstacleCounter = 0;
            GameOver = false;
            drawables = new List<IDrawable>();
            snake = new Snake(450, 300, collidables, GameColors.BlueViolet);
            drawables.Add(snake);



            leftWall = new Wall(LEFT_EDGE, TOP_EDGE, 15, BOTTOM_EDGE - 15, GameColors.Red);
            drawables.Add(leftWall);
            collidables.Add(leftWall);

            rightWall = new Wall(RIGHT_EDGE, TOP_EDGE, 15, BOTTOM_EDGE - 15, GameColors.Red);
            drawables.Add(rightWall);
            collidables.Add(rightWall);

            topWall = new Wall(LEFT_EDGE, TOP_EDGE, RIGHT_EDGE - 15, 15, GameColors.Red);
            drawables.Add(topWall);
            collidables.Add(topWall);

            bottomWall = new Wall(LEFT_EDGE, BOTTOM_EDGE, RIGHT_EDGE - 15, 15, GameColors.Red);
            drawables.Add(bottomWall);
            collidables.Add(bottomWall);


            random = new Random();



        }
        public void setDirection(Direction direction)
        {
            snake.direction = direction;
        }
        public Direction GetDirection()
        {
            return snake.direction;
        }
        public GameColor PickRandomColor()
        {
            return GameColor.FromArgb(255, (byte)random.Next(0, 256), (byte)random.Next(0, 256), (byte)random.Next(0, 256));
        }
        public void Update()
        {
            obstacleCounter++;

            // Handle gamepad input
            if (Gamepad.Gamepads.Count != 0)
            {
                controller = Gamepad.Gamepads.First();
                var reading = controller.GetCurrentReading();

                // Move the snake in the X direction
                if (reading.LeftThumbstickX != 0)
                {
                    if (reading.LeftThumbstickX > 0)
                    {
                        snake.direction = Direction.right;
                    }
                    else
                    {
                        snake.direction = Direction.left;
                    }
                }

                // Move the snake in the Y direction
                if (reading.LeftThumbstickY != 0)
                {
                    if (reading.LeftThumbstickY > 0)
                    {
                        snake.direction = Direction.up;
                    }
                    else
                    {
                        snake.direction = Direction.down;
                    }
                }
            }


           

            if (!GameOver && obstacleCounter >= 200)
            {
                obstacleCounter = 0;

                // Create the first brick with a random color
                var brick1 = new Brick(0, 0, 50, 10, PickRandomColor());
                var food = new Food();
                brick1.GenerateNewLocation(RIGHT_EDGE, BOTTOM_EDGE);
                food.GenerateNewLocation(RIGHT_EDGE, BOTTOM_EDGE);
                food.Color=PickRandomColor();
                food.Width=10;

                collidables.Add(food);
                drawables.Add(food);

                collidables.Add(brick1);
                drawables.Add(brick1);
                

                var brick2 = new Brick(0, 0, 50, 10, PickRandomColor());
                brick2.GenerateNewLocation(RIGHT_EDGE, BOTTOM_EDGE, brick1.X, brick1.Y, 80); // i increased the radius 
                collidables.Add(brick2);
                drawables.Add(brick2);
            }


            snake.Update();

            foreach (ICollidable c in collidables)
            {
                if (c != snake && snake.CollidesWith(c))
                {
                    if (c is Food)
                    {
                        snake.Eat();
                    }
                    else
                    {
                        snake.direction = Direction.stop;
                        GameOver = true;
                    }
                    break;
                }
            }

       
            foreach (ICollidable c in collidables)
            {
                if (c != snake && snake.CollidesWith(c))
                {
                    if (c is Food)
                    {
                        snake.Eat();

                        // Remove the eaten food from the collidables and drawables lists
                        collidables.Remove(c);
                        drawables.Remove((IDrawable)c);

                        // Create a new food instance
                        var newFood = new Food();
                        newFood.GenerateNewLocation(RIGHT_EDGE-10, BOTTOM_EDGE-10);
                        newFood.Color = PickRandomColor();
                        newFood.Width = 10;

                        // Add the new food instance to the collidables and drawables lists
                        collidables.Add(newFood);
                        drawables.Add(newFood);
                    }
                    else
                    {
                        snake.direction = Direction.stop;
                        GameOver = true;
                    }
                    break;
                }
            }

            if (GameOver&&obstacleCounter==400)
            {
                GameOverEvent?.Invoke(this, EventArgs.Empty);
            }



        }



        public void DrawGame(CanvasDrawingSession canvas)
        {
            foreach (var drawable in drawables)
            {
                drawable.Draw(canvas);
            }

            canvas.DrawText($"Snake cordinate X: {snake.head.X} \nSnake cordinate Y: {snake.head.Y}", 300, 700, Colors.Blue);

            // about 1/60 of a second per tick
            //canvas.DrawText($"obstacleCounter: {obstacleCounter}", 300, 650, Colors.Blue);
        }



    }
}
