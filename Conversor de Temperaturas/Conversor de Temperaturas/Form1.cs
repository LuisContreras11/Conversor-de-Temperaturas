using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Temperaturas
{
    public partial class Form1 : Form
    {
        int bandera = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double grados;
                //Si se escribe en centigrados
                if (bandera == 1)
                {
                    grados = Convert.ToDouble(txtCen.Text) * 9.0 / 5.0 + 32.0;
                    //Mostrados el resultado
                    txtFar.Text = string.Format("{0:F2}", grados);
                }
                if (bandera == 2)
                {
                    grados = Convert.ToDouble(txtCen.Text) * ((-32) * (5.0 / 9.0));
                    //mostramos el resultado
                    txtCen.Text = string.Format("{0:F2}", grados);
                }
            }
            catch (FormatException)
            {
                txtCen.Text = "0.0";
                txtFar.Text = "32.00";
            }
        }

        private void TxtCen_KeyPress(object sender, KeyPressEventArgs e)
        {
            bandera = 1;
            if (e.KeyChar == 13)
            {
                Button1_Click(sender, e);//Llama a la funcion
            }
        }

        private void TxtFar_KeyPress(object sender, KeyPressEventArgs e)
        {
            bandera = 2;
            if (e.KeyChar == 13)
            {
                Button1_Click(sender, e);//Llama a la funcion
            }
        }
    }
    }

