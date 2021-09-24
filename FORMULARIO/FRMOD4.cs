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
    public partial class FRMOD4 : Form
    {
        public FRMOD4()
        {
            InitializeComponent();
        }

        private void btninvertir_Click(object sender, EventArgs e)
        {
            string f1 = "", f2 = "";
            f1 = txtpalabra.Text;

            for (int x = f1.Length - 1; x >= 0; x--)
            {
                f2 += f1[x];
            }
            lblinvertir.Text = f2.ToString();
        }
    }
}
