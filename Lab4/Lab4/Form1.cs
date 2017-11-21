using System;
using System.Windows.Forms;

namespace Lab4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int n = int.Parse(day.Text);
            int m = int.Parse(month.Text);

            if (n < 30)
                n++;
            else if (n == 31) {
                n = 1;
                m++;
            }
            else if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12) {
                n++;
                m++;
            }
            else {
                n = 1;
                m++;
            }

            res.Text = n + "." + m;
        }
    }
}
