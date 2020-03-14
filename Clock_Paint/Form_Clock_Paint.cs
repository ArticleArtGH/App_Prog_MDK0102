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
        int x = 0, y = 0, xc = 0, yc = 0, depth = 0;
        double angel = 0, angelChange = 1, r=0;
        Pen pen;
        Color colorPen;
        Graphics gr;
        Bitmap buf;

        public Form_Clock_Paint()
        {
            InitializeComponent();
        }

        private void Form_Clock_Paint_Load(object sender, EventArgs e)
        {
            gr = CreateGraphics();
            xc = this.pictureBox_ClockPaint.Width / 2;
            yc = this.pictureBox_ClockPaint.Height / 2;
            gr.TranslateTransform(xc, yc);

            //buf = new Bitmap(this.pictureBox_ClockPaint.Width, this.pictureBox_ClockPaint.Height);
            //gr = Graphics.FromImage(buf);
            string image = @"AnimeBackground003.jpg";
            //this.pictureBox_ClockPaint.Load(image);
            ////this.pictureBox_ClockPaint.SizeMode = PictureBoxSizeMode.StretchImage;//Подгоняет размер
            ////this.pictureBox_ClockPaint.SizeMode = PictureBoxSizeMode.CenterImage;
            //this.pictureBox_ClockPaint.SizeMode = PictureBoxSizeMode.Zoom;

            //Bitmap img = new Bitmap(image);
            //gr.DrawImage(img, 390, 10);
            //gr = Graphics.FromImage(img);
            //this.pictureBox_ClockPaint.Image = img;

            Bitmap img = new Bitmap(image);
            Rectangle rect = new Rectangle(250, 0, img.Width - 500, img.Height);
            //Rectangle rect = new Rectangle(250, 100, img.Width-500, img.Height-100);
            Bitmap imgChange = img.Clone(rect, System.Drawing.Imaging.PixelFormat.DontCare);
            Color imgBackColor = Color.FromArgb(0, 14, 35, 86);//img.GetPixel(1, 10);
            imgChange.MakeTransparent(imgBackColor);//Для прозрачности определённого цвета пикселя, однако незаметно
            gr.DrawImage(imgChange, 150, 10);
            this.pictureBox_ClockPaint.Image = imgChange;
            this.pictureBox_ClockPaint.SizeMode = PictureBoxSizeMode.StretchImage;

            //Bitmap img = new Bitmap(image);
            //Bitmap imgSize = new Bitmap(img, new Size(600, 500));
            ////gr.TranslateTransform(1000, 1000);
            //gr = Graphics.FromImage(imgSize);
            ////gr = CreateGraphics();
            //this.pictureBox_ClockPaint.Image = imgSize;
            //gr.TranslateTransform(1000, 1000);

            //this.pictureBox_ClockPaint.SizeMode = PictureBoxSizeMode.StretchImage;
            //this.pictureBox_ClockPaint.SizeMode = PictureBoxSizeMode.Zoom;
            //this.pictureBox_ClockPaint.Opacity(50);

            //Хотел сделать окружность для часов
            //Bitmap ellipse = new Bitmap(this.pictureBox_ClockPaint.Width, this.pictureBox_ClockPaint.Height);
            //r = 200;
            //colorPen = Color.Black; depth = 10;
            //pen = new Pen(colorPen, depth);
            //gr = Graphics.FromImage(ellipse);
            //imgBackColor = ellipse.GetPixel(1, 1);//Color.White;//img.GetPixel(1, 10);
            ////ellipse.MakeTransparent(imgBackColor);//Для прозрачности
            //gr.DrawEllipse(pen, (float)xc, (float)yc, (float)r, (float)r);
            //this.pictureBox_ClockPaint.Image = ellipse;
            //Хотел сделать окружность для часов
            //gr.TranslateTransform(0, 0);
            r = 660;
            colorPen = Color.White; depth = 1;
            pen = new Pen(colorPen, depth);
            gr = Graphics.FromImage(imgChange);
            gr.DrawEllipse(pen, (float)20, (float)7, (float)r, (float)r);
            //this.pictureBox_ClockPaint.Image = ellipse;

            //Как сделать так чтобы то что я нарисовал не стирал Paint
            //С помощью этого оно нарисовало gr = Graphics.FromImage(imgChange);
            r = 200;
            colorPen = Color.White; depth = 1;
            pen = new Pen(colorPen, depth);
            //gr = CreateGraphics();
            gr = Graphics.FromImage(imgChange);
            for (int i = 0; i<60; i++)
            {
                x = xc/10 + (int)(r * Math.Sin(angel));
                y = yc/10 - (int)(r * Math.Cos(angel));
                gr.DrawLine(pen, xc, yc, x, y);
                angel += angelChange;
            }

            //this.pictureBox_ClockPaint
            //this.pictureBox_ClockPaint.Invalidate();
            ////this.pictureBox1_Paint;//Объект (изображение или типо того)
            //x = xc + (int)(r * Math.Sin(angel));
            //y = yc + (int)(r * Math.Sin(angel));
            this.timer_ClockPaint.Enabled = true;
        }

        private void pictureBox_ClockPaint_Paint(object sender, PaintEventArgs e)
        {
            timer_ClockPaint.Interval = 1000/100;
            angelChange = Math.PI/180/11;
            //gr = CreateGraphics();
            gr = e.Graphics;
            //gr.DrawEllipse(pen, (float)xc, (float)yc, (float)r, (float)r);
            r = 199;
            colorPen = Color.Red; depth = 3;
            pen = new Pen(colorPen, depth);
            x = xc + (int)(r*Math.Sin(angel));
            y = yc - (int)(r * Math.Cos(angel));
            gr.DrawLine(pen, xc, yc, x, y);
            //gr.DrawEllipse(pen, 10, 10, 100, 100);
            ////Аффинные преобразования
            //gr.TranslateTransform(xc, yc);
            //gr.RotateTransform((float)angel);
            //gr.DrawLine(pen, 0, 0, x, y);
            //gr.ResetTransform();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angel += angelChange;
            this.pictureBox_ClockPaint.Invalidate();
        }
    }
}
