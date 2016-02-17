using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake.cs
{
    class food: drawer
    {
        public food()
        {
            color = ConsoleColor.Red;
            sign = '*';
        }
        public void new_food()
        {
              int x = new Random().Next() % 15;
              int y = new Random().Next() % 15;
              if (body.Count == 0)
                  body.Add(new point(x, y));
              else
                  body[0].x = x;
                  body[0].y = y;
        }

        public bool CollissionWithWall()
        {
            foreach (point p in game.wall.body)
            {
                if (body[0].x == p.x && body[0].y == p.y)
                    return true;
            }
            return false;

        }
    }
}
