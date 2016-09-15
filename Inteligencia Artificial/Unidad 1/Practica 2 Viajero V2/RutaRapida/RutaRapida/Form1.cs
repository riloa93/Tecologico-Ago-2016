using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RutaRapida
{
    public partial class frmPal : Form
    {
        int ubi = 0, linea = 0;
        string ciu;
        string[] N = new string[3];
        string[] Cuidades = new string[20] { "Arad", "Bucharest", "Craiova", "Dobreta", "Eforie", "Fagaras", "Giurgiu", "Hirsova", "Iasi", "Lugoj", "Mehadai", "Neamt", "Oradea", "Pitesti", "Rimnicu", "Sibiu", "Timisoara", "Urziceni", "Vaslui", "Zerind" };

        #region
        int[] A1 = new int[3] { 118, 75, 140 };////A
        int[] A2 = new int[3] { 329, 374, 253 };
        string[] A3 = new string[3] { "Timisoara", "Zerind", "Sibiu" };
        int[] C1 = new int[3] { 120, 146, 138 };/////C
        int[] C2 = new int[3] { 242, 193, 100 };
        string[] C3 = new string[3] { "Dobreta", "Rimnicu", "Pitesti" };
        int[] D1 = new int[3] { 75, 400, 120 };/////D
        int[] D2 = new int[3] { 241, 400, 100 };
        string[] D3 = new string[3] { "Mehadia", "0000000", "Craiova" };
        int[] E1 = new int[3] { 85, 400, 400 };/////E
        int[] E2 = new int[3] { 151, 400, 400 };
        string[] E3 = new string[3] { "Hirsova", "0000000", "0000000" };
        int[] F1 = new int[3] { 99, 400, 211 };/////F
        int[] F2 = new int[3] { 253, 400, 0 };
        string[] F3 = new string[3] { "Sibiu", "0000000", "Bucharest" };
        int[] H1 = new int[3] { 86, 400, 98 };/////H
        int[] H2 = new int[3] { 161, 400, 80 };
        string[] H3 = new string[3] { "Eforie", "0000000", "Urziceni" };
        int[] I1 = new int[3] { 87, 400, 92 };/////I
        int[] I2 = new int[3] { 234, 400, 199 };
        string[] I3 = new string[3] { "Neamt", "0000000", "Vaslui" };
        int[] L1 = new int[3] { 70, 400, 111 };/////L
        int[] L2 = new int[3] { 241, 400, 329 };
        string[] L3 = new string[3] { "Mehadia", "0000000", "Timisoara" };
        int[] M1 = new int[3] { 75, 400, 70 };/////M
        int[] M2 = new int[3] { 242, 400, 244 };
        string[] M3 = new string[3] { "Dobreta", "0000000", "Lugoj" };
        int[] N1 = new int[3] { 87, 400, 400 };/////N
        int[] N2 = new int[3] { 226, 400, 400 };
        string[] N3 = new string[3] { "Iasi", "0000000", "0000000" };
        int[] O1 = new int[3] { 71, 400, 151 };/////O
        int[] O2 = new int[3] { 374, 400, 253 };
        string[] O3 = new string[3] { "Zerind", "0000000", "Sibiu" };
        int[] P1 = new int[3] { 138, 97, 101 };/////P
        int[] P2 = new int[3] { 160, 193, 0 };
        string[] P3 = new string[3] { "Craiova", "Rimnicu", "Bucharest" };
        int[] R1 = new int[3] { 146, 80, 97 };////R
        int[] R2 = new int[3] { 160, 253, 100 };
        string[] R3 = new string[3] { "Craiova", "Sibiu", "Pitesti" };
        int[] S1 = new int[3] { 80, 140, 99 };///S
        int[] S2 = new int[3] { 193, 366, 178 };
        string[] S3 = new string[3] { "Rimnicu", "Arad", "Faragas" };
        int[] T1 = new int[3] { 111, 400, 118 };///T
        int[] T2 = new int[3] { 244, 400, 366 };
        string[] T3 = new string[3] { "Lugoj", "000000", "Arad" };
        int[] U1 = new int[3] { 85, 142, 98 };/////U
        int[] U2 = new int[3] { 0, 199, 151 };
        string[] U3 = new string[3] { "Bucharest", "Vaslui", "Hirsova" };
        int[] V1 = new int[3] { 92, 400, 142 };/////V
        int[] V2 = new int[3] { 226, 400, 80 };
        string[] V3 = new string[3] { "Iasi", "0000000", "Urziceni" };
        int[] Z1 = new int[3] { 75, 400, 71 };///Z
        int[] Z2 = new int[3] { 366, 400, 380 };
        string[] Z3 = new string[3] { "Arad", "000000", "Oradea" };
        #endregion

        public frmPal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstCiudades.Items.Clear();
            linea = 0;
            if (comboBox1.Text == "Arad")
            {
                ciu = Cuidades[0];
                N = A3;
                Metodo1(A1, A2);
            }
            if (comboBox1.Text == "Craiova")
            {
                ciu = Cuidades[2];
                N = C3;
                Metodo1(C1, C2);
            }
            if (comboBox1.Text == "Dobreta")
            {
                ciu = Cuidades[3];
                N = D3;
                Metodo1(D1, D2);
            }
            if (comboBox1.Text == "Eforie")
            {
                ciu = Cuidades[4];
                N = E3;
                Metodo1(E1, E2);
            }
            if (comboBox1.Text == "Fagaras")
            {
                ciu = Cuidades[5];
                N = F3;
                Metodo1(F1, F2);
            }
            if (comboBox1.Text == "Giurgiu")
            {
                lstCiudades.Items.Add("---Ruta mas corta:Bucharest = 90---");
            }
            if (comboBox1.Text == "Hirsova")
            {
                ciu = Cuidades[7];
                N = H3;
                Metodo1(H1, H2);
            }
            if (comboBox1.Text == "Iasi")
            {
                ciu = Cuidades[8];
                N = I3;
                Metodo1(I1, I2);
            }
            if (comboBox1.Text == "Lugoj")
            {
                ciu = Cuidades[9];
                N = L3;
                Metodo1(L1, L2);
            }
            if (comboBox1.Text == "Mehadia")
            {
                ciu = Cuidades[10];
                N = M3;
                Metodo1(M1, M2);
            }
            if (comboBox1.Text == "Neamt")
            {
                ciu = Cuidades[11];
                N = N3;
                Metodo1(N1, N2);
            }
            if (comboBox1.Text == "Oradea")
            {
                ciu = Cuidades[12];
                N = O3;
                Metodo1(O1, O2);
            }
            if (comboBox1.Text == "Pitesti")
            {
                ciu = Cuidades[13];
                N = P3;
                Metodo1(P1, P2);
            }
            if (comboBox1.Text == "Rimnicu")
            {
                ciu = Cuidades[14];
                N = R3;
                Metodo1(R1, R2);
            }
            if (comboBox1.Text == "Sibiu")
            {
                ciu = Cuidades[15];
                N = S3;
                Metodo1(S1, S2);
            }
            if (comboBox1.Text == "Timisoara")
            {
                ciu = Cuidades[16];
                N = T3;
                Metodo1(T1, T2);
            }
            if (comboBox1.Text == "Urziceni")
            {
                ciu = Cuidades[17];
                N = U3;
                Metodo1(U1, U2);
            }
            if (comboBox1.Text == "Vaslui")
            {
                ciu = Cuidades[18];
                N = V3;
                Metodo1(V1, V2);
            }
            if (comboBox1.Text == "Zerind")
            {
                ciu = Cuidades[19];
                N = Z3;
                Metodo1(Z1, Z2);
            }
            
        }

        public void Metodo1(int[] g, int[] h)
        {
            int dev = 1000;
            int res = 0;
            for (int i = 0; i < g.Length; i++)
            {
                res = g[i] + h[i];
                if (res < 800)
                {
                    lstCiudades.Items.Add("De " + ciu + " a " +  N[i] + " = " + (linea + res).ToString());
                }
                
                if (res < dev)
                {
                    dev = res;
                    ubi = i;
                    if (linea > 2000)
                    {
                        MessageBox.Show("Se a ciclado");
                        return;
                    }
                }
            }
            lstCiudades.Items.Add("---Ruta mas corta:" + N[ubi] + " = " + (linea + dev).ToString() + "--");
            linea += g[ubi];
            if (N[ubi] == "Bucharest")
            {
                return;
            }
            else
            {
                if (N[ubi] == "Pitesti")
                {
                    ciu = Cuidades[13];
                    N = P3;
                    Metodo1(P1, P2);
                }
                else if (N[ubi] == "Arad")
                {
                    ciu = Cuidades[0];
                    N = A3;
                    Metodo1(A1, A2);
                }
                else if (N[ubi] == "Sibiu")
                {
                    ciu = Cuidades[15];
                    N = S3;
                    Metodo1(S1, S2);
                }
                else if (N[ubi] == "Rimnicu")
                {
                    ciu = Cuidades[14];
                    N = R3;
                    Metodo1(R1, R2);
                }
                else if (N[ubi] == "Craiova")
                {
                    ciu = Cuidades[2];
                    N = C3;
                    Metodo1(C1, C2);
                }
                else if (N[ubi] == "Lugoj")
                {
                    ciu = Cuidades[9];
                    N = L3;
                    Metodo1(L1, L2);
                }
                else if (N[ubi] == "Mehadia")
                {
                    ciu = Cuidades[10];
                    N = M3;
                    Metodo1(M1, M2);
                }
                else if (N[ubi] == "Oradea")
                {
                    ciu = Cuidades[12];
                    N = O3;
                    Metodo1(O1, O2);
                }
                else if (N[ubi] == "Timisoara")
                {
                    ciu = Cuidades[16];
                    N = T3;
                    Metodo1(T1, T2);
                }
                else if (N[ubi] == "Dobreta")
                {
                    ciu = Cuidades[3];
                    N = D3;
                    Metodo1(D1, D2);
                }
                else if (N[ubi] == "Zerind")
                {
                    ciu = Cuidades[19];
                    N = Z3;
                    Metodo1(Z1, Z2);
                }
                else if (N[ubi] == "Hirsova")
                {
                    ciu = Cuidades[7];
                    N = H3;
                    Metodo1(H1, H2);
                }
                else if (N[ubi] == "Urziceni")
                {
                    ciu = Cuidades[17];
                    N = U3;
                    Metodo1(U1, U2);
                }
                else if (N[ubi] == "Iasi")
                {
                    ciu = Cuidades[8];
                    N = I3;
                    Metodo1(I1, I2);
                }
                else if (N[ubi] == "Neamt")
                {
                    ciu = Cuidades[11];
                    N = N3;
                    Metodo1(N1, N2);
                }
                else if (N[ubi] == "Vaslui")
                {
                    ciu = Cuidades[18];
                    N = V3;
                    Metodo1(V1, V2);
                }
            }
        }
    }
}
