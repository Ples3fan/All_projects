using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THERMOMETER
{
    public partial class Form2 : Form
    {
        Buff buff;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Buff buff): this() {
            this.buff = buff;
        }

        private void TrackBarX1_ValueChanged(object sender, EventArgs e)
        {
            buff.X1 = trackBarX1.Value;
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            buff.X1 = trackBarX1.Value;
            if ((sender as TrackBar) != null) {
                switch ((sender as TrackBar).Name)
                {
                    case "trackBarX1":
                        lbl_X1.Text = (sender as TrackBar).Value.ToString();
                        buff.X1 = (sender as TrackBar).Value;
                        break;
                    case "trackBarY1":
                        lbl_Y1.Text = (sender as TrackBar).Value.ToString();
                        buff.Y1 = (sender as TrackBar).Value;
                        break;
                    case "trackBarX2":
                        lbl_X2.Text = (sender as TrackBar).Value.ToString();
                        buff.X2 = (sender as TrackBar).Value;
                        break;
                    case "trackBarY2":
                        lbl_Y2.Text = (sender as TrackBar).Value.ToString();
                        buff.Y2 = (sender as TrackBar).Value;
                        break;
                    case "trackBarX3":
                        lbl_X3.Text = (sender as TrackBar).Value.ToString();
                        buff.X3 = (sender as TrackBar).Value;
                        break;
                    case "trackBarY3":
                        lbl_Y3.Text = (sender as TrackBar).Value.ToString();
                        buff.Y3 = (sender as TrackBar).Value;
                        break;
                    case "trackBarX4":
                        lbl_X4.Text = (sender as TrackBar).Value.ToString();
                        buff.X4 = (sender as TrackBar).Value;
                        break;
                    case "trackBarY4":
                        lbl_Y4.Text = (sender as TrackBar).Value.ToString();
                        buff.Y4 = (sender as TrackBar).Value;
                        break;


                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_X1.Text = buff.X1.ToString();
            lbl_Y1.Text = buff.Y1.ToString();
            lbl_X2.Text = buff.X2.ToString();
            lbl_Y2.Text = buff.Y2.ToString();
            lbl_X3.Text = buff.X3.ToString();
            lbl_Y3.Text = buff.Y3.ToString();
            lbl_X4.Text = buff.X4.ToString();
            lbl_Y4.Text = buff.Y4.ToString();
            trackBarX1.Value = buff.X1;
            trackBarY1.Value = buff.Y1;
            trackBarX2.Value = buff.X2;
            trackBarY2.Value = buff.Y2;
            trackBarX3.Value = buff.X3;
            trackBarY3.Value = buff.Y3;
            trackBarX4.Value = buff.X4;
            trackBarY4.Value = buff.Y4;
        }
    }
}
