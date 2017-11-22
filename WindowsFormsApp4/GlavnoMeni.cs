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
    public partial class GlavnoMeni : Form
    {
        public GlavnoMeni()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KvadratnaRavenka kr = new KvadratnaRavenka();
            kr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KubnaRavenka kubra = new KubnaRavenka();
            kubra.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            KubnaRavenka fr1 = new KubnaRavenka();
            fr1.Show();
        }
    }
}
