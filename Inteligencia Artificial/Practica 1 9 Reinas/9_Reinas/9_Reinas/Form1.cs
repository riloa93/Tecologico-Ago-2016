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

namespace _9_Reinas
{
    public partial class frmPal : Form
    {
        ArrayList encontradas = new ArrayList();
        int soluciones = 352, cont = 0;
        string[,] tabla = new string[9, 9];
        public frmPal()
        {
            InitializeComponent();
            //for (int x = 1; x < 10; x++) grdReinas.Rows.Add(x.ToString());
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            tabla[0,0] = "Q";
            /*tabla[1, 0] = "Q";
            tabla[2, 0] = "Q";
            tabla[3, 0] = "Q";
            tabla[4, 0] = "Q";
            tabla[5, 0] = "Q";
            tabla[6, 0] = "Q";
            tabla[7, 0] = "Q";
            tabla[8, 0] = "Q";*/

            Comenzar_Recorrido();
        }

        private void Comenzar_Recorrido()
        {
            bool movValido;
            while (encontradas.Count == soluciones)
            {
                for (int f = 0; f < tabla.Length; f++)
                {
                    for (int c = 0; c < tabla.Length; c++)
                    {
                        if(tabla[f, c] == "Q")
                        {
                            movValido = Movimiento_Arriba(f,c);
                            if (movValido)
                            {
                                //Aqui iria tu metodo para checar si hay ataques o no
                            }
                        }
                    }
                }
            }
        }

        private bool Movimiento_Arriba(int fila,int col)
        {
            bool valido = true;

            if ((fila == 0 && col == 0) || (fila == 0 && col == 1) || (fila == 0 && col == 2) || (fila == 0 && col == 3) || (fila == 0 && col == 4) || (fila == 0 && col == 5) ||
                (fila == 0 && col == 6) || (fila == 0 && col == 7) || (fila == 0 && col == 8)) valido = false;

            return valido;
        }

        private bool Movimiento_Abajo(int fila,int col)
        {
            bool valido = true;

            if ((fila == 8 && col == 0) || (fila == 8 && col == 1) || (fila == 8 && col == 2) || (fila == 8 && col == 3) || (fila == 8 && col == 4) || (fila == 8 && col == 5) ||
                (fila == 8 && col == 6) || (fila == 8 && col == 7) || (fila == 8 && col == 8)) valido = false;

            return valido;
        }

        private bool Movimiento_Izquierda(int fila,int col)
        {
            bool valido = true;

            if ((fila == 0 && col == 0) || (fila == 1 && col == 0) || (fila == 2 && col == 0) || (fila == 3 && col == 0) || (fila == 4 && col == 0) || (fila == 5 && col == 0) ||
                (fila == 6 && col == 0) || (fila == 7 && col == 0) || (fila == 8 && col == 0)) valido = false;

            return valido; 
        }

        private bool Movimiento_Derecha(int fila, int col)
        {
            bool valido = true;

            if ((fila == 0 && col == 8) || (fila == 1 && col == 8) || (fila == 2 && col == 8) || (fila == 3 && col == 8) || (fila == 4 && col == 8) || (fila == 5 && col == 8) ||
                (fila == 6 && col == 8) || (fila == 7 && col == 8) || (fila == 8 && col == 8)) valido = false;

            return valido;
        }

        private bool Movimiento_Diagonal_Iiz(int fila, int col)
        {
            bool valido = true;



            return valido;
        }
    }
}
