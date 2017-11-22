using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class KvadratnaRavenka : Form
    {

        public KvadratnaRavenka()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void KvadratnaRavenka_Load(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Presmetaj()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, odg1, odg2;
            a = double.Parse(tb_a.Text);
            b = double.Parse(tb_b.Text);
            c = double.Parse(tb_c.Text);
            odg1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))/(2*a);
            odg2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))/(2*a);
            labela_odgovor_1.Text = odg1.ToString("n3");
            labela_odgovor_2.Text = odg2.ToString("n3");
        }
        public void textBox4_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
