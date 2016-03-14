using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake.cs
{

    [Serializable]
    public class Game
    {
        public static Food foods = new Food();//создание объектов класса
        public static Snake snake = new Snake();
        public static Wall wall = new Wall();
        public static bool GameOver = false;
        //public static int k = 1;//счетчик для изменения уровней
        public enum Direction {up,down,left,right};
        public static Direction direction;

        public static void draw()
        {
            Console.Clear();
            snake.Draw();
            foods.Draw();
            wall.Draw();
        }
        public Game()
        {
            init();
            //play();
        }
        
        /*public void play()
        {
            while (GameOver==false)
            {
                //Console.Clear();
                draw();
                drawingWall();
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.UpArrow)
                {
                    //direction = Direction.up;
                    if (Game.snake.body[0].y > 0)
                        snake.move(0, -1);
                    else
                        Game.snake.body[0].y = Console.WindowHeight - 2;
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    //direction = Direction.down;
                    if (Game.snake.body[0].y < Console.WindowHeight - 2)
                        snake.move(0, 1);
                    else
                        Game.snake.body[0].y = 0;
                } 
                if (button.Key == ConsoleKey.LeftArrow)
                {
                    //direction = Direction.left;
                    if (Game.snake.body[0].x > 0)
                        snake.move(-1, 0);
                    else
                        Game.snake.body[0].x = Console.WindowWidth - 2;
                }
                if (button.Key == ConsoleKey.RightArrow)
                {
                    //direction = Direction.right;
                    if (Game.snake.body[0].x < Console.WindowWidth - 2)
                        snake.move(1, 0);
                    else
                        Game.snake.body[0].x = 0;
                }
                if (snake.body.Count % 5 == 0)//изменение уровней
                {
                    //Console.Clear();
                    wall.body.Clear();

                    snake.newPosition();
                    ++k;
                    wall.Level(k);
                }
                if (foods.CollissionWithWall())
                {
                    foods.new_food();
                }
                if (foods.foodInSnake())
                {
                    foods.new_food();
                }
                if(button.Key == ConsoleKey.Enter)
                {
                    Save();
                }
                if (button.Key == ConsoleKey.Escape)
                {
                    Resume();
                }
                if(GameOver = snake.Collision())//условие для выхода из игры
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Game Over!"+ " "+"level {0}",k);
                    info();
                    Console.ReadKey();
                }
                if (GameOver == snake.SnakeinSnake())//условие для выхода из игры
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Game Over!" + " " + "level {0}",k);
                    info();
                    Console.ReadKey();
                }
            }
        }*/
        
        public static void init()
        {
            foods.new_food();
            //wall.Level(k);
        }
        public static void info()//выводит на консоль количество очков в конце игры
        {
            int sum = 0;
            for(int i = 0; i < Game.snake.body.Count; i++)
            {
                sum += 1;
            }
            Console.SetCursorPosition(11,11);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(sum);
        }

        public static void Save()
        {
            snake.Save();
            foods.Save();
            wall.Save();
        }
        public static void Resume()
        { 
            snake.Resume();
            foods.Resume();
            wall.Resume();
        }
    }
}
