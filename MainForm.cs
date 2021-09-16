using System;
using System.Windows.Forms;

namespace Lab1
{
    class MainForm : Form
    {
        Label labelX = new Label();
        Label labelY = new Label();
        Label labelZ = new Label();
        TextBox textX = new TextBox();
        TextBox textY = new TextBox();
        TextBox textZ = new TextBox();
        Button button = new Button();
        TextBox textResult = new TextBox();
        public MainForm()
        {
            InitComponent();
            textX.Text = "4000,0";
            textY.Text = "0,875";
            textZ.Text = "0,000475";
        }
        private void InitComponent()
        {
            Width = 400;
            Height = 350;
            Text = " ПЕРВАЯ ЛАБОРАТОРНАЯ";
            labelX.Top = 30;
            labelX.Left = 20;
            labelX.Width = 25;
            labelX.Text = "X=";
            labelY.Top = 60;
            labelY.Left = 20;
            labelY.Width = 25;
            labelY.Text = "Y=";
            labelZ.Top = 90;
            labelZ.Left = 20;
            labelZ.Width = 25;
            labelZ.Text = "Z=";
            Controls.AddRange(new[] { labelX, labelY, labelZ });
            textX.Top = 30;
            textX.Left = 50;
            textY.Top = 60;
            textY.Left = 50;
            textZ.Top = 90;
            textZ.Left = 50;
            Controls.AddRange(new[] { textX, textY, textZ });
            button.Top = 120;
            button.Left = 20;
            button.Text = "Calculate";
            button.Click += new EventHandler(button_Click);
            Controls.Add(button);
            textResult.Top = 160;
            textResult.Left = 20;
            textResult.ReadOnly = true;
            textResult.Multiline = true;
            textResult.Width = 200;
            textResult.Height = 100;
            Controls.Add(textResult);
        }

        void button_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textX.Text);
            double y = double.Parse(textY.Text);
            double z = double.Parse(textZ.Text);
            double a = Math.Abs(Math.Cos(x) - Math.Sin(y));
            double k = (1 + 2 * Math.Pow(Math.Sin(y), 2));
            double b = Math.Pow(a, k);
            double c = (1 + z + (Math.Pow(z, 2) / 2) + (Math.Pow(z, 3) / 3) + (Math.Pow(z, 4) / 4));
            double w = b * c;
            textResult.Text = string.Format("w={0:0.0000e000}", w);
        }
    }
}
