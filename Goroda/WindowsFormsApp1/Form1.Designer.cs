namespace WindowsFormsApp1
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ContryBox = new System.Windows.Forms.GroupBox();
            this.CityBox = new System.Windows.Forms.GroupBox();
            this.rbEurope = new System.Windows.Forms.RadioButton();
            this.rbAzia = new System.Windows.Forms.RadioButton();
            this.rbAfricka = new System.Windows.Forms.RadioButton();
            this.rbNorthAmerica = new System.Windows.Forms.RadioButton();
            this.rbSouthAmerica = new System.Windows.Forms.RadioButton();
            this.rbAvstraliya = new System.Windows.Forms.RadioButton();
            this.cbCityCange = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ContryBox.SuspendLayout();
            this.CityBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ContryBox
            // 
            this.ContryBox.Controls.Add(this.rbAvstraliya);
            this.ContryBox.Controls.Add(this.rbSouthAmerica);
            this.ContryBox.Controls.Add(this.rbNorthAmerica);
            this.ContryBox.Controls.Add(this.rbAfricka);
            this.ContryBox.Controls.Add(this.rbAzia);
            this.ContryBox.Controls.Add(this.rbEurope);
            this.ContryBox.Location = new System.Drawing.Point(12, 12);
            this.ContryBox.Name = "ContryBox";
            this.ContryBox.Size = new System.Drawing.Size(334, 283);
            this.ContryBox.TabIndex = 0;
            this.ContryBox.TabStop = false;
            this.ContryBox.Text = "Страны";
            // 
            // CityBox
            // 
            this.CityBox.Controls.Add(this.pictureBox);
            this.CityBox.Controls.Add(this.cbCityCange);
            this.CityBox.Location = new System.Drawing.Point(447, 12);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(341, 283);
            this.CityBox.TabIndex = 1;
            this.CityBox.TabStop = false;
            this.CityBox.Text = "Города";
            // 
            // rbEurope
            // 
            this.rbEurope.AutoSize = true;
            this.rbEurope.Checked = true;
            this.rbEurope.Location = new System.Drawing.Point(28, 35);
            this.rbEurope.Name = "rbEurope";
            this.rbEurope.Size = new System.Drawing.Size(62, 17);
            this.rbEurope.TabIndex = 0;
            this.rbEurope.TabStop = true;
            this.rbEurope.Text = "Европа";
            this.rbEurope.UseVisualStyleBackColor = true;
            this.rbEurope.CheckedChanged += new System.EventHandler(this.rbEurope_CheckedChanged);
            // 
            // rbAzia
            // 
            this.rbAzia.AutoSize = true;
            this.rbAzia.Location = new System.Drawing.Point(28, 72);
            this.rbAzia.Name = "rbAzia";
            this.rbAzia.Size = new System.Drawing.Size(50, 17);
            this.rbAzia.TabIndex = 1;
            this.rbAzia.Text = "Азия";
            this.rbAzia.UseVisualStyleBackColor = true;
            this.rbAzia.CheckedChanged += new System.EventHandler(this.rbAzia_CheckedChanged);
            // 
            // rbAfricka
            // 
            this.rbAfricka.AutoSize = true;
            this.rbAfricka.Location = new System.Drawing.Point(28, 111);
            this.rbAfricka.Name = "rbAfricka";
            this.rbAfricka.Size = new System.Drawing.Size(64, 17);
            this.rbAfricka.TabIndex = 2;
            this.rbAfricka.Text = "Африка";
            this.rbAfricka.UseVisualStyleBackColor = true;
            this.rbAfricka.CheckedChanged += new System.EventHandler(this.rbAfricka_CheckedChanged);
            // 
            // rbNorthAmerica
            // 
            this.rbNorthAmerica.AutoSize = true;
            this.rbNorthAmerica.Location = new System.Drawing.Point(28, 150);
            this.rbNorthAmerica.Name = "rbNorthAmerica";
            this.rbNorthAmerica.Size = new System.Drawing.Size(122, 17);
            this.rbNorthAmerica.TabIndex = 3;
            this.rbNorthAmerica.Text = "Северная Америка";
            this.rbNorthAmerica.UseVisualStyleBackColor = true;
            this.rbNorthAmerica.CheckedChanged += new System.EventHandler(this.rbNorthAmerica_CheckedChanged);
            // 
            // rbSouthAmerica
            // 
            this.rbSouthAmerica.AutoSize = true;
            this.rbSouthAmerica.Location = new System.Drawing.Point(28, 187);
            this.rbSouthAmerica.Name = "rbSouthAmerica";
            this.rbSouthAmerica.Size = new System.Drawing.Size(107, 17);
            this.rbSouthAmerica.TabIndex = 4;
            this.rbSouthAmerica.Text = "Южная америка";
            this.rbSouthAmerica.UseVisualStyleBackColor = true;
            this.rbSouthAmerica.CheckedChanged += new System.EventHandler(this.rbSouthAmerica_CheckedChanged);
            // 
            // rbAvstraliya
            // 
            this.rbAvstraliya.AutoSize = true;
            this.rbAvstraliya.Location = new System.Drawing.Point(28, 224);
            this.rbAvstraliya.Name = "rbAvstraliya";
            this.rbAvstraliya.Size = new System.Drawing.Size(79, 17);
            this.rbAvstraliya.TabIndex = 5;
            this.rbAvstraliya.Text = "Австралия";
            this.rbAvstraliya.UseVisualStyleBackColor = true;
            this.rbAvstraliya.CheckedChanged += new System.EventHandler(this.rbAvstraliya_CheckedChanged);
            // 
            // cbCityCange
            // 
            this.cbCityCange.FormattingEnabled = true;
            this.cbCityCange.Location = new System.Drawing.Point(39, 35);
            this.cbCityCange.Name = "cbCityCange";
            this.cbCityCange.Size = new System.Drawing.Size(285, 21);
            this.cbCityCange.TabIndex = 0;
            this.cbCityCange.SelectedIndexChanged += new System.EventHandler(this.cbCityCange_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(6, 72);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(329, 205);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.ContryBox);
            this.Name = "Form";
            this.Text = "Города мира";
            this.ContryBox.ResumeLayout(false);
            this.ContryBox.PerformLayout();
            this.CityBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ContryBox;
        private System.Windows.Forms.RadioButton rbAvstraliya;
        private System.Windows.Forms.RadioButton rbSouthAmerica;
        private System.Windows.Forms.RadioButton rbNorthAmerica;
        private System.Windows.Forms.RadioButton rbAfricka;
        private System.Windows.Forms.RadioButton rbAzia;
        private System.Windows.Forms.RadioButton rbEurope;
        private System.Windows.Forms.GroupBox CityBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cbCityCange;
    }
}

