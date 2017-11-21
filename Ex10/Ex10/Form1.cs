using System;
using System.Windows.Forms;

namespace Ex10 {
    public partial class Form1 : Form {
        int x0 = 0, x1 = 0, y0 = 0, y1 = 0;

        private void Form1_MouseMove(object sender, MouseEventArgs e) {
            int x = e.Location.X;
            int y = e.Location.Y;

            label1.Text = "(" + x + ", " + y + ")";

            if (x >= x0 && x <= x1 && y >= y0 && y <= y1)
                MessageBox.Show("Запретная зона!");
        }

        public Form1() {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e) {
            string[] point = textBox1.Text.Split(' ');

            x0 = int.Parse(point[0]);
            y0 = int.Parse(point[1]);
            x1 = int.Parse(point[2]);
            y1 = int.Parse(point[3]);
        }
    }
}
