using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab9 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            double w = double.Parse(textBox1.Text.Replace(".", ","));
            double h = 0.01;

            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;
            chart1.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 2.0 / w;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 9;

            for (double x = 0; x <= 2.0 / w; x += h)
                chart1.Series[0].Points.AddXY(x, Math.Exp(x * w));
        }
    }
}
