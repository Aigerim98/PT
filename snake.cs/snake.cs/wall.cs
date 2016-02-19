using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake.cs
{
    public class Wall:Drawer
    {
        public Wall()
        {
            color = ConsoleColor.Blue;
            sign = '#';
        }
        public void Level(int level)
        {
            string name = string.Format("level{0}.txt", level);
            
            FileStream fs = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            
            string[] token = sr.ReadToEnd().Split('\n');
            for (int i=0;i<token.Length;i++)
            {
                for (int j=0;j<token[i].Length;j++)
                {
                    if (token[i][j] == '#')
                        body.Add(new Point(j,i));
                }
            }
            sr.Close();
            fs.Close();

        }
    }
}
