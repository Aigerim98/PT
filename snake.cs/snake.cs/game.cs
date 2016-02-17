using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake.cs
{
    class game
    {
        public static food foods = new food();
        public static snake snake = new snake();
        public static wall wall = new wall();
        public static bool GameOver = false;
        public int k = 1;
        public void draw()
        {
            Console.Clear();
            snake.Draw();
            foods.Draw();
            wall.Draw();
        }
        public game()
        {
            init();
            play();
        }
        public void play()
        {
            while (GameOver==false)
            {
                Console.Clear();
                draw();
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.UpArrow)
                {
                    if (game.snake.body[0].y > 0)
                        snake.move(0, -1);
                    else
                        game.snake.body[0].y = Console.WindowHeight - 2;
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    if (game.snake.body[0].y < Console.WindowHeight - 2)
                        snake.move(0, 1);
                    else
                        game.snake.body[0].y = 0;
                } 
                if (button.Key == ConsoleKey.LeftArrow)
                {
                    if (game.snake.body[0].x > 0)
                        snake.move(-1, 0);
                    else
                        game.snake.body[0].x = Console.WindowWidth - 2;
                }
                if (button.Key == ConsoleKey.RightArrow)
                {
                    if (game.snake.body[0].x < Console.WindowWidth - 2)
                        snake.move(1, 0);
                    else
                        game.snake.body[0].x = 0;
                }
                if (snake.body.Count % 10 == 0)
                {
                    wall.body.Clear();
                    snake.newPosition();
                    ++k;
                    wall.Level(k);               
                }
                if (foods.CollissionWithWall())
                {
                    foods.new_food();
                }
                if(GameOver = snake.Collision())
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Game Over!");
                    info();
                    Console.ReadKey();
                }
                if (GameOver == snake.SnakeinSnake())
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Game Over!");
                    info();
                    Console.ReadKey();
                }
            }
        }
        public void init()
        {
            foods.new_food();
            wall.Level(k);
        }
        public void info()
        {
            int sum = 0;
            for(int i = 0; i < game.snake.body.Count; i++)
            {
                sum += 1;
            }
            Console.SetCursorPosition(11,11);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(sum);
        }

        /*public void Save()
        {
            snake.Save();
            foods.Save();
            wall.Save();
        }
        public void Resume()
        { 
            snake.Resume();
            foods.Resume();
            wall.Resume();
        }*/
    }
}
