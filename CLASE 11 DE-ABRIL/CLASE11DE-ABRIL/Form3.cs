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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total=0;
            if (radioButton1.Checked==true)
            {
                total = total + 50;
            }

            if (radioButton2.Checked==true)
            {
                total = total + 100;
            }

            if (radioButton3.Checked==true)
            {
                total = total + 150;
            }

            if (checkBox1.Checked==true)
            {
                total = total + 5;
            }

            if (checkBox2.Checked==true)
            {
                total = total + 15;
            }

            if (checkBox3.Checked==true)
            {
                total = total + 20;
            }

            MessageBox.Show("TOTAL DE GASTO DE ENVIO " + total.ToString("c2"));
        }
    }
}
