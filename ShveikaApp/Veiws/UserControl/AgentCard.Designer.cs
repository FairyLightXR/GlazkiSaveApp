namespace ShveikaApp
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
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.TypeAndTitleLbl = new System.Windows.Forms.Label();
            this.DiscountLbl = new System.Windows.Forms.Label();
            this.qtyLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.PriorityLbl = new System.Windows.Forms.Label();
            this.PriorityTextLbl = new System.Windows.Forms.Label();
            this.IDLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PhotoBox
            // 
            this.PhotoBox.Image = global::ShveikaApp.Properties.Resources.picture;
            this.PhotoBox.Location = new System.Drawing.Point(17, 18);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(153, 106);
            this.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoBox.TabIndex = 0;
            this.PhotoBox.TabStop = false;
            // 
            // TypeAndTitleLbl
            // 
            this.TypeAndTitleLbl.AutoSize = true;
            this.TypeAndTitleLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeAndTitleLbl.Location = new System.Drawing.Point(207, 18);
            this.TypeAndTitleLbl.Name = "TypeAndTitleLbl";
            this.TypeAndTitleLbl.Size = new System.Drawing.Size(222, 18);
            this.TypeAndTitleLbl.TabIndex = 1;
            this.TypeAndTitleLbl.Text = "Тип | Наименование агента";
            // 
            // DiscountLbl
            // 
            this.DiscountLbl.AutoSize = true;
            this.DiscountLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountLbl.Location = new System.Drawing.Point(602, 18);
            this.DiscountLbl.Name = "DiscountLbl";
            this.DiscountLbl.Size = new System.Drawing.Size(37, 18);
            this.DiscountLbl.TabIndex = 2;
            this.DiscountLbl.Text = "10%";
            // 
            // qtyLbl
            // 
            this.qtyLbl.AutoSize = true;
            this.qtyLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qtyLbl.Location = new System.Drawing.Point(207, 45);
            this.qtyLbl.Name = "qtyLbl";
            this.qtyLbl.Size = new System.Drawing.Size(78, 20);
            this.qtyLbl.TabIndex = 3;
            this.qtyLbl.Text = "Продажи";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLbl.Location = new System.Drawing.Point(207, 70);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(77, 20);
            this.PhoneLbl.TabIndex = 4;
            this.PhoneLbl.Text = "Телефон";
            // 
            // PriorityLbl
            // 
            this.PriorityLbl.AutoSize = true;
            this.PriorityLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityLbl.Location = new System.Drawing.Point(312, 104);
            this.PriorityLbl.Name = "PriorityLbl";
            this.PriorityLbl.Size = new System.Drawing.Size(131, 20);
            this.PriorityLbl.TabIndex = 5;
            this.PriorityLbl.Text = "Приоритетность";
            // 
            // PriorityTextLbl
            // 
            this.PriorityTextLbl.AutoSize = true;
            this.PriorityTextLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityTextLbl.Location = new System.Drawing.Point(176, 104);
            this.PriorityTextLbl.Name = "PriorityTextLbl";
            this.PriorityTextLbl.Size = new System.Drawing.Size(131, 20);
            this.PriorityTextLbl.TabIndex = 5;
            this.PriorityTextLbl.Text = "Приоритетность";
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Location = new System.Drawing.Point(605, 110);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(16, 13);
            this.IDLbl.TabIndex = 6;
            this.IDLbl.Text = "Id";
            this.IDLbl.Visible = false;
            // 
            // AgentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.IDLbl);
            this.Controls.Add(this.PriorityTextLbl);
            this.Controls.Add(this.PriorityLbl);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.qtyLbl);
            this.Controls.Add(this.DiscountLbl);
            this.Controls.Add(this.TypeAndTitleLbl);
            this.Controls.Add(this.PhotoBox);
            this.Name = "AgentCard";
            this.Size = new System.Drawing.Size(685, 148);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PhotoBox;
        private System.Windows.Forms.Label TypeAndTitleLbl;
        private System.Windows.Forms.Label DiscountLbl;
        private System.Windows.Forms.Label qtyLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label PriorityLbl;
        private System.Windows.Forms.Label PriorityTextLbl;
        public System.Windows.Forms.Label IDLbl;
    }
}
