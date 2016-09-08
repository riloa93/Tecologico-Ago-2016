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

namespace Viajero_P2
{
    public partial class Form1 : Form
    {
        #region Matriz con costes
        int[,] Des_Has = new int[,] {{0, 87, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    {87, 0, 92, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    {0, 92, 0, 142, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    {0, 0, 142, 0, 98, 0, 85, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    {0, 0, 0, 98, 0, 86, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    {0, 0, 0, 0, 86, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    {0, 0, 0, 85, 0, 0, 0, 90, 101, 0, 0, 211, 0, 0, 0, 0, 0, 0, 0, 0},
                                    {0, 0, 0, 0, 0, 0, 90, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    {0, 0, 0, 0, 0, 0, 101, 0, 0, 97, 138, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                    {0, 0, 0, 0, 0, 0, 0, 0, 97, 0, 146, 0, 80, 0, 0, 0, 0, 0, 0, 0},
                                    {0, 0, 0, 0, 0, 0, 0, 0, 138, 146, 0, 0, 0, 120, 0, 0, 0, 0, 0, 0},
                                    {0, 0, 0, 0, 0, 0, 211, 0, 0, 0, 0, 0, 99, 0, 0, 0, 0, 0, 0, 0},
                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 80, 0, 99, 0, 0, 0, 0, 0, 140, 0, 151},
                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 120, 0, 0, 0, 75, 0, 0, 0, 0, 0},
                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 75, 0, 70, 0, 0, 0, 0},
                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 70, 0, 111, 0, 0, 0},
                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 111, 0, 118, 0, 0},
                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 140, 0, 0, 0, 118, 0, 75, 0},
                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 75, 0, 71},
                                    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 151, 0, 0, 0, 0, 0, 71, 0}};

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtOrigen.Text == "" && txtDestino.Text != "") txtOrigen.Focus();
            else if (txtOrigen.Text != "" && txtDestino.Text == "") txtDestino.Focus();
            else if (txtDestino.Text == "" && txtOrigen.Text == "") txtOrigen.Focus();

            else
            {
                Comenzar_Recorrido();
                //Aqui empieza todo el recorrido
            }
        }

        int costeActual = 0, costeTotal = 0;
        ArrayList lugar, coste;
        private void Comenzar_Recorrido()
        {
            int origen = Convert.ToInt32(txtOrigen.Text), destino = Convert.ToInt32(txtDestino.Text);
            int temp = origen;
            lugar = new ArrayList(); coste = new ArrayList();

            if (destino < origen)
            {
                //El tuyo Carlos
            }
            else
            {
                //El mio
            }
            for (; origen < Des_Has.Length -1; origen++)
            {
                for (int des = 0; des < Des_Has.Length -1; des++)
                {
                    if (Des_Has[origen, des] == 0) { }
                    else
                    {
                        lugar.Add(origen += temp);
                        coste.Add(Des_Has[origen, des]); 
                    }
                }
            }
        }
    }
}
