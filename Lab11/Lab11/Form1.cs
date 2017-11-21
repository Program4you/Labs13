using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        int[] days = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        
        private int Date(int D, int M, int Y) {
            int a, y, m, R;
            a = (14 - M) / 12;
            y = Y - a;
            m = M + 12 * a - 2;
            R = 7000 + (D + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12);
            return R % 7;
        }

        private void button1_Click(object sender, EventArgs e) {
            int year = int.Parse(textBox1.Text);
            dataGridView1.Rows.Clear();

            for (int m = 1; m <= 12; m++) {
                for (int d = 1; d <= days[m - 1]; d++) {
                    int day = Date(d, m, year);

                    if (day == 2)
                        dataGridView1.Rows.Add(d + "." + m + "." + year);
                }
            }
        }
    }
}
