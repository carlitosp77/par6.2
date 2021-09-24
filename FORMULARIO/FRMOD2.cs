using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace par6._2.FORMULARIO
{
    public partial class FRMOD2 : Form
    {
        public FRMOD2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado;
            CLASES.CLSMOD2 FRMOD2 = new CLASES.CLSMOD2();
            resultado = FRMOD2.multiplicar(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox2.Text));
            textBox1.Text = resultado.ToString();
        }

        private void FRMOD2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
