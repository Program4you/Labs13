namespace Lab1 {
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
            this.x = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(12, 12);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(48, 20);
            this.x.TabIndex = 0;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(66, 12);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(48, 20);
            this.y.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(120, 12);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Стрелять";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(107, 144);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 13);
            this.label.TabIndex = 3;
            this.label.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Name = "Form1";
            this.Text = "Snaiper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button1;
    }
}

