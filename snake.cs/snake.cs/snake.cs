using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake.cs
{

    [Serializable]
    public class Snake:Drawer//наследование от drawer
    {
        public Snake()
        {
            color = ConsoleColor.Green;
            sign = '0';
            body.Add(new Point(10,10));//появление головы змейки
        }
        public void move(int dx, int dy)
        {
            //Console.SetCursorPosition(body[body.Count-1].x,body[body.Count-1].y);
            //Console.Write(" ");
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;//при передвижении предыдущие части тела переходят в другую
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;//голова получает направление по координатам 
            body[0].y += dy;
            if (body[0].x == Game.foods.body[0].x && body[0].y == Game.foods.body[0].y)//проверка на съедение еды
            {
                   body.Add(new Point(0, 0));
                   Game.foods.new_food();
            }
        }
        public bool SnakeinSnake()//проверка ест ли змейка саму себя
        {
            for(int i=1;i<body.Count;i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                    return false;
            }
            return true;
        }
        public void newPosition()//новая безопасная позиция змейки при изменеия уровня
        {
            Game.snake.body.Clear();
            if (Collision() == false)
            {
                Game.snake.body.Add(new Point(new Random().Next() % 15, new Random().Next() % 15));
            }
        }
        public bool Collision()//столкновение со стеной
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
