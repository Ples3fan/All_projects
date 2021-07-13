namespace Golovolomka
{
    partial class Form1
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
            this.clbChange = new System.Windows.Forms.CheckedListBox();
            this.lbtext = new System.Windows.Forms.ListBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbChange
            // 
            this.clbChange.CheckOnClick = true;
            this.clbChange.FormattingEnabled = true;
            this.clbChange.Items.AddRange(new object[] {
            "25",
            "27",
            "3",
            "12",
            "6",
            "15",
            "3",
            "30",
            "21",
            "19"});
            this.clbChange.Location = new System.Drawing.Point(27, 35);
            this.clbChange.Name = "clbChange";
            this.clbChange.Size = new System.Drawing.Size(120, 199);
            this.clbChange.TabIndex = 0;
            this.clbChange.Click += new System.EventHandler(this.clbChange_Click);
            this.clbChange.SelectedIndexChanged += new System.EventHandler(this.clbChange_SelectedIndexChanged);
            // 
            // lbtext
            // 
            this.lbtext.FormattingEnabled = true;
            this.lbtext.Location = new System.Drawing.Point(197, 35);
            this.lbtext.Name = "lbtext";
            this.lbtext.Size = new System.Drawing.Size(120, 95);
            this.lbtext.TabIndex = 1;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(197, 162);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(44, 13);
            this.lblSum.TabIndex = 2;
            this.lblSum.Text = "Сумма:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 281);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lbtext);
            this.Controls.Add(this.clbChange);
            this.Name = "Form1";
            this.Text = "Собери 50";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbChange;
        private System.Windows.Forms.ListBox lbtext;
        private System.Windows.Forms.Label lblSum;
    }
}

