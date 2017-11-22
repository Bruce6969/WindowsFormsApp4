using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace WindowsFormsApp4
{
    public struct Coeffient
    {
        public double A;
        public double B;
        public double C;
        public double D;
    }

    public partial class KubnaRavenka : Form
    {
        public Coeffient Coeff;

        public KubnaRavenka()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Solve ax^3+bx^2+cx+d=0 for x.
        /// Calculation of the 3 roots of a cubic equation according to
        /// http://en.wikipedia.org/wiki/Cubic_function#General_formula_for_roots
        /// Using the complex struct from System.Numerics
        /// Visual Studio 2010, .NET version 4.0
        /// </summary>
        /// <param name="a">real coefficient of x to the 3th power</param>
        /// <param name="b">real coefficient of x to the 2nd power</param>
        /// <param name="c">real coefficient of x to the 1th power</param>
        /// <param name="d">real coefficient of x to the zeroth power</param>
        /// <returns>A list of 3 complex numbers</returns>
        public List<Complex> SolveCubic(double a, double b, double c, double d)
        {
            const int NRoots = 3;

            double SquareRootof3 = Math.Sqrt(3);
            // 3 koreni od 1
            List<Complex> CubicUnity = new List<Complex>(NRoots)
                        { new Complex(1, 0), new Complex(-0.5, -SquareRootof3 / 2.0), new Complex(-0.5, SquareRootof3 / 2.0) };
            // presmetki
            double DELTA = 18 * a * b * c * d - 4 * b * b * b * d + b * b * c * c - 4 * a * c * c * c - 27 * a * a * d * d;
            double DELTA0 = b * b - 3 * a * c;
            double DELTA1 = 2 * b * b * b - 9 * a * b * c + 27 * a * a * d;
            Complex DELTA2 = -27 * a * a * DELTA;
            Complex C = Complex.Pow((DELTA1 + Complex.Pow(DELTA2, 0.5)) / 2, 1 / 3.0); //Phew...

            List<Complex> R = new List<Complex>(NRoots);
            for (int i = 0; i < NRoots; i++)
            {
                Complex M = CubicUnity[i] * C;
                Complex Root = -1.0 / (3 * a) * (b + M + DELTA0 / M);
                R.Add(Root);
            }
            return R;
        }

        private void Txb_Validating(object sender, CancelEventArgs e)
        {
            TextBox TB = sender as TextBox;
            double result = 0.0;

            try
            {
                result = double.Parse(TB.Text);
            }
            catch (FormatException)
            {
                e.Cancel = true;
                errorProvider1.SetError(TB, "Entry must be numeric.");
            }
            finally 
            {
                switch (TB.Tag.ToString())
                {
                    case "a": Coeff.A = result; break;
                    case "b": Coeff.B = result; break;
                    case "c": Coeff.C = result; break;
                    case "d": Coeff.D = result; break;
                }
            }
        }
        private void Txb_Validated(object sender, EventArgs e)
        {
            // za odstranuvanje i pokazuvanje na greski ""
            errorProvider1.SetError(sender as TextBox, "");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ATxb.Validating += new CancelEventHandler(Txb_Validating);
            ATxb.Validated += new EventHandler(Txb_Validated);
            BTxb.Validating += new CancelEventHandler(Txb_Validating);
            BTxb.Validated += new EventHandler(Txb_Validated);
            CTxb.Validating += new CancelEventHandler(Txb_Validating);
            CTxb.Validated += new EventHandler(Txb_Validated);
            DTxb.Validating += new CancelEventHandler(Txb_Validating);
            DTxb.Validated += new EventHandler(Txb_Validated);
            // citanje na koeficienti
            Coeff.A = 0.0;
            Coeff.B = 0.0;
            Coeff.C = 0.0;
            Coeff.D = 0.0;
        }

        private void SolveBtn_Click_1(object sender, EventArgs e)
        {
            // povikuvanje na site broevi pomali od 0
            const double small = 1E-15;
            double Re;
            double Im;

            //presmetka na koren
            List<Complex> Roots = SolveCubic(Coeff.A, Coeff.B, Coeff.C, Coeff.D);

            Re = Math.Abs(Roots[0].Real) < small ? 0.0 : Roots[0].Real;
            Im = Math.Abs(Roots[0].Imaginary) < small ? 0.0 : Roots[0].Imaginary;
            X1RealTxb.Text = Re.ToString();
            X1ImagTxb.Text = Im.ToString();

            Re = Math.Abs(Roots[1].Real) < small ? 0.0 : Roots[1].Real;
            Im = Math.Abs(Roots[1].Imaginary) < small ? 0.0 : Roots[1].Imaginary;
            X2RealTxb.Text = Re.ToString();
            X2ImagTxb.Text = Im.ToString();

            Re = Math.Abs(Roots[2].Real) < small ? 0.0 : Roots[2].Real;
            Im = Math.Abs(Roots[2].Imaginary) < small ? 0.0 : Roots[2].Imaginary;
            X3RealTxb.Text = Re.ToString();
            X3ImagTxb.Text = Im.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // povikuvanje na site broevi pomali od 0
            const double small = 1E-15;
            double Re;
            double Im;

            //presmetka na koren
            List<Complex> Roots = SolveCubic(Coeff.A, Coeff.B, Coeff.C, Coeff.D);

            Re = Math.Abs(Roots[0].Real) < small ? 0.0 : Roots[0].Real;
            Im = Math.Abs(Roots[0].Imaginary) < small ? 0.0 : Roots[0].Imaginary;
            X1RealTxb.Text = Re.ToString();
            X1ImagTxb.Text = Im.ToString();

            Re = Math.Abs(Roots[1].Real) < small ? 0.0 : Roots[1].Real;
            Im = Math.Abs(Roots[1].Imaginary) < small ? 0.0 : Roots[1].Imaginary;
            X2RealTxb.Text = Re.ToString();
            X2ImagTxb.Text = Im.ToString();

            Re = Math.Abs(Roots[2].Real) < small ? 0.0 : Roots[2].Real;
            Im = Math.Abs(Roots[2].Imaginary) < small ? 0.0 : Roots[2].Imaginary;
            X3RealTxb.Text = Re.ToString();
            X3ImagTxb.Text = Im.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
