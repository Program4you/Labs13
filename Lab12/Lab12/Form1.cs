using System;
using System.IO;
using System.Windows.Forms;

namespace Lab12 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string[] numbers = File.ReadAllText("numbers.txt").Split(' ');
            string s = "";

            for (int i = 0; i < numbers.Length; i += 2)
                s += numbers[i] + " ";

            MessageBox.Show(s);
        }
    }
}
