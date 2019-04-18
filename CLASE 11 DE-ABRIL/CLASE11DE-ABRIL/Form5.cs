using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE11DE_ABRIL
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void CaF_Click_1(object sender, EventArgs e)
        {
            double gfarenheit, ct1;
            ct1 = Convert.ToDouble(textBox1.Text);
            gfarenheit = ct1 * 1.8 + 32.0;
            textBox2.Text = gfarenheit.ToString();
        }

        private void FaC_Click(object sender, EventArgs e)
        {
            double gcentigrados, ct1;
            ct1 = Convert.ToDouble(textBox1.Text);
            gcentigrados = (ct1 - 32.0) / 1.8;
            textBox2.Text = gcentigrados.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
