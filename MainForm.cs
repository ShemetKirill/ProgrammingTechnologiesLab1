using System;
using System.Windows.Forms;

namespace Lab1
{
    class MainForm : Form
    {
        Label labelV3 = new Label();
        Label labelV4 = new Label();
        Label labelX = new Label();
        Label labelY = new Label();
        Label labelZ = new Label();
        TextBox textX = new TextBox();
        TextBox textY = new TextBox();
        TextBox textZ = new TextBox();
        Button button = new Button();
        TextBox textResult = new TextBox();
        Label labelX2 = new Label();
        Label labelY2 = new Label();
        Label labelZ2 = new Label();
        TextBox textX2 = new TextBox();
        TextBox textY2 = new TextBox();
        TextBox textZ2 = new TextBox();
        Button button2 = new Button();
        TextBox textResult2 = new TextBox();
        public MainForm()
        {
            InitComponent();
            textX.Text = "4000,0";
            textY.Text = "0,875";
            textZ.Text = "0,000475";

            textX2.Text = "0,0374";
            textY2.Text = "-0,825";
            textZ2.Text = "16";
        }
        private void InitComponent()
        {
            Width = 700;
            Height = 350;
            Text = "ПЕРВАЯ ЛАБОРАТОРНАЯ ЛЯХ И ШЕМЕТ ";
            labelV3.Top = 10;
            labelV3.Left = 20;
            labelV3.Width = 100;
            labelV3.Text = " вариант 4";
            labelV4.Top = 10;
            labelV4.Left = 250;
            labelV4.Width = 100;
            labelV4.Text = " вариант 3";
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
            Controls.AddRange(new[] { labelX, labelY, labelZ, labelV3, labelV4 });
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


            labelX2.Top = 30;
            labelX2.Left = 250;
            labelX2.Width = 25;
            labelX2.Text = "X=";
            labelY2.Top = 60;
            labelY2.Left = 250;
            labelY2.Width = 25;
            labelY2.Text = "Y=";
            labelZ2.Top = 90;
            labelZ2.Left = 250;
            labelZ2.Width = 25;
            labelZ2.Text = "Z=";
            Controls.AddRange(new[] { labelX2, labelY2, labelZ2 });
            textX2.Top = 30;
            textX2.Left = 275;
            textY2.Top = 60;
            textY2.Left = 275;
            textZ2.Top = 90;
            textZ2.Left = 275;
            Controls.AddRange(new[] { textX2, textY2, textZ2 });
            button2.Top = 120;
            button2.Left = 275;
            button2.Text = "Calculate";
            button2.Click += new EventHandler(button_Click2);
            Controls.Add(button2);
            
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
        void button_Click2(object sender, EventArgs e1)
        {
            double x1 = double.Parse(textX2.Text);
            double y1 = double.Parse(textY2.Text);
            double z1 = double.Parse(textZ2.Text);
            double a1 = (1 + Math.Pow(Math.Sin(x1 + y1), 2));
            double k1 = (1 + (Math.Pow(x1, 2) * Math.Pow(y1, 2)));
            double b1 = (x1 - (2 * y1 / k1));
            double c1 = Math.Pow(x1, Math.Abs(y1));
            double d1 = Math.Atan(1 / z1);
            double t1 = Math.Pow(Math.Cos(d1), 2);

            double v = ((a1 / b1) * c1) + t1;
            textResult.Text = string.Format("v={0:0.0000e000}", v);
        }
    }
}
