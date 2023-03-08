using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Maze
{
    public static class Engine
    {
        public static int[,] gMatrix;
        public static float deltaW, deltaH;

        public static void Load(string fileName)
        {
            TextReader load = new StreamReader(fileName);
            List<string> data = new List<string>();
            string buffer;

            while ((buffer = load.ReadLine()) != null) 
                data.Add(buffer);

            load.Close();

            gMatrix = new int[data.Count, data[0].Split(' ').Length];
            for (int i = 0; i < data.Count; i++)
            {
                string[] local = data[i].Split(' ');

                for (int j = 0; j < local.Length; j++)
                    gMatrix[i,j] = int.Parse(local[j]);
            }
        }

        public static void Draw(MyGraphics handler)
        {
            for (int i = 0; i < gMatrix.GetLength(0); i++)
                for (int j = 0; j < gMatrix.GetLength(1); j++)
                    switch (gMatrix[i,j]) 
                    {
                        case 1:
                            handler.grp.FillRectangle(Brushes.Gray, j * deltaW, i * deltaH, deltaW, deltaH);
                            handler.grp.DrawRectangle(Pens.Black, j * deltaW, i * deltaH, deltaW, deltaH);
                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                        case 4:

                            break;
                        case 5:

                            break;
                        case 6:

                            break;
                        case 7:

                            break;
                        default:
                            break;
                    }
        }

        public static void DoMath(MyGraphics handler) 
        {
            deltaW = (float)handler.resX / gMatrix.GetLength(1);
            deltaH = (float)handler.resY / gMatrix.GetLength(0);
        }
    }
}
