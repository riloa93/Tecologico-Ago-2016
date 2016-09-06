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
using System.Diagnostics;

namespace _9_Reinas
{
    public partial class frmPal : Form
    {
        /*ArrayList encontradas = new ArrayList();
        int soluciones = 352, cont = 0;
        string[,] tabla = new string[9, 9];*/
        Stopwatch swTarea = new Stopwatch();


        public frmPal()
        {
            InitializeComponent();

            for (int i = 1; i < 10; i++) grdReinas.Rows.Add();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            /*tabla[0,0] = "Q";
            Comenzar_Recorrido();*/
            lsbSoluciones.Items.Clear();
            btnComenzar.Enabled = false;
            swTarea.Start();
            bgrdWTarea.RunWorkerAsync("9");
        }

        private void bgrdWTarea_DoWork(object sender, DoWorkEventArgs e)
        {
            int numm = Convert.ToInt16(e.Argument.ToString());
            String num = String.Empty;

            for (int i = 1; i <= numm; i++) num += i.ToString();

            string[] Perm = Buscar_Permutaciones(num);
            int valF = num.Length * (num.Length - 1) / 2;
            List<String> lstDatos = new List<string>();
            lstDatos.AddRange(Perm);
            lstDatos.Sort(delegate (String s1, String s2) { return (s1.CompareTo(s2)); });

            //int count = 0;
            double total = lstDatos.Count;
            double countx = 0;

            foreach (string item in lstDatos)
            {
                String Res = String.Empty;
                int[] Datos = new int[item.Length];
                for (int i = 0; i < item.Length; i++) Datos[i] = Convert.ToInt16(item[i].ToString());

                countx++;
                String h = String.Empty;
                if (Calcular_Ataques(Datos) == valF) h = item;
                
                bgrdWTarea.ReportProgress((int)(100 * countx / total), h);
            }
        }

        private void bgrdWTarea_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState.ToString() == String.Empty)
            {
                pgrbTarea.Value = e.ProgressPercentage;
            }
            else
            {
                pgrbTarea.Value = e.ProgressPercentage;
                lsbSoluciones.Items.Add(lsbSoluciones.Items.Count + 1 + ".- "+ e.UserState.ToString());
                lsbSoluciones.SelectedIndex = lsbSoluciones.Items.Count - 1;
            }
        }

        private void bgrdWTarea_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnComenzar.Enabled = true;
            MessageBox.Show("Se han encontrado " + lsbSoluciones.Items.Count.ToString() + " soluciones.", "FINALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static string[] Buscar_Permutaciones(string contenido)
        {
            if (contenido.Length == 2)
            {
                char[] caracter = contenido.ToCharArray();
                string s = new string(new char[] { caracter[1], caracter[0] });
                return new string[] { contenido, s };
            }

            List<String> resultados = new List<String>();
            string[] conjuntoPerm = Buscar_Permutaciones(contenido.Substring(1));
            char car1ero = contenido[0];
            foreach (string s in conjuntoPerm)
            {
                string temporal = car1ero.ToString() + s;
                resultados.Add(temporal);
                char[] _chars = temporal.ToCharArray();
                for (int i = 0; i < temporal.Length - 1; i++)
                {
                    char t = _chars[i];
                    _chars[i] = _chars[i + 1];
                    _chars[i + 1] = t;
                    string s2 = new string(_chars);
                    resultados.Add(s2);
                }
            }
            return resultados.ToArray();
        }

        private static int Calcular_Ataques(int[] Pos)
        {
            int Menos = Pos.Length;
            Menos = (Menos * Menos - Menos) / 2;
            int cont = 0;
            for (int i = 0; i < Pos.Length; i++)
            {
                for (int j = 0; j < Pos.Length; j++)
                {
                    if (j != i && Pos[j] == Pos[i])
                    {
                        cont++;
                    }

                }

                for (int j = 0; j < Pos.Length; j++)
                {
                    if (j != i && Pos[j] - j == Pos[i] - i)
                    {
                        cont++;
                    }

                    if (j != i && Pos[j] + j == Pos[i] + i)
                    {
                        cont++;
                    }
                }
            }

            cont = Menos - cont / 2;
            return cont;
        }


        #region Primer Intento
        /*private void Comenzar_Recorrido()
        {
            bool solEncontrada;
            while (encontradas.cont < soluciones)
            {
                #region INICIO FALLIDO
                for (int f = 0; f < tabla.Length; f++)
                {

                    //MIRAR YO DONDE VOY A PONER LA Q
                    if (f > 0)
                    {
                        tabla[f, 0] = "Q";
                    }

                    for (int c = 0; c < tabla.Length; c++)
                    {
                        //Enviar al metodo del Carlos (Yo desde aqui envio fila,columna)
                        if (solEncontrada)
                        {
                            //Recibir las coordeadas donde estan las reinas y guardar la solucion
                            break;
                        }
                    }
                }
                #endregion
                //CHECAR COMO COORDINAR LA SIGUIENTE REINAR QUE SE COLOCARA Y TAMBIEN CHECAR COMO VOLVER A EMPEZAR


            }
        }
        #endregion
        #region MOVIMIENTOS FALSE
        private bool Movimiento_Arriba(int fila, int col)
        {
            bool valido = true;

            if ((fila == 0 && col == 0) || (fila == 0 && col == 1) || (fila == 0 && col == 2) || (fila == 0 && col == 3) || (fila == 0 && col == 4) || (fila == 0 && col == 5) ||
                (fila == 0 && col == 6) || (fila == 0 && col == 7) || (fila == 0 && col == 8)) valido = false;

            return valido;
        }

        private bool Movimiento_Abajo(int fila, int col)
        {
            bool valido = true;

            if ((fila == 8 && col == 0) || (fila == 8 && col == 1) || (fila == 8 && col == 2) || (fila == 8 && col == 3) || (fila == 8 && col == 4) || (fila == 8 && col == 5) ||
                (fila == 8 && col == 6) || (fila == 8 && col == 7) || (fila == 8 && col == 8)) valido = false;

            return valido;
        }

        private bool Movimiento_Izquierda(int fila, int col)
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
        #endregion*/

        #endregion

        private void grdReinas_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
                //Captura el numero de filas del datagridview
                string RowsNumber = (e.RowIndex + 1).ToString();
                while (RowsNumber.Length < grdReinas.RowCount.ToString().Length)
                {
                    RowsNumber = "0" + RowsNumber;
                }
                SizeF size = e.Graphics.MeasureString(RowsNumber, this.Font);
                if (grdReinas.RowHeadersWidth < Convert.ToInt32(size.Width + 20))
                {
                    grdReinas.RowHeadersWidth = Convert.ToInt32(size.Width + 20);
                }
                Brush ob = SystemBrushes.ControlText;
                e.Graphics.DrawString(RowsNumber, this.Font, ob, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        private void lsbSoluciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string soluciones = "", columnas = "";
            for (int i = 0; i < lsbSoluciones.Items.Count; i++)
            {
                soluciones = lsbSoluciones.Items[i].ToString();
            }
        }
    }
}
