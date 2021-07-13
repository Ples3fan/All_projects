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

namespace THERMOMETER
{
     public partial class Form1 : Form
    {
       Buff buff;
        GraphicsPath myPath;
        public Form1()
        {
            InitializeComponent();
            //
            buff = new Buff();
            Form2 form2 = new Form2(buff);
            form2.Show();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            myPath = new GraphicsPath();
            Graphics grfx = e.Graphics;
            Pen pen = new Pen(Color.DarkBlue, 5);
            LinearGradientBrush brush = new LinearGradientBrush(new Point(125, 0), new Point(175, 500), Color.Yellow, Color.Red);
            
            myPath.StartFigure();
          //  myPath.AddBezier(134, 417, 112, 479, 214,468, 170, 406);
            myPath.AddBezier(buff.X1,buff.Y1,buff.X2,buff.Y2,buff.X3,buff.Y3,buff.X4,buff.Y4);
            //graphicsPath.AddArc(125, 400, 60, 60, 180, -180);
            myPath.AddLine(167, 400, 167, 50);
            myPath.AddLine(143, 50, 143, 400);
            grfx.FillPath(brush, myPath);
            
            myPath.CloseFigure();

            
              e.Graphics.DrawPath(pen, myPath);

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X={e.X}; Y={e.Y}";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();

        }
    }

    public class Buff
    {
        public Buff(){
          //  myPath.AddBezier(134, 417, 112, 479, 214, 468, 170, 406);
            X1 = 134;
            Y1 = 417;
            X2 = 112;
            Y2 = 479;
            X3 = 214;
            Y3 = 468;
            X4 = 170;
            Y4 = 406;
        }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int X3 { get; set; }
        public int Y3 { get; set; }
        public int X4 { get; set; }
        public int Y4 { get; set; }
    }
}
