using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e) {
            int x0 = int.Parse(x.Text);
            int y0 = int.Parse(y.Text);

            label.Location = new Point(x0, y0);
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
