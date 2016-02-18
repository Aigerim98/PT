using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake.cs
{
    public class drawer
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
        public void Save()
        {
            string fileName = "";
            if (sign == '*')
                fileName = "food.xml";
            if (sign == '#')
                fileName = "wall.xml";
            if (sign == '0')
                fileName = "snake.xml";

            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(GetType());

            xs.Serialize(fs, this);
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

            if (sign == '*')
                game.foods = xs.Deserialize(fs) as food;
            if (sign == '0')
                game.snake = xs.Deserialize(fs) as snake;
            if (sign == '#')
                game.wall = xs.Deserialize(fs) as wall;

            fs.Close();
        }
    }
}
