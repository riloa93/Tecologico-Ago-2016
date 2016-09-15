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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //bdcPalabra.Add("Hombre"); bdcDefinicion.Add("Persona"); bdcPalabra.Add("Mujer"); 
        }

        private void btnRealizarPregunta_Click(object sender, EventArgs e)
        {
            bool existe;

            if (txtPregunta.Text != "")
            {
                existe = ClsGuardadas.Exists(txtPregunta.Text.Trim());

                if (ClsGuardadas.bdcPalabraAcepted.Count > 0)
                {
                    if (existe)
                    {
                        lblMensaje.Text = ClsGuardadas.SetBDCDefinicion(txtPregunta.Text);
                        lblMensaje.ForeColor = Color.Green;
                        lblMensaje.Visible = true;
                        txtPregunta.Focus();
                    }
                    else
                    {
                        string agregado = "";

                        agregado = ClsGuardadas.Comprobar_Agregar(txtPregunta.Text);

                        if (agregado != "")
                        {
                            lblMensaje.Visible = true;
                            lblMensaje.ForeColor = Color.Green;
                            lblMensaje.Text = agregado;
                            txtPregunta.Focus();
                        }
                        else
                        {
                            MessageBox.Show("No se ha encontrado coincidencia con el tema de mi conocimiento.", "PALABRA NO ADMITIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblMensaje.ForeColor = Color.Red;
                            lblMensaje.Text = "No puedo responder a tu pregunta.";
                            txtPregunta.Clear();
                            txtPregunta.Focus();
                        }
                    }
                }
                else
                {
                    //existe = ClsGuardadas.Exists(txtPregunta.Text.Trim());

                    if (existe)
                    {
                        lblMensaje.Text = ClsGuardadas.SetBDCDefinicion(txtPregunta.Text);
                        lblMensaje.ForeColor = Color.Green;
                        lblMensaje.Visible = true;
                        txtPregunta.Focus();
                    }
                    else
                    {
                        lblMensaje.Text = "No tengo una respuesta para esa pregunta.";
                        lblMensaje.Visible = true;
                        DialogResult preguntaMessage;
                        for (int i = 0; i < ClsGuardadas.bdcDefinicion.Count; i++)
                        {
                            preguntaMessage = MessageBox.Show("¿La siguiente definición aplica para tu pregunta?" + "\r\n " + ClsGuardadas.bdcDefinicion[i].ToString(), "REPONDER A LA PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (DialogResult.Yes == preguntaMessage)
                            {
                                ClsGuardadas.bdcDefinicion.Add(ClsGuardadas.bdcDefinicion[i].ToString());
                                ClsGuardadas.bdcPalabra.Add(txtPregunta.Text.Trim());
                                lblMensaje.Text = ClsGuardadas.bdcDefinicion[i].ToString().Trim();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("No se ha encontrado coincidencia con el tema de mi conocimiento.", "PALABRA NO ADMITIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                lblMensaje.ForeColor = Color.Red;
                                lblMensaje.Text = "No puedo responder a tu pregunta.";
                                txtPregunta.Clear();
                                txtPregunta.Focus();
                            }
                        }
                    }
                } 
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
