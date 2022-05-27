using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;

namespace GraficadorV1_P20
{
    public partial class Form1 : Form
    {
        double xi,x,y, xf;
        string fx;

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        int n;

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WpfRuizSantos.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btGP_Click(object sender, EventArgs e)
        {
            double h;
            double a, r;

            Entrada();
            n = chart1.Width;
            h = (xf - xi) / n;
            chart1.Series["Series1"].Points.Clear();
            listBoxSalida.Items.Clear();
            for (int k = 0; k <= n; k++)
            {
                a = xi + k * h;
                r = fu(a, fx);
                x = r * Math.Cos(a);
                y = r * Math.Sin(a);
                chart1.Series["Series1"].Points.AddXY(x, y);
                listBoxSalida.Items.Add(x + " \t " + y);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGraficar_Click(object sender, EventArgs e)
        {
            double h;
            xi=double.Parse(textBoxxi.Text);
            xf=double.Parse(textBoxxf.Text);
            fx=textBoxfx.Text;
            n = chart1.Width;
            h = (xf - xi) / n;
            chart1.Series["Series1"].Points.Clear();
            for (int k=0; k<n; k++)
            {
                x = xi + k * h;
                y = fu(x, fx);
                chart1.Series["Series1"].Points.AddXY(x,y);
                listBoxSalida.Items.Add(x+" \t "+y);
            }
        }
        public double fu(double x, string fx)
        {
            ExpressionParser parser1=new ExpressionParser();
            parser1.Values.Add("x", x);
            return(parser1.Parse(fx));

        }
        public void Entrada()
        {
            xi = double.Parse(textBoxxi.Text);
            xf = double.Parse(textBoxxf.Text);
            fx = textBoxfx.Text;

        }
    }
}
