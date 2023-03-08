using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyGraphics t = new MyGraphics();
            t.InitGraphics(pictureBox1);

            Engine.Load(@"C:\Users\Vivi\Documents\Algoritmi Fundamentali\Maze\Maps\demo.txt");
            Engine.DoMath(t);
            Engine.Draw(t);
            t.RefreshGraphics();
        }
    }
}
