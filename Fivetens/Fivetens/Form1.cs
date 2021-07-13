using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fivetens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            generateField();
        }

        void generateField()
        {
            TableLayoutPanelCellPosition empty;
            Random r = new Random();
            int index;
            for (int i = 0; i < 250; i++)
            {
                index = r.Next(1, 5);
                empty = tableLayoutPanel1.GetCellPosition(panel1);
                switch (index)
                {
                    case 1: if (empty.Column - 1 >= 0)
                        {
                            Control pic = tableLayoutPanel1.GetControlFromPosition(empty.Column - 1, empty.Row);
                            if (pic != null)
                            {
                                TableLayoutPanelCellPosition position = tableLayoutPanel1.GetCellPosition(pic);
                                tableLayoutPanel1.SetCellPosition(pic, empty);
                                tableLayoutPanel1.SetCellPosition(panel1, position);
                            }
                        }break;
                    case 2: if (empty.Row - 1 >= 0)
                        {
                            Control pic = tableLayoutPanel1.GetControlFromPosition(empty.Column, empty.Row-1);
                            if (pic != null)
                            {
                                TableLayoutPanelCellPosition position = tableLayoutPanel1.GetCellPosition(pic);
                                tableLayoutPanel1.SetCellPosition(pic, empty);
                                tableLayoutPanel1.SetCellPosition(panel1, position);
                            }
                        }break;
                    case 3:if(empty.Column+1 >= 0)
                        {
                            Control pic = tableLayoutPanel1.GetControlFromPosition(empty.Column + 1, empty.Row);
                            if (pic != null)
                            {
                                TableLayoutPanelCellPosition position = tableLayoutPanel1.GetCellPosition(pic);
                                tableLayoutPanel1.SetCellPosition(pic, empty);
                                tableLayoutPanel1.SetCellPosition(panel1, position);
                            }
                        }break;
                    case 4:if(empty.Row+1 >= 0)
                        {
                            Control pic = tableLayoutPanel1.GetControlFromPosition(empty.Column, empty.Row+1);
                            if (pic != null)
                            {
                                TableLayoutPanelCellPosition position = tableLayoutPanel1.GetCellPosition(pic);
                                tableLayoutPanel1.SetCellPosition(pic, empty);
                                tableLayoutPanel1.SetCellPosition(panel1, position);
                            }
                        }break;
                                
                    default:
                        break;
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition empty = tableLayoutPanel1.GetCellPosition(panel1);
            TableLayoutPanelCellPosition pic1 = tableLayoutPanel1.GetCellPosition(pictureBox1);
            Control pic = tableLayoutPanel1.GetControlFromPosition(pic1.Column, pic1.Row);
            if ((pic1.Column == empty.Column && (pic1.Row+1 == empty.Row || pic1.Row-1 ==empty.Row))||(pic1.Row == empty.Row && (pic1.Column+1 == empty.Column ||pic1.Column-1 == empty.Column)))
            {
                tableLayoutPanel1.SetCellPosition(pic, empty);
                tableLayoutPanel1.SetCellPosition(panel1, pic1);
            }
            if (pic1.Column == 0 && pic1.Row == 0)
            {
                progressBar.Value += 1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition empty = tableLayoutPanel1.GetCellPosition(panel1);
            TableLayoutPanelCellPosition pic1 = tableLayoutPanel1.GetCellPosition(pictureBox2);
            Control pic = tableLayoutPanel1.GetControlFromPosition(pic1.Column, pic1.Row);
            if ((pic1.Column == empty.Column && (pic1.Row + 1 == empty.Row || pic1.Row - 1 == empty.Row)) || (pic1.Row == empty.Row && (pic1.Column + 1 == empty.Column || pic1.Column - 1 == empty.Column)))
            {
                tableLayoutPanel1.SetCellPosition(pic, empty);
                tableLayoutPanel1.SetCellPosition(panel1, pic1);
            }
            if (pic1.Column == 1 && pic1.Row == 0)
            {
                progressBar.Value += 1;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition empty = tableLayoutPanel1.GetCellPosition(panel1);
            TableLayoutPanelCellPosition pic1 = tableLayoutPanel1.GetCellPosition(pictureBox3);
            Control pic = tableLayoutPanel1.GetControlFromPosition(pic1.Column, pic1.Row);
            if ((pic1.Column == empty.Column && (pic1.Row + 1 == empty.Row || pic1.Row - 1 == empty.Row)) || (pic1.Row == empty.Row && (pic1.Column + 1 == empty.Column || pic1.Column - 1 == empty.Column)))
            {
                tableLayoutPanel1.SetCellPosition(pic, empty);
                tableLayoutPanel1.SetCellPosition(panel1, pic1);
            }
            if (pic1.Column == 2 && pic1.Row == 0)
            {
                progressBar.Value += 1;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition empty = tableLayoutPanel1.GetCellPosition(panel1);
            TableLayoutPanelCellPosition pic1 = tableLayoutPanel1.GetCellPosition(pictureBox4);
            Control pic = tableLayoutPanel1.GetControlFromPosition(pic1.Column, pic1.Row);
            if ((pic1.Column == empty.Column && (pic1.Row + 1 == empty.Row || pic1.Row - 1 == empty.Row)) || (pic1.Row == empty.Row && (pic1.Column + 1 == empty.Column || pic1.Column - 1 == empty.Column)))
            {
                tableLayoutPanel1.SetCellPosition(pic, empty);
                tableLayoutPanel1.SetCellPosition(panel1, pic1);
            }
            if (pic1.Column == 3 && pic1.Row == 0)
            {
                progressBar.Value += 1;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition empty = tableLayoutPanel1.GetCellPosition(panel1);
            TableLayoutPanelCellPosition pic1 = tableLayoutPanel1.GetCellPosition(pictureBox5);
            Control pic = tableLayoutPanel1.GetControlFromPosition(pic1.Column, pic1.Row);
            if ((pic1.Column == empty.Column && (pic1.Row + 1 == empty.Row || pic1.Row - 1 == empty.Row)) || (pic1.Row == empty.Row && (pic1.Column + 1 == empty.Column || pic1.Column - 1 == empty.Column)))
            {
                tableLayoutPanel1.SetCellPosition(pic, empty);
                tableLayoutPanel1.SetCellPosition(panel1, pic1);
            }
            if (pic1.Column == 0 && pic1.Row == 1)
            {
                progressBar.Value += 1;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition empty = tableLayoutPanel1.GetCellPosition(panel1);
            TableLayoutPanelCellPosition pic1 = tableLayoutPanel1.GetCellPosition(pictureBox6);
            Control pic = tableLayoutPanel1.GetControlFromPosition(pic1.Column, pic1.Row);
            if ((pic1.Column == empty.Column && (pic1.Row + 1 == empty.Row || pic1.Row - 1 == empty.Row)) || (pic1.Row == empty.Row && (pic1.Column + 1 == empty.Column || pic1.Column - 1 == empty.Column)))
            {
                tableLayoutPanel1.SetCellPosition(pic, empty);
                tableLayoutPanel1.SetCellPosition(panel1, pic1);
            }
            if (pic1.Column == 1 && pic1.Row == 1)
            {
                progressBar.Value += 1;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition empty = tableLayoutPanel1.GetCellPosition(panel1);
            TableLayoutPanelCellPosition pic1 = tableLayoutPanel1.GetCellPosition(pictureBox7);
            Control pic = tableLayoutPanel1.GetControlFromPosition(pic1.Column, pic1.Row);
            if ((pic1.Column == empty.Column && (pic1.Row + 1 == empty.Row || pic1.Row - 1 == empty.Row)) || (pic1.Row == empty.Row && (pic1.Column + 1 == empty.Column || pic1.Column - 1 == empty.Column)))
            {
                tableLayoutPanel1.SetCellPosition(pic, empty);
                tableLayoutPanel1.SetCellPosition(panel1, pic1);
            }
            if (pic1.Column == 2 && pic1.Row == 1)
            {
                progressBar.Value += 1;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition empty = tableLayoutPanel1.GetCellPosition(panel1);
            TableLayoutPanelCellPosition pic1 = tableLayoutPanel1.GetCellPosition(pictureBox8);
            Control pic = tableLayoutPanel1.GetControlFromPosition(pic1.Column, pic1.Row);
            if ((pic1.Column == empty.Column && (pic1.Row + 1 == empty.Row || pic1.Row - 1 == empty.Row)) || (pic1.Row == empty.Row && (pic1.Column + 1 == empty.Column || pic1.Column - 1 == empty.Column)))
            {
                tableLayoutPanel1.SetCellPosition(pic, empty);
                tableLayoutPanel1.SetCellPosition(panel1, pic1);
            }
            if (pic1.Column == 3 && pic1.Row == 1)
            {
                progressBar.Value += 1;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition empty = tableLayoutPanel1.GetCellPosition(panel1);
            TableLayoutPanelCellPosition pic1 = tableLayoutPanel1.GetCellPosition(pictureBox9);
            Control pic = tableLayoutPanel1.GetControlFromPosition(pic1.Column, pic1.Row);
            if ((pic1.Column == empty.Column && (pic1.Row + 1 == empty.Row || pic1.Row - 1 == empty.Row)) || (pic1.Row == empty.Row && (pic1.Column + 1 == empty.Column || pic1.Column - 1 == empty.Column)))
            {
                tableLayoutPanel1.SetCellPosition(pic, empty);
                tableLayoutPanel1.SetCellPosition(panel1, pic1);
            }
            if (pic1.Column == 0 && pic1.Row == 2)
            {
                progressBar.Value += 1;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition empty = tableLayoutPanel1.GetCellPosition(panel1);
            TableLayoutPanelCellPosition pic1 = tableLayoutPanel1.GetCellPosition(pictureBox10);
            Control pic = tableLayoutPanel1.GetControlFromPosition(pic1.Column, pic1.Row);
            if ((pic1.Column == empty.Column && (pic1.Row + 1 == empty.Row || pic1.Row - 1 == empty.Row)) || (pic1.Row == empty.Row && (pic1.Column + 1 == empty.Column || pic1.Column - 1 == empty.Column)))
            {
                tableLayoutPanel1.SetCellPosition(pic, empty);
                tableLayoutPanel1.SetCellPosition(panel1, pic1);
            }
            if (pic1.Column == 1 && pic1.Row == 2)
            {
                progressBar.Value += 1;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition empty = tableLayoutPanel1.GetCellPosition(panel1);
            TableLayoutPanelCellPosition pic1 = tableLayoutPanel1.GetCellPosition(pictureBox11);
            Control pic = tableLayoutPanel1.GetControlFromPosition(pic1.Column, pic1.Row);
            if ((pic1.Column == empty.Column && (pic1.Row + 1 == empty.Row || pic1.Row - 1 == empty.Row)) || (pic1.Row == empty.Row && (pic1.Column + 1 == empty.Column || pic1.Column - 1 == empty.Column)))
            {
                tableLayoutPanel1.SetCellPosition(pic, empty);
                tableLayoutPanel1.SetCellPosition(panel1, pic1);
            }
            if (pic1.Column == 2 && pic1.Row == 2)
            {
                progressBar.Value += 1;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition empty = tableLayoutPanel1.GetCellPosition(panel1);
            TableLayoutPanelCellPosition pic1 = tableLayoutPanel1.GetCellPosition(pictureBox12);
            Control pic = tableLayoutPanel1.GetControlFromPosition(pic1.Column, pic1.Row);
            if ((pic1.Column == empty.Column && (pic1.Row + 1 == empty.Row || pic1.Row - 1 == empty.Row)) || (pic1.Row == empty.Row && (pic1.Column + 1 == empty.Column || pic1.Column - 1 == empty.Column)))
            {
                tableLayoutPanel1.SetCellPosition(pic, empty);
                tableLayoutPanel1.SetCellPosition(panel1, pic1);
            }
            if (pic1.Column == 3 && pic1.Row == 2)
            {
                progressBar.Value += 1;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition empty = tableLayoutPanel1.GetCellPosition(panel1);
            TableLayoutPanelCellPosition pic1 = tableLayoutPanel1.GetCellPosition(pictureBox13);
            Control pic = tableLayoutPanel1.GetControlFromPosition(pic1.Column, pic1.Row);
            if ((pic1.Column == empty.Column && (pic1.Row + 1 == empty.Row || pic1.Row - 1 == empty.Row)) || (pic1.Row == empty.Row && (pic1.Column + 1 == empty.Column || pic1.Column - 1 == empty.Column)))
            {
                tableLayoutPanel1.SetCellPosition(pic, empty);
                tableLayoutPanel1.SetCellPosition(panel1, pic1);
            }
            if (pic1.Column == 0 && pic1.Row == 3)
            {
                progressBar.Value += 1;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition empty = tableLayoutPanel1.GetCellPosition(panel1);
            TableLayoutPanelCellPosition pic1 = tableLayoutPanel1.GetCellPosition(pictureBox14);
            Control pic = tableLayoutPanel1.GetControlFromPosition(pic1.Column, pic1.Row);
            if ((pic1.Column == empty.Column && (pic1.Row + 1 == empty.Row || pic1.Row - 1 == empty.Row)) || (pic1.Row == empty.Row && (pic1.Column + 1 == empty.Column || pic1.Column - 1 == empty.Column)))
            {
                tableLayoutPanel1.SetCellPosition(pic, empty);
                tableLayoutPanel1.SetCellPosition(panel1, pic1);
            }
            if (pic1.Column == 1 && pic1.Row == 3)
            {
                progressBar.Value += 1;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            TableLayoutPanelCellPosition empty = tableLayoutPanel1.GetCellPosition(panel1);
            TableLayoutPanelCellPosition pic1 = tableLayoutPanel1.GetCellPosition(pictureBox15);
            Control pic = tableLayoutPanel1.GetControlFromPosition(pic1.Column, pic1.Row);
            if ((pic1.Column == empty.Column && (pic1.Row + 1 == empty.Row || pic1.Row - 1 == empty.Row)) || (pic1.Row == empty.Row && (pic1.Column + 1 == empty.Column || pic1.Column - 1 == empty.Column)))
            {
                tableLayoutPanel1.SetCellPosition(pic, empty);
                tableLayoutPanel1.SetCellPosition(panel1, pic1);
            }
            if (pic1.Column == 2 && pic1.Row == 3)
            {
                progressBar.Value += 1;
            }
        }
    }
}
