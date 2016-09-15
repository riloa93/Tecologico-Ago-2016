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
    public partial class FrmAgregarBase : Form
    {
        public FrmAgregarBase()
        {
            InitializeComponent();
            txtPalabra.Focus();
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

                ClsGuardadas.GetBDCDefinicion(bdcDefiniciones); ClsGuardadas.GetBDCPalabra(bdcPalabras);

                if (chkbAuto.Checked == true) ClsGuardadas.tipo = 1;
                else if(chkbEstatico.Checked == true) ClsGuardadas.tipo = 2;

                if (ClsGuardadas.tipo == 1)
                {
                    Form1 forma = new Form1();
                    forma.Show();
                    this.Hide();
                }
                else if(ClsGuardadas.tipo == 2)
                {
                    Frm_Estatico form = new Frm_Estatico();
                    form.Show();
                    this.Hide();
                }
                else if (ClsGuardadas.tipo == 0) MessageBox.Show("Debes seleccionar un modo \"Estático\" ó \"Automático\".", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Debes ingresar por lo menos 1 item para poder realizar preguntas.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPalabra.Focus();
            }
        }

        private void chkbEstatico_Click(object sender, EventArgs e)
        {
            chkbEstatico.Checked = true; chkbAuto.Checked = false;
        }

        private void chkbAuto_Click(object sender, EventArgs e)
        {
            chkbAuto.Checked = true; chkbEstatico.Checked = false;
        }
    }
}
