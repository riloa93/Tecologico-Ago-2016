using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace P1_U2_BaseConocimiento
{
    public partial class Frm_Estatico : Form
    {
        public Frm_Estatico()
        {
            InitializeComponent();
            txtPalabra.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ArrayList bdcPalabras = new ArrayList(); ArrayList bdcDefiniciones = new ArrayList();
            string[] temp = new string[4];

            if (lstBDC.Items.Count > 0)
            {
                for (int i = 0; i < lstBDC.Items.Count; i++)
                {
                    temp = lstBDC.Items[i].ToString().Split('=');

                    for (int j = 0; j < temp.Length; j++)
                    {
                        if (j == 0 || j % 2 == 0) bdcPalabras.Add(temp[j].ToString());
                        else bdcDefiniciones.Add(temp[j].ToString());
                    }
                }

                ClsGuardadas.GetBDCDefinicion_Aceptada(bdcDefiniciones); ClsGuardadas.GetBDCPalabra_Aceptada(bdcPalabras);

                Form1 forma = new Form1();
                forma.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debes ingresar por lo menos 1 item para poder realizar preguntas.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPalabra.Focus();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtPalabra.Text != "" && txtDefinicion.Text != "")
            {
                lstBDC.Items.Add(txtPalabra.Text + " = " + txtDefinicion.Text);
                txtPalabra.Clear(); txtDefinicion.Clear(); txtPalabra.Focus();
            }
            else if (txtPalabra.Text == "") txtPalabra.Focus();
            else if (txtDefinicion.Text == "") txtDefinicion.Focus();
        }

        private void Frm_Estatico_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
