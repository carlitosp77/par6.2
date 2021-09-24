using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace par6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mODULO1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORMULARIO.FRMOD1 fRMOD1 = new FORMULARIO.FRMOD1();
            fRMOD1.Show();
        }

        private void mODULO2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORMULARIO.FRMOD2 fRMOD2 = new FORMULARIO.FRMOD2();
            fRMOD2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mODULO3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORMULARIO.FRMOD3 fRMOD3 = new FORMULARIO.FRMOD3();
            fRMOD3.Show();

        }

        private void mODULO4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORMULARIO.FRMOD4 fRMOD4 = new FORMULARIO.FRMOD4();
            fRMOD4.Show();
        }

        private void mODULO6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORMULARIO.FRMOD6 fRMOD6 = new FORMULARIO.FRMOD6();
            fRMOD6.Show();

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
