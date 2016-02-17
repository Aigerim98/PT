using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake.cs
{
    class snake:drawer
    {
        public snake()
        {
            color = ConsoleColor.Green;
            sign = '0';
            body.Add(new point(10,10));
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
            if (body[0].x == game.foods.body[0].x && body[0].y == game.foods.body[0].y)
            {
                   body.Add(new point(0, 0));
                   game.foods.new_food();
            }
        }
        public bool SnakeinSnake()
        {
            foreach(point p in body)
            {
                if (body[0].x == p.x && body[0].y == p.y)
                    return true;
            }
            return false;
        }
        public void newPosition()
        {
            game.snake.body.Clear();
            if (Collision() == false)
            {
                game.snake.body.Add(new point(new Random().Next() % 15, new Random().Next() % 15));
            }
        }
        public bool Collision()
        {
            for (int i = 0; i < game.wall.body.Count; i++)
            {
                if (body[0].x == game.wall.body[i].x && body[0].y == game.wall.body[i].y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
