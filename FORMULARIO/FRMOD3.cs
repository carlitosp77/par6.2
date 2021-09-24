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
    public partial class FRMOD3 : Form
    {
        public FRMOD3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtcontador.Text;
            int tamaño = nome.Length;
            lbltotal.Text = tamaño.ToString();
        }
    }
}
