namespace Lab3 {
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
            this.R1 = new System.Windows.Forms.TextBox();
            this.U2 = new System.Windows.Forms.TextBox();
            this.R2 = new System.Windows.Forms.TextBox();
            this.U1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // R1
            // 
            this.R1.Location = new System.Drawing.Point(28, 12);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(61, 20);
            this.R1.TabIndex = 0;
            // 
            // U2
            // 
            this.U2.Location = new System.Drawing.Point(126, 38);
            this.U2.Name = "U2";
            this.U2.Size = new System.Drawing.Size(61, 20);
            this.U2.TabIndex = 1;
            // 
            // R2
            // 
            this.R2.Location = new System.Drawing.Point(126, 12);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(61, 20);
            this.R2.TabIndex = 2;
            // 
            // U1
            // 
            this.U1.Location = new System.Drawing.Point(28, 38);
            this.U1.Name = "U1";
            this.U1.Size = new System.Drawing.Size(61, 20);
            this.U1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "R1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "R2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "U1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "U2";
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(197, 12);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 46);
            this.calc.TabIndex = 8;
            this.calc.Text = "Рассчитать";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(38, 94);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.result);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.U1);
            this.Controls.Add(this.R2);
            this.Controls.Add(this.U2);
            this.Controls.Add(this.R1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox R1;
        private System.Windows.Forms.TextBox U2;
        private System.Windows.Forms.TextBox R2;
        private System.Windows.Forms.TextBox U1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label result;
    }
}

