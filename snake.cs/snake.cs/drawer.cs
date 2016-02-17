using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake.cs
{
    class drawer
    {
        public ConsoleColor color;
        public char sign;
        public List<point> body = new List<point>();
        public drawer() { }
        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
        /*public void Save()
        {
            FileStream fs;
            if (sign == '0')
                fs = new FileStream("snake.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            else if (sign == '*')
                fs = new FileStream("food.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            else if(sign == '#')
                fs = new FileStream("wall.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
            XmlSerializer xs = new XmlSerializer(GetType());
            xs.Serialize(fs,this);
            fs.Close();
        }
        public void Resume()
        {
            string filename = "";
            if (sign == '0')
                filename = "snake.xml";
            if (sign == '*')
                filename = "food.xml";
            if (sign == '#')
                filename = "wall.xml";
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(GetType());

            if (sign == '0')
                game.foods = xs.Deserialize(fs) as food;
            if (sign == '*')
                game.snake = xs.Deserialize(fs) as snake;
            if (sign == '#')
                game.wall = xs.Deserialize(fs) as wall;

            fs.Close();
        }*/
    }
}
