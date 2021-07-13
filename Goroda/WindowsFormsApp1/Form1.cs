using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            if (rbEurope.Checked)
            {
                cbCityCange.Items.Add("Париж");
                cbCityCange.Items.Add("Милан");
                cbCityCange.Items.Add("Амстердам");
                cbCityCange.Items.Add("Рига");
                cbCityCange.Items.Add("Берлин");
                cbCityCange.Items.Add("Вильнюс");
            }
        }

        private void rbEurope_CheckedChanged(object sender, EventArgs e)
        {
            cbCityCange.Items.Clear();
            cbCityCange.Text = "";
            cbCityCange.Items.Add("Париж");
            cbCityCange.Items.Add("Милан");
            cbCityCange.Items.Add("Амстердам");
            cbCityCange.Items.Add("Рига");
            cbCityCange.Items.Add("Берлин");
            cbCityCange.Items.Add("Вильнюс");
        }

        private void rbAzia_CheckedChanged(object sender, EventArgs e)
        {
            cbCityCange.Items.Clear();
            cbCityCange.Text = "";
            cbCityCange.Items.Add("Пекин");
            cbCityCange.Items.Add("Бангкок");
            cbCityCange.Items.Add("Тайланд");
            cbCityCange.Items.Add("Сингапур");
            cbCityCange.Items.Add("Херосима");
            cbCityCange.Items.Add("Токио");
        }

        private void rbAfricka_CheckedChanged(object sender, EventArgs e)
        {
            cbCityCange.Items.Clear();
            cbCityCange.Text = "";
            cbCityCange.Items.Add("Марракеш");
            cbCityCange.Items.Add("Тунис");
            cbCityCange.Items.Add("Джуба");
            cbCityCange.Items.Add("Алжир");
            cbCityCange.Items.Add("Каир");
            cbCityCange.Items.Add("Триполи");
        }

        private void rbNorthAmerica_CheckedChanged(object sender, EventArgs e)
        {
            cbCityCange.Items.Clear();
            cbCityCange.Text = "";
            cbCityCange.Items.Add("Торонто");
            cbCityCange.Items.Add("Чикаго");
            cbCityCange.Items.Add("Сиэтл");
            cbCityCange.Items.Add("Сан-Франциско");
            cbCityCange.Items.Add("Детройт");
            cbCityCange.Items.Add("Нью-Йорк");
        }

        private void rbSouthAmerica_CheckedChanged(object sender, EventArgs e)
        {
            cbCityCange.Items.Clear();
            cbCityCange.Text = "";
            cbCityCange.Items.Add("Буэнос-Айрес");
            cbCityCange.Items.Add("Рио-дэ-Жанейро");
            cbCityCange.Items.Add("Монтэвидео");
            cbCityCange.Items.Add("Сан-Паулу");
            cbCityCange.Items.Add("Бразилиа");
            cbCityCange.Items.Add("Сальвадор");
        }

        private void rbAvstraliya_CheckedChanged(object sender, EventArgs e)
        {
            cbCityCange.Items.Clear();
            cbCityCange.Text = "";
            cbCityCange.Items.Add("Мельбурн");
            cbCityCange.Items.Add("Аделаида");
            cbCityCange.Items.Add("Перт");
            cbCityCange.Items.Add("Брисбен");
            cbCityCange.Items.Add("Сидней");
            cbCityCange.Items.Add("Канберра");
        }

        private void cbCityCange_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox.Load("..\\..\\Resources\\" + cbCityCange.Text.ToString() + ".jpg");
        }
    }
}
