namespace DH
{
    partial class Start
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.g_Public = new System.Windows.Forms.TextBox();
            this.p_Public = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEncrypt.Location = new System.Drawing.Point(12, 149);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(150, 75);
            this.buttonEncrypt.TabIndex = 1;
            this.buttonEncrypt.Text = "Создать ключ";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(10, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "g =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(10, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "p =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(10, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Известные числа";
            // 
            // g_Public
            // 
            this.g_Public.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.g_Public.Location = new System.Drawing.Point(47, 106);
            this.g_Public.Name = "g_Public";
            this.g_Public.Size = new System.Drawing.Size(62, 26);
            this.g_Public.TabIndex = 11;
            this.g_Public.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // p_Public
            // 
            this.p_Public.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.p_Public.Location = new System.Drawing.Point(47, 65);
            this.p_Public.Name = "p_Public";
            this.p_Public.Size = new System.Drawing.Size(62, 26);
            this.p_Public.TabIndex = 12;
            this.p_Public.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(12, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Закрыть программу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.p_Public);
            this.Controls.Add(this.g_Public);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEncrypt);
            this.Name = "Start";
            this.Text = "Данные";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox g_Public;
        public System.Windows.Forms.TextBox p_Public;
        private System.Windows.Forms.Button button1;
    }
}

