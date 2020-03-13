using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_Paint
{
    public partial class Form_Clock_Paint : Form
    {
        double angel = 0,dangel = 1, r=0;
        int x=0, y=0, xc=0, yc=0;
        Pen pen;
        Color colorPen = Color.Black; 

        public Form_Clock_Paint()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            pen.Color = colorPen;
            //Аффинные преобразования
            gr.TranslateTransform(xc, yc);
            gr.RotateTransform((float)angel);
            gr.DrawLine(pen, 0, 0, x, y);
            gr.ResetTransform();
        }

        private void Form_Clock_Paint_Load(object sender, EventArgs e)
        {
            //this.pictureBox1_Paint;//Объект (изображение или типо того)
            x = xc + (int)(r * Math.Sin(angel));
            y = yc + (int)(r * Math.Sin(angel));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angel += dangel;
        }
    }
}
