using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake.cs
{

    [Serializable]
    public class Food: Drawer
    {
       
        public Food()
        {
            color = ConsoleColor.Red;
            sign = '*';
        }
        public void new_food()
        {
              int x = new Random().Next() % 15;
              int y = new Random().Next() % 15;
              if (body.Count == 0)
                  body.Add(new Point(x, y));
              else
                  body[0].x = x;
                  body[0].y = y;
        }
        public bool foodInSnake()
        {
            for(int i = 0; i < Game.snake.body.Count; i++)
            {
                if(body[0].x==Game.snake.body[i].x && body[0].y == Game.snake.body[i].y)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CollissionWithWall()
        {
            foreach (Point p in Game.wall.body)
            {
                if (body[0].x == p.x && body[0].y == p.y)
                    return true;
            }
            return false;
        }
    }
}
