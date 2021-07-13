using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAnClock
{
  
    public partial class Form1 : Form
    {
       // Graphics gr;

        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr= e.Graphics;
            //нарисовать циферблат
            gr.FillEllipse(new SolidBrush(Color.Black), 0, 0,300, 300);
            gr.DrawEllipse(new Pen(Color.DarkOrange, 2), 0, 0,300, 300);
            gr.DrawString("XII", new Font("Arial", 24.0f), new SolidBrush(Color.DarkOrange), 122, 20);
            gr.DrawString("III", new Font("Arial", 24.0f), new SolidBrush(Color.DarkOrange), 244, 130);
            gr.DrawString("VI", new Font("Arial", 24.0f), new SolidBrush(Color.DarkOrange), 132, 244);
            gr.DrawString("IX", new Font("Arial", 24.0f), new SolidBrush(Color.DarkOrange), 20, 134);

            gr.TranslateTransform(150, 150);
            gr.RotateTransform(-180);
            for (int i = 0; i < 60; i++)
            {
        
                if (i % 5 == 0)
                {
                    gr.FillRectangle(new SolidBrush(Color.DarkOrange), 0, 130, 6, 20);
                   
                }
                else
                    gr.FillRectangle(new SolidBrush(Color.DarkOrange), 0, 140, 3, 5);
                gr.RotateTransform(6);
                
            }
            gr.FillEllipse(new SolidBrush(Color.DarkOrange), -8,-8,16, 16);

            AnalogClock aClock = new AnalogClock(gr);

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }

    class ClockHands
    {
        public Color Color { get; set; }//цвет стрелки

        private SolidBrush brash;
        public Point[] view { get; set; }//внешний вид стрелки (по точкам)
        public Point Axis { get; set; }//координата оси вращения
        public int Posicion { get; set; }//положение стрелки 0..59

        private Graphics graphics;

      
        public ClockHands(Graphics gr, Point Axis, Point[] view, Color color, int pos)
        {
            graphics = gr;
            gr.ResetTransform();
            gr.TranslateTransform(150, 150);
            gr.RotateTransform(pos * 6-90);
            brash = new SolidBrush(color);
            gr.FillPolygon(brash, view);

        }

        public ClockHands(Graphics gr, Point Axis, int width, int height, Color color, int pos)
        {
            graphics = gr;
            gr.ResetTransform();
            gr.TranslateTransform(150, 150);
            gr.RotateTransform(pos * 6-180);
            brash = new SolidBrush(color);
            gr.FillRectangle(brash, 0, 10, width, height);//упрощенный вариант стрелки

        }


    }

    class AnalogClock
    {
        ClockHands hh;
        ClockHands mm;
        ClockHands ss;
        DateTime now = DateTime.Now;

        private Graphics graphics;
        public AnalogClock(Graphics gr)
        {
            graphics = gr;

            Point[] hhView={
                new Point(10,0),
                new Point(100,8),
                new Point(110,0),
                new Point(100,-8)
            };
            hh = new ClockHands(graphics, new Point(150, 150), hhView, Color.LightGray, (now.Hour % 12)*5 + (int)now.Minute / 12);
            Point[] mmView ={
                new Point(10,0),
                new Point(120,8),
                new Point(130,0),
                new Point(120,-8)
            };
            mm = new ClockHands(graphics, new Point(150, 150), mmView, Color.LightGray, now.Minute);
            ss = new ClockHands(graphics, new Point(150, 150), 2, 140, Color.White, now.Second);

        }

        //void DrawTime()
        //{
        //    //int pos = now.Hour % 12 + now.Minute % 10;
        //    hh.Draw(now.Hour % 12 + now.Minute % 12);
        //    mm.Draw(now.Minute);
        //    ss.Draw(now.Second);

        //}
    }
}
