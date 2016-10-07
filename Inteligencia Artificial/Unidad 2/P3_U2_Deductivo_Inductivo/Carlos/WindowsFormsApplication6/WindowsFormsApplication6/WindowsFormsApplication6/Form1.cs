using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int contador = 0;

        string[] sujeto1 = new string [1];
        string[] verbo1= new string [1];
        string[] resto1= new string [1];
        string[] oracion1Completa = new string[3];

        string[] sujeto2 = new string[1];
        string[] verbo2 = new string[1];
        string[] resto2 = new string[1];
        string[] oracion2Completa = new string[3];

        private void button1_Click(object sender, EventArgs e)
        {
            contador = 0;
            sujeto1[0] = textBox1.Text;
            verbo1[0] = textBox2.Text;
            resto1[0] = textBox3.Text;
            oracion1Completa[0] = sujeto1[0];
            oracion1Completa[1] = verbo1[0];
            oracion1Completa[2] = resto1[0];

            sujeto2[0] = textBox4.Text;
            verbo2[0] = textBox5.Text;
            resto2[0] = textBox6.Text;
            oracion2Completa[0] = sujeto2[0];
            oracion2Completa[1] = verbo2[0];
            oracion2Completa[2] = resto2[0];


            if (buscarCoincidencia(oracion1Completa, oracion2Completa) == true)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    concluir();
                }
                else
                {
                    intuir();
                }
               
            }
            else
            {
                listBox1.Items.Add("No existe coincidencia alguna para intuir");
            }

        }

        bool buscarCoincidencia(string []oracion1, string [] oracion2)
        {
            bool coincide = false;

            for (int i = 0; i < oracion1.Length; i++)
            {
                for (int j = 0; j < oracion2.Length; j++)
                {
                    if (oracion1[i] == oracion2[j])
                    {
                        coincide = true;
                        i = oracion1.Length;
                        break;
                    }
                }
            }

            return coincide;
        }

        void concluir()
        {
            switch (contador)
            {   
                case 0:
                    listBox1.Items.Add(sujeto2[0] + " " + verbo1[0] + " " + resto1[0]);
                    break;
                case 1:
                    listBox1.Items.Add(sujeto2[0] + " " + verbo2[0] + " " + resto1[0]);
                    break;
                case 2:
                    listBox1.Items.Add(sujeto2[0] + " " + verbo1[0] + " " + sujeto1[0]);
                    break;
                default:
                    break;
            }

            contador++;
        }

        void intuir()
        {
            string res = resto1[0];

            string[] c = res.Split('y');

            if (c.Length > 1)
            {
                if (verbo1[0] == "es")
                {
                    listBox1.Items.Add("Todos son" + c[1]);
                }
                else if (verbo1[0] == "tiene")
                {
                    listBox1.Items.Add("Todos tienen" + c[1]);
                }
            }
            else {
                if (verbo1[0] == "es")
                {
                    listBox1.Items.Add("Todos son" + c[0]);
                }
                else if (verbo1[0] == "tiene")
                {
                    listBox1.Items.Add("Todos tienen" + c[0]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            concluir();
        }
  
    
    }
}
