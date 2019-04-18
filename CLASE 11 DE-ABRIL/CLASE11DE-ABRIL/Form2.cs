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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario, pass;
            usuario = textBox1.Text.TrimEnd();
            pass = textBox2.Text.TrimEnd();
            if (usuario=="UTEC" && pass=="programacion1")
            {
                MessageBox.Show("BIENVENIDO");
            }
            else
            {
                MessageBox.Show("INTENTE DE NUEVO");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
