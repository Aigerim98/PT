using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake.cs
{
    public class Snake:Drawer
    {
        public Snake()
        {
            color = ConsoleColor.Green;
            sign = '0';
            body.Add(new Point(10,10));
        }
        public void move(int dx, int dy)
        {
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;
            if (body[0].x == Game.foods.body[0].x && body[0].y == Game.foods.body[0].y)
            {
                   body.Add(new Point(0, 0));
                   Game.foods.new_food();
            }
        }
        public bool SnakeinSnake()
        {
            for(int i=1;i<body.Count;i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                    return false;
            }
            return true;
        }
        public void newPosition()
        {
            Game.snake.body.Clear();
            if (Collision() == false)
            {
                Game.snake.body.Add(new Point(new Random().Next() % 15, new Random().Next() % 15));
            }
        }
        public bool Collision()
        {
            for (int i = 0; i < Game.wall.body.Count; i++)
            {
                if (body[0].x == Game.wall.body[i].x && body[0].y == Game.wall.body[i].y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
