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
    public partial class FRMOD6 : Form
    {

        string Palabra = "ESTUDIANTE";
        int Letra;
        int CantMal;
        int CantBien;
        bool Muestra;
        public FRMOD6()
        {
            InitializeComponent();
        }

        private void FRMOD6_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertarLetra_Click(object sender, EventArgs e)
        {
            if (txtLetras.Text != "")
            {
                int VCant = 0;
                if (txtPalabras.Text == "")
                    txtPalabras.Text = txtLetras.Text;
                else
                    txtPalabras.Text = txtPalabras.Text + " , " + txtLetras.Text;

                do
                {
                    if (VCant == 0)
                        Letra = Palabra.IndexOf(txtLetras.Text);
                    else
                        Letra = Palabra.IndexOf(txtLetras.Text, Letra + 1);

                    Muestra = MostrarLetra(Letra);
                    if (CantBien == Palabra.Length)
                    {
                        MessageBox.Show("Ganaste !!! Felicitaciones");
                        Limpiar();
                        txtLetras.Focus();
                    }
                    if (Muestra)
                    {
                        VCant += 1;
                    }

                } while (Muestra);

                if (VCant == 0)
                {
                    CantMal += 1;
                    MuestraImagen(CantMal);

                }
            }
            txtLetras.Text = "";
            txtLetras.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
            UbicarLetras(Palabra);
        }

        public void UbicarLetras(String palabra)
        {
            int Longitud = Palabra.Length;
            for (int i = 0; i < Longitud; i++)
            {
                switch (i)
                {
                    case 0:
                        label11.Visible = true;
                        label1.Text = palabra.Substring(i, 1);
                        break;

                    case 1:
                        label12.Visible = true;
                        label2.Text = palabra.Substring(i, 1);
                        break;

                    case 2:
                        label13.Visible = true;
                        label3.Text = palabra.Substring(i, 1);
                        break;

                    case 3:
                        label14.Visible = true;
                        label4.Text = palabra.Substring(i, 1);
                        break;

                    case 4:
                        label15.Visible = true;
                        label5.Text = palabra.Substring(i, 1);
                        break;

                    case 5:
                        label16.Visible = true;
                        label6.Text = palabra.Substring(i, 1);
                        break;

                    case 6:
                        label17.Visible = true;
                        label7.Text = palabra.Substring(i, 1);
                        break;

                    case 7:
                        label18.Visible = true;
                        label8.Text = palabra.Substring(i, 1);
                        break;

                    case 8:
                        label19.Visible = true;
                        label9.Text = palabra.Substring(i, 1);
                        break;

                    case 9:
                        label20.Visible = true;
                        label10.Text = palabra.Substring(i, 1);
                        break;
                }
            }
        }

        public bool MostrarLetra(int letra)
        {
            bool Resultado = true;
            CantBien += 1;
            switch (letra)
            {
                case 0:
                    label1.Visible = true;
                    break;
                case 1:
                    label2.Visible = true;
                    break;
                case 2:
                    label3.Visible = true;
                    break;
                case 3:
                    label4.Visible = true;
                    break;
                case 4:
                    label5.Visible = true;
                    break;
                case 5:
                    label6.Visible = true;
                    break;
                case 6:
                    label7.Visible = true;
                    break;
                case 7:
                    label8.Visible = true;
                    break;
                case 8:
                    label9.Visible = true;
                    break;
                case 9:
                    label10.Visible = true;
                    break;
                default:
                    CantBien -= 1;
                    Resultado = false;
                    break;
            }
            return Resultado;
        }

        public void Limpiar()
        {
            ptbPrimero.Visible = false;
            ptbSegundo.Visible = false;
            ptbTercero.Visible = false;
            ptbCuarto.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;

            CantBien = 0;
            CantMal = 0;
            txtPalabras.Text = "";
        }

        public void MuestraImagen(int NumeroImagen)
        {
            switch (NumeroImagen)
            {
                case 1: ptbPrimero.Visible = true; break;
                case 2: ptbSegundo.Visible = true; break;
                case 3:
                    ptbTercero.Visible = true;
                    MessageBox.Show("Piensa Muy Bien Tu Siguiente Letra.", "WARNING");
                    break;
                case 4:
                    ptbCuarto.Visible = true;
                    MessageBox.Show("Perdiste", "GAME OVER");
                    Limpiar();
                    UbicarLetras(Palabra);
                    break;
                default: break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }






