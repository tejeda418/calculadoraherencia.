using calculadoraherencia.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraherencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clases.clmultiplicacion omultiplicacion = new clmultiplicacion(); textBox3.Text = omultiplicacion.operar(double.Parse(textBox1.Text),
             double.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clrestar oresta = new clrestar(); textBox3.Text = oresta.operar(double.Parse(textBox1.Text),
                 double.Parse(textBox2.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsuma osuma = new clsuma(); textBox3.Text = osuma.operar(double.Parse(textBox1.Text),
            double.Parse(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cldivision odivision = new cldivision(); textBox3.Text = odivision.operar(double.Parse(textBox1.Text),
             double.Parse(textBox2.Text)).ToString();
        }
    }
}
