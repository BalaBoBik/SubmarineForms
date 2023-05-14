using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubmarineForms
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            double T, L;
            double V = Double.Parse(volumeTextBox.Text);
            double S = Double.Parse(squareTextBox.Text);
            double H = -(Double.Parse(DeepTextBox.Text));
            double p1 = Double.Parse(densityTextBox.Text);
            double v= Double.Parse(speedTextBox.Text);
            RungeKutta rk = new RungeKutta(V,S,H,p1,v);
            List<Point> points = rk.RungeKuttaCalculations();

            pointsLabel.Text = "";
            for(int i=0;i<20;i++)
                pointsLabel.Text += $"{points[i].t}; \t {points[i].y}; \t {points[i].z}\n";

            QuadraticEquation zy = TrendLine.MakeQuadraticTrendLineZY(points);
            resultLabel1.Text = $"{zy.a}t^2 + {zy.b}t + {zy.c}";

            QuadraticEquation zt = TrendLine.MakeQuadraticTrendLineZT(points);
            resultLabel2.Text = $"{zt.a}t^2 + {zt.b}t + {zt.c}";

            zy.a = zy.a * rk.v * rk.v;
            zy.b = zy.b * rk.v;
            zy.FindX();
            zt.FindX();
            T = zy.x1;
            L = zt.x1;
            for (double x = 0; x <= T; x += 0.1)
                chart.Series[0].Points.AddXY(x,zy.a * x * x + zy.b * x + zy.c);
            ascentPointLabel.Text=$"Точка всплытия: ({Math.Round(T)}; 0)";
            timeLabelZT.Text = $"По апроксимации z(t): {Math.Round(L)} секунд";
            timeLabelSpeed.Text=$"По скорости: {Math.Round(Math.Abs(rk.H / rk.v))} секунд";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
