using System;
using System.Windows.Forms;

namespace Lab8 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
                dataGridView1.Rows.Add();
        }

        private void button1_Click(object sender, EventArgs e) {
            int count = 0;

            for (int i = 0; i < 10; i++)
                count += int.Parse(dataGridView1[4, i].Value.ToString());

            MessageBox.Show(count.ToString());
        }
    }
}
