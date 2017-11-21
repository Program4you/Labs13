namespace Lab4 {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.month = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(33, 6);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(52, 20);
            this.month.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "n";
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(33, 32);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(52, 20);
            this.day.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(115, 32);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(75, 20);
            this.res.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.res);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.day);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.month);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox res;
    }
}

