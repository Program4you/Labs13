using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e) {
            int r1 = int.Parse(R1.Text);
            int u1 = int.Parse(U1.Text);
            int r2 = int.Parse(R2.Text);
            int u2 = int.Parse(U2.Text);

            if (u1 / r1 > u2 / r2)
                result.Text = "Больший ток течёт по первому участку";
            else
                result.Text = "Больший ток течёт по второму участку";
        }
    }
}
