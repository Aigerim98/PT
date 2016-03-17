using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace snake.cs
{
    class Program
    {
        public enum Direction { up, down, left, right };
        public static Direction direction;
        public static int k = 1;
        public static int speed = 200;
        public static bool GameOver = false;

        static void Main(string[] args)
        {
            Game.init();
            Game.wall.Level(k);

            //Thread t = new Thread(MoveSnake);
            //t.Start();

            Timer t1 = new Timer(MoveSnake2);
            t1.Change(0,speed);
            while (GameOver == false)
            {
                //Game.draw();
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.UpArrow)
                {
                    direction = Direction.up;
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    direction = Direction.down;
                }
                if (button.Key == ConsoleKey.LeftArrow)
                {
                    direction = Direction.left;
                }
                if (button.Key == ConsoleKey.RightArrow)
                {
                    direction = Direction.right;
                }
                if (Game.snake.body.Count % 5 == 0)//изменение уровней
                {
                    Game.wall.body.Clear();
                    Game.snake.newPosition();
                    ++k;
                    Game.wall.Level(k);
                }
                if (Game.foods.CollissionWithWall())
                {
                    Game.foods.new_food();
                }
                if (Game.foods.foodInSnake())
                {
                    Game.foods.new_food();
                }
                if (button.Key == ConsoleKey.Enter)
                {
                    Game.Save();
                }
                if (button.Key == ConsoleKey.Escape)
                {
                    Game.Resume();
                }
                if (GameOver = Game.snake.Collision())//условие для выхода из игры
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Game Over!" + " " + "level {0}", k);
                    Game.info();
                    Console.ReadKey();
                }
                if (GameOver == Game.snake.SnakeinSnake())//условие для выхода из игры
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Game Over!" + " " + "level {0}", k);
                    Game.info();
                    Console.ReadKey();
                }
            }
       }
        public static void MoveSnake()
        {
            if (Game.snake.body.Count % 5 == 0)
            {
                speed -= 50;
            }
            while (GameOver == false)
            {
                if (direction == Direction.up)
                {
                    if (Game.snake.body[0].y > 0)
                        Game.snake.move(0, -1);
                    else
                        Game.snake.body[0].y = Console.WindowHeight - 2;
                }
                else if (direction == Direction.down)
                {
                    if (Game.snake.body[0].y < Console.WindowHeight - 2)
                        Game.snake.move(0, 1);
                    else
                        Game.snake.body[0].y = 0;            
                }
                else if (direction == Direction.left)
                {
                    if (Game.snake.body[0].x > 0)
                        Game.snake.move(-1, 0);
                    else
                        Game.snake.body[0].x = Console.WindowWidth - 2;
                }
                else if (direction == Direction.right)
                {
                    if (Game.snake.body[0].x < Console.WindowWidth - 2)
                        Game.snake.move(1, 0);
                    else
                        Game.snake.body[0].x = 0;
                }
                Game.draw();
                Thread.Sleep(speed);
            }
        }

        public static void MoveSnake2(object state)
        {

            if (Game.snake.body.Count % 5 == 0)
            {
                speed -= 50;
            }
            if (direction == Direction.up)
            {
                if (Game.snake.body[0].y > 0)
                    Game.snake.move(0, -1);
                else
                    Game.snake.body[0].y = Console.WindowHeight - 2;
            }
            else if (direction == Direction.down)
            {
                if (Game.snake.body[0].y < Console.WindowHeight - 2)
                    Game.snake.move(0, 1);
                else
                    Game.snake.body[0].y = 0;
            }
            else if (direction == Direction.left)
            {
                if (Game.snake.body[0].x > 0)
                    Game.snake.move(-1, 0);
                else
                    Game.snake.body[0].x = Console.WindowWidth - 2;
            }
            else if (direction == Direction.right)
            {
                if (Game.snake.body[0].x < Console.WindowWidth - 2)
                    Game.snake.move(1, 0);
                else
                    Game.snake.body[0].x = 0;
            }
            Game.draw();
        }
    }
}
