using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viajero_P2
{ 
    public partial class Form1 : Form
    {
        int[,] Des_Has;

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
                //Aqui empieza todo el recorrido
            }
        }
    }
}
