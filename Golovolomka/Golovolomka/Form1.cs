using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golovolomka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clbChange_Click(object sender, EventArgs e)
        {


        }
        //foreach (var item in clbChange.CheckedItems)
        //    {
        //        lbtext.Items.Add(item);
        //    }
    private void clbChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            int s;
            lbtext.Items.Clear();
            for (int i = 0; i < clbChange.CheckedItems.Count; i++)
            {
                    lbtext.Items.Add(clbChange.CheckedItems[i]);
            }
            s = 0;
            for (int i = 0; i < lbtext.Items.Count; i++)
            {
                s += Convert.ToInt32(lbtext.Items[i].ToString());

            }
            lblSum.Text = "Сумма: " + s.ToString();
            if (s == 50)
            {
                lblSum.Text = "Сумма: " + s.ToString();
                clbChange.Enabled = false;
                lblSum.Enabled = false;
            }
        }
    }
}
