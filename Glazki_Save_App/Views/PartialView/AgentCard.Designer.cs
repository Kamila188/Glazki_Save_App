namespace Glazki_Save_App.Views.PartialView
{
    partial class AgentCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameTypeAgentLbl = new System.Windows.Forms.Label();
            this.SaleYearLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.PriorityLbl = new System.Windows.Forms.Label();
            this.PercentLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Glazki_Save_App.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NameTypeAgentLbl
            // 
            this.NameTypeAgentLbl.AutoSize = true;
            this.NameTypeAgentLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTypeAgentLbl.Location = new System.Drawing.Point(148, 29);
            this.NameTypeAgentLbl.Name = "NameTypeAgentLbl";
            this.NameTypeAgentLbl.Size = new System.Drawing.Size(311, 24);
            this.NameTypeAgentLbl.TabIndex = 1;
            this.NameTypeAgentLbl.Text = "Тип | Наименование агента";
            // 
            // SaleYearLbl
            // 
            this.SaleYearLbl.AutoSize = true;
            this.SaleYearLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaleYearLbl.Location = new System.Drawing.Point(148, 57);
            this.SaleYearLbl.Name = "SaleYearLbl";
            this.SaleYearLbl.Size = new System.Drawing.Size(145, 21);
            this.SaleYearLbl.TabIndex = 2;
            this.SaleYearLbl.Text = "10 продаж за год";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLbl.Location = new System.Drawing.Point(148, 81);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(134, 21);
            this.PhoneLbl.TabIndex = 3;
            this.PhoneLbl.Text = "+7 111 111 11 11";
            // 
            // PriorityLbl
            // 
            this.PriorityLbl.AutoSize = true;
            this.PriorityLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityLbl.Location = new System.Drawing.Point(148, 103);
            this.PriorityLbl.Name = "PriorityLbl";
            this.PriorityLbl.Size = new System.Drawing.Size(165, 21);
            this.PriorityLbl.TabIndex = 4;
            this.PriorityLbl.Text = "Приоритетность: 10";
            // 
            // PercentLbl
            // 
            this.PercentLbl.AutoSize = true;
            this.PercentLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PercentLbl.Location = new System.Drawing.Point(574, 29);
            this.PercentLbl.Name = "PercentLbl";
            this.PercentLbl.Size = new System.Drawing.Size(50, 24);
            this.PercentLbl.TabIndex = 5;
            this.PercentLbl.Text = "10%";
            // 
            // AgentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PercentLbl);
            this.Controls.Add(this.PriorityLbl);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.SaleYearLbl);
            this.Controls.Add(this.NameTypeAgentLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AgentCard";
            this.Size = new System.Drawing.Size(643, 150);
            this.Load += new System.EventHandler(this.AgentCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameTypeAgentLbl;
        private System.Windows.Forms.Label SaleYearLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label PriorityLbl;
        private System.Windows.Forms.Label PercentLbl;
    }
}
