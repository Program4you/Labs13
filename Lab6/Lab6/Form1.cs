using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int count = 0;

            for (int i = 100; i <= 500; i++) {
                if (i % 10 + (i / 10) % 10 + 1 / 100 == 15)
                    count++;

                label1.Text = count.ToString();
            }
        }
    }
}
