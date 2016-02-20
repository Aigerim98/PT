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

    [Serializable]
    public class Drawer
    {
        public ConsoleColor color;
        public char sign;
        public List<Point> body = new List<Point>();
        public Drawer() { }
        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
        public void Save()
        {
            try {
                string fileName = "";
                if (sign == '*')
                    fileName = "food.dat";
                if (sign == '#')
                    fileName = "wall.dat";
                if (sign == '0')
                    fileName = "snake.dat";
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, this);
                fs.Close();
            }
            catch (Exception e)
            {
                Console.Write(e);
                Console.ReadKey();
            }
            /*string fileName = "";
            if (sign == '0')
                fileName = "snake.xml";
            if (sign == '*')
                fileName = "food.xml";
            if (sign == '#')
                fileName = "wall.xml";
           
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(GetType());

            xs.Serialize(fs, this);
            fs.Close();*/

        }
        public void Resume()
        {
            try {
                string fileName = "";
                if (sign == '*')
                    fileName = "food.dat";
                if (sign == '#')

                    fileName = "wall.dat";
                if (sign == '0')
                    fileName = "snake.dat";
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();

                if (sign == '*')
                    Game.foods = bf.Deserialize(fs) as Food;
                if (sign == '#')
                    Game.wall = bf.Deserialize(fs) as Wall;

                if (sign == '0')
                    Game.snake = bf.Deserialize(fs) as Snake;

                fs.Close();
            }
            catch (Exception e)
            {
                Console.Write(e);
                Console.ReadKey();
            }
            /*string filename = "";
            if (sign == '0')
                filename = "snake.xml";
            if (sign == '*')
                filename = "food.xml";
            if (sign == '#')
                filename = "wall.xml";
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(GetType());

            if (sign == '*')
                Game.foods = xs.Deserialize(fs) as Food;
            if (sign == '0')
                Game.snake = xs.Deserialize(fs) as Snake;
            if (sign == '#')
                Game.wall = xs.Deserialize(fs) as Wall;

            fs.Close();*/
        }
    }
}
