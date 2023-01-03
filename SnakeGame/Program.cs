using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using SFML;
using SFML.Graphics;
using SFML.Audio;
using SFML.System;
using SFML.Window;
using System.Runtime.InteropServices;
using System.Threading;

namespace SnakeGame
{
    

    class Program
    {


        //Globals
        Clock clock;
        RenderWindow window;
        Random rnd;
        uint[] Preferred_Window_Size = { 640, 480 }; //unsigned int
        float timer = 0,delay = 0.05f;
        int score = 0;
        

        //Entity Related

        CircleShape Entity_Food;
        List<CircleShape> Entity_Snake;
        int MovementState = 0;

        private void Init()
        {
            clock = new Clock();
            rnd = new Random();
            window = new RenderWindow(new VideoMode(Preferred_Window_Size[0], Preferred_Window_Size[1]), "Snake Game");
            window.Closed += (sender, e) => { ((Window)sender).Close(); };

            Entity_Food = new CircleShape(5.0f);
            Entity_Food.Position = new Vector2f(rnd.Next(0, 500), rnd.Next(0, 400));
            Entity_Food.FillColor = Color.Red;
            
            Entity_Snake = new List<CircleShape>{ };
            CircleShape Snake_Head = new CircleShape(5.0f);
            Snake_Head.Position = new Vector2f(Preferred_Window_Size[0] / 2, Preferred_Window_Size[1] / 2); // Intializes snake's head to be at window's center
            Snake_Head.FillColor = Color.Green;

            Entity_Snake.Add(Snake_Head);
            window.SetActive();
            Console.WriteLine("Initialized");
        }

        private void InputDetection()
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
                MovementState = 0;
            else if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
                MovementState = 1;
            else if (Keyboard.IsKeyPressed(Keyboard.Key.Left))
                MovementState = 2;
            else if (Keyboard.IsKeyPressed(Keyboard.Key.Right))
                MovementState = 3;

        }


        private void UpdateSnakePos()
        {



            CircleShape snakeShape = new CircleShape(5.0f);
            snakeShape.FillColor = Color.Green;
            switch (MovementState)
                {
                    case 0:
                        snakeShape.Position = new Vector2f(Entity_Snake.First().Position.X, Entity_Snake.First().Position.Y - 10);
                        break;
                    case 1:
                        snakeShape.Position = new Vector2f(Entity_Snake.First().Position.X, Entity_Snake.First().Position.Y + 10);
                        break;
                    case 2:
                        snakeShape.Position = new Vector2f(Entity_Snake.First().Position.X - 10, Entity_Snake.First().Position.Y);
                        break;
                    case 3:
                        snakeShape.Position = new Vector2f(Entity_Snake.First().Position.X + 10, Entity_Snake.First().Position.Y);
                        break;
                    default:
                        snakeShape.Position = new Vector2f(Entity_Snake.First().Position.X, Entity_Snake.First().Position.Y - 10);
                        break;
                }


            Entity_Snake.Insert(0, snakeShape);
            Entity_Snake.RemoveAt(Entity_Snake.Count - 1);
            


        }

        private void FoodHandle()
        {
            if (Vector2.Distance(new Vector2(Entity_Snake[0].Position.X, Entity_Snake[0].Position.Y), new Vector2(Entity_Food.Position.X, Entity_Food.Position.Y)) <= 10)
            {
                Entity_Food.Position = new Vector2f(rnd.Next(0, 500), rnd.Next(0, 400));

                CircleShape newTail = new CircleShape(5.0f);
                newTail.FillColor = Color.Green;

                if (MovementState == 0)
                    newTail.Position = new Vector2f(Entity_Snake.Last().Position.X, Entity_Snake.Last().Position.Y + 10);
                else if (MovementState == 1)
                    newTail.Position = new Vector2f(Entity_Snake.Last().Position.X, Entity_Snake.Last().Position.Y - 10);
                else if (MovementState == 2)
                    newTail.Position = new Vector2f(Entity_Snake.Last().Position.X + 10, Entity_Snake.Last().Position.Y);
                else if (MovementState == 3)
                    newTail.Position = new Vector2f(Entity_Snake.Last().Position.X - 10, Entity_Snake.Last().Position.Y);



                Entity_Snake.Add(newTail);


                score += 100;
                Console.WriteLine("Score:" + score.ToString());
            }
        }

        private void Engine()
        {

            UpdateSnakePos();
            FoodHandle();
            
            //SwitchPosHandle();
            
        }

        private void DrawLoop()
        {
            window.Draw(Entity_Food);

            foreach (CircleShape points in Entity_Snake)
            {
                window.Draw(points);
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            
            program.Init();

            while (program.window.IsOpen)
            {
                float time = program.clock.ElapsedTime.AsSeconds();
                program.clock.Restart();
                program.timer += time;
                
                program.window.DispatchEvents();

                //program.AddSwitchPos();
                program.InputDetection();

                if (program.timer > program.delay) { program.timer = 0; program.Engine(); }
                program.DrawLoop();
                program.window.Display();
                program.window.Clear();
            }
        }
    }
}
