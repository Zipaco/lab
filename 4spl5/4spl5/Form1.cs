using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _4spl5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeChart();
        }

        public abstract class Equation
        {
           
            public abstract double GetValue(double x);
        }

        public class QuadraticEquation : Equation
        {
            private double a, b, c;

            public QuadraticEquation(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public override double GetValue(double x)
            {
                return a * x * x + b * x + c;
            }
        }

        public class SinusoidalEquation : Equation
        {
            private double a, b;

            public SinusoidalEquation(double a, double b)
            {
                this.a = a;
                this.b = b;
            }

            public override double GetValue(double x)
            {
                return (x != 0) ? Math.Sin(a * x) / x : 0; 
            }
        }

        public void DrawFunction(double x1, double x2, Series series, Equation equation)
        {
            series.Points.Clear();
            int pointsCount = 100; 
            double step = (x2 - x1) / pointsCount;

            for (double x = x1; x <= x2; x += step)
            {
                double y = equation.GetValue(x);
                series.Points.AddXY(x, y);
            }
        }

        public abstract class Integrator
        {
            protected Equation equation;

            public Integrator(Equation equation)
            {
                this.equation = equation ?? throw new ArgumentNullException(nameof(equation));
            }

            public abstract double Integrate(double x1, double x2);

            public abstract string MethodName { get; }
        }

        public class RectangleIntegrator : Integrator
        {
            public RectangleIntegrator(Equation equation) : base(equation) { }

            public override double Integrate(double x1, double x2)
            {
                if (x1 >= x2) throw new ArgumentException("Правая граница интегрирования должна быть больше левой!");

                int N = 100; 
                double h = (x2 - x1) / N;
                double sum = 0;

                for (int i = 0; i < N; i++)
                {
                    sum += equation.GetValue(x1 + i * h) * h;
                }

                return sum;
            }

            public override string MethodName => "Метод прямоугольников";
        }

        public class TrapezoidIntegrator : Integrator
        {
            public TrapezoidIntegrator(Equation equation) : base(equation) { }

            public override double Integrate(double x1, double x2)
            {
                if (x1 >= x2) throw new ArgumentException("Правая граница интегрирования должна быть больше левой!");

                int N = 100; 
                double h = (x2 - x1) / N;
                double sum = (equation.GetValue(x1) + equation.GetValue(x2)) / 2;

                for (int i = 1; i < N; i++)
                {
                    sum += equation.GetValue(x1 + i * h);
                }

                return sum * h;
            }

            public override string MethodName => "Метод трапеций";
        }

       
            private Equation equation;

            private void InitializeChart()
            {
                chart.ChartAreas.Add(new ChartArea("Осн.Площадь"));
                chart.Series.Add(new Series("Функция")
                {
                    ChartType = SeriesChartType.Line,
                    Color = System.Drawing.Color.Blue,
                    BorderWidth = 2
                });
            }

            private void btnDraw_Click(object sender, EventArgs e)
            {
                double a = double.Parse(Coeff_Equation1.Text);
                double b = double.Parse(Coeff_Equation2.Text);
                double c = double.Parse(Coeff_Equation3.Text);

                equation = new QuadraticEquation(a, b, c);
                DrawFunction(-10, 10);
            }

            private void btnIntegrate_Click(object sender, EventArgs e)
            {
                double x1 = double.Parse(Integration_Board1.Text);
                double x2 = double.Parse(Integration_Board2.Text);

                var integrator = new TrapezoidIntegrator(equation);
                double result = integrator.Integrate(x1, x2);

                MessageBox.Show($"Результат интегрирования: {result}\nМетод: {integrator.MethodName}");
            }

            private void DrawFunction(double x1, double x2)
            {
                chart.Series["Function"].Points.Clear();
                int pointsCount = 100; 
                double step = (x2 - x1) / pointsCount;

                for (double x = x1; x <= x2; x += step)
                {
                    double y = equation.GetValue(x);
                    chart.Series["Function"].Points.AddXY(x, y);
                }
            }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDraw_Click_1(object sender, EventArgs e)
        {
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
        }

        private void btnIntegrate_Click_1(object sender, EventArgs e)
        {
            this.btnIntegrate.Click += new System.EventHandler(this.btnIntegrate_Click);
        }
    }
}
