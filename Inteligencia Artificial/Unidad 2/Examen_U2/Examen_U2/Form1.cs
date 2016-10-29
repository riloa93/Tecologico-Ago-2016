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

namespace Examen_U2
{
    public partial class frm_Pal : Form
    {
        public frm_Pal()
        {
            InitializeComponent();
        }

        private void frm_Pal_Load(object sender, EventArgs e)
        {
            dgvTablaProbabilidad.Rows.Add("Comida (C) ","C: P(C) = .10");
            dgvTablaProbabilidad.Rows.Add("Tifoidea (T) ","T: P(T|C) = .60", "T: P(T|Ĉ) = .40");
            dgvTablaProbabilidad.Rows.Add("Reacciones (R) ","R: P(R|Ť) = .70","R: P(R|T) = .30");
            dgvTablaProbabilidad.Rows.Add("Fiebre (F)","F: P(F | T, G) = 1", "F: P(F|T,Ĝ) = 1", "F: P(F|Ť,G) = 1", "F: P(F|Ť,Ĝ) = 0");
            dgvTablaProbabilidad.Rows.Add("Gripe (G)","G: P(G) = .30");
            dgvTablaProbabilidad.Rows.Add("Dolor (D)","D: P(D | T, G) = .90", "D: P(D|T,Ĝ) = .70", "D: P(D|Ť,G) = .80", "D: P(D|Ť,Ĝ) = .10");
            //Dibujo_Inicial();
        }

        private void btnProbabilidad_Click(object sender, EventArgs e)
        {
            double cal1 = 0; double cal2 = 0; double cal3 = 0; double res = 0;
            switch (cmbPregunta.SelectedIndex)
            {
                case 0://Probabilidad de Comer y tener Tifoidea
                    cal1 = Convert.ToDouble(300) / Convert.ToDouble(500);
                    res = (0.60f * cal1) * 100;
                    MessageBox.Show("El porcentaje es de: " + res + "%.");
                    break;
                case 1://Probabilidad de Comer y tener No Tifoidea
                    cal1 = Convert.ToDouble(200) / Convert.ToDouble(500);
                    res = (0.40f * cal1) * 100;
                    MessageBox.Show("El porcentaje es de: " + res + "%.");
                    break;
                case 2://Probabilidad de Tener Tifoidea y Reacciones
                    cal1 = Convert.ToDouble(350) / Convert.ToDouble(500);
                    res = (0.70f * cal1) * 100;
                    MessageBox.Show("El porcentaje es de: " + res + "%.");
                    break;
                case 3://Probabilidad de Comer, No Tener Tifoidea y Tener Reacciones
                    cal1 = Convert.ToDouble(150) / Convert.ToDouble(500);
                    res = (0.30f * cal1) * 100;
                    MessageBox.Show("El porcentaje es de: " + res + "%.");
                    break;
                case 4://Probabilidad de tener Tifoidea y Gripe y tener Fiebre
                    cal1 = (Convert.ToDouble(2000) / Convert.ToDouble(2000));
                    res = (1f * cal1) * 100;
                    MessageBox.Show("El porcentaje es de: " + res + "%.");
                    break;
                case 5://Probabilidad de tener Tifoidea y No tener Gripe y tener Fiebre
                    cal1 = (Convert.ToDouble(500) / Convert.ToDouble(2000));
                    res = (0.25f * cal1) * 100;
                    MessageBox.Show("El porcentaje es de: " + res + "%.");
                    break;
                case 6://Probabilidad de No tener Tifoidea y Tener Gripe y tener Fiebre
                    cal1 = (Convert.ToDouble(1500) / Convert.ToDouble(2000));
                    res = (0.75f * cal1) * 100;
                    MessageBox.Show("El porcentaje es de: " + res + "%.");
                    break;
                case 7://Probabilidad de No tener Tifoidea Ni Gripe y tener Fiebre
                    cal1 = (Convert.ToDouble(0) / Convert.ToDouble(2000));
                    res = (0f * cal1) * 100;
                    MessageBox.Show("El porcentaje es de: " + res + "%.");
                    break;
                case 8://Probabilidad de Tener Tifoidea y Gripe y Tener Dolor
                    cal1 = (Convert.ToDouble(2000) / Convert.ToDouble(2000));
                    res = (0.90f * cal1) * 100;
                    MessageBox.Show("El porcentaje es de: " + res + "%.");
                    break;
                case 9://Probabilidad de Tener Tifoidea y No Gripe y Tener Dolor
                    cal1 = (Convert.ToDouble(222) / Convert.ToDouble(2000));
                    res = (0.1f * cal1) * 100;
                    MessageBox.Show("El porcentaje es de: " + res + "%.");
                    break;
                case 10://Probabilidad de No Tener Tifoidea y Tener Gripe y Tener Dolor
                    cal1 = (Convert.ToDouble(1777) / Convert.ToDouble(2000));
                    res = (0.8f * cal1) * 100;
                    MessageBox.Show("El porcentaje es de: " + res + "%.");
                    break;
                case 11://Probabilidad de No Tener Tifoidea Ni Gripe y Tener Dolor
                    cal1 = (Convert.ToDouble(222) / Convert.ToDouble(2000));
                    res = (0.1f * cal1) * 100;
                    MessageBox.Show("El porcentaje es de: " + res + "%.");
                    break;

                default: MessageBox.Show("Selecciona alguna probabilidad a calcular.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void Dibujo_Inicial()
        {
            Graphics g = this.CreateGraphics();
            Pen pluma = new Pen(Color.Black);
            string drawString;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            g.DrawEllipse(pluma, 750, 20, 80, 50);
            g.DrawLine(pluma, 720, 100, 780, 70);
            g.DrawEllipse(pluma, 670, 100, 80, 50);
            g.DrawLine(pluma, 710, 150, 710, 180);
            g.DrawEllipse(pluma, 670, 180, 80, 50);
            g.DrawLine(pluma, 740, 140, 800, 180);
            g.DrawEllipse(pluma, 760, 180, 80, 50);
            g.DrawLine(pluma, 750, 120, 885, 180);
            g.DrawEllipse(pluma, 850, 180, 80, 50);
            g.DrawLine(pluma, 910, 150, 900, 180);
            g.DrawEllipse(pluma, 870, 100, 80, 50);
            g.DrawLine(pluma, 890, 147, 800, 180);

            drawString = "Comida (C)";
            float x = 753.0f;
            float y = 40.0f;
            g.DrawString(drawString, drawFont, drawBrush, x, y);

            drawString = "Tifoidea (T)";
            float x1 = 675.0f;
            float y1 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x1, y1);

            drawString = "Reacciones \r\n(R)";
            float x2 = 673.0f;
            float y2 = 195.0f;
            g.DrawString(drawString, drawFont, drawBrush, x2, y2);

            drawString = "Fiebre (F)";
            float x3 = 770.0f;
            float y3 = 195.0f;
            g.DrawString(drawString, drawFont, drawBrush, x3, y3);

            drawString = "Gripa (G)";
            float x4 = 880.0f;
            float y4 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x4, y4);

            drawString = "Dolor (D)";
            float x5 = 865.0f;
            float y5 = 197.0f;
            g.DrawString(drawString, drawFont, drawBrush, x5, y5);
        }

        private void Caso0()
        {
            Graphics g = this.CreateGraphics();
            Pen pluma = new Pen(Color.Black);
            string drawString;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            g.Clear(Color.LightGray);
            g.DrawEllipse(pluma, 750, 20, 80, 50);
            g.DrawLine(pluma, 720, 100, 780, 70);
            g.DrawEllipse(pluma, 670, 100, 80, 50);
            drawString = "Comida (C)";
            float x = 753.0f;
            float y = 40.0f;
            g.DrawString(drawString, drawFont, drawBrush, x, y);

            drawString = "Tifoidea (T)";
            float x1 = 675.0f;
            float y1 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x1, y1);
        }

        private void Caso1()
        {
            Graphics g = this.CreateGraphics();
            Pen pluma = new Pen(Color.Black);
            string drawString;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            g.Clear(Color.LightGray);
            g.DrawEllipse(pluma, 750, 20, 80, 50);
            g.DrawLine(pluma, 720, 100, 780, 70);
            g.DrawEllipse(pluma, 670, 100, 80, 50);

            drawString = "Comida (C)";
            float x = 753.0f;
            float y = 40.0f;
            g.DrawString(drawString, drawFont, drawBrush, x, y);

            drawString = "Tifoidea (T)";
            float x1 = 675.0f;
            float y1 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x1, y1);
        }
        private void Caso2()
        {
            Graphics g = this.CreateGraphics();
            Pen pluma = new Pen(Color.Black);
            string drawString;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            g.Clear(Color.LightGray);
            g.DrawEllipse(pluma, 750, 20, 80, 50);
            g.DrawLine(pluma, 720, 100, 780, 70);
            g.DrawEllipse(pluma, 670, 100, 80, 50);
            g.DrawLine(pluma, 710, 150, 710, 180);
            g.DrawEllipse(pluma, 670, 180, 80, 50);

            drawString = "Comida (C)";
            float x = 753.0f;
            float y = 40.0f;
            g.DrawString(drawString, drawFont, drawBrush, x, y);

            drawString = "Tifoidea (T)";
            float x1 = 675.0f;
            float y1 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x1, y1);

            drawString = "Reacciones \r\n(R)";
            float x2 = 673.0f;
            float y2 = 195.0f;
            g.DrawString(drawString, drawFont, drawBrush, x2, y2);
        }
        private void Caso3()
        {
            Graphics g = this.CreateGraphics();
            Pen pluma = new Pen(Color.Black);
            string drawString;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            g.Clear(Color.LightGray);
            g.DrawEllipse(pluma, 750, 20, 80, 50);
            g.DrawLine(pluma, 720, 100, 780, 70);
            g.DrawEllipse(pluma, 670, 100, 80, 50);
            g.DrawLine(pluma, 710, 150, 710, 180);
            g.DrawEllipse(pluma, 670, 180, 80, 50);

            drawString = "Comida (C)";
            float x = 753.0f;
            float y = 40.0f;
            g.DrawString(drawString, drawFont, drawBrush, x, y);

            drawString = "Tifoidea (T)";
            float x1 = 675.0f;
            float y1 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x1, y1);

            drawString = "Reacciones \r\n(R)";
            float x2 = 673.0f;
            float y2 = 195.0f;
            g.DrawString(drawString, drawFont, drawBrush, x2, y2);
        }
        private void Caso4()
        {
            Graphics g = this.CreateGraphics();
            Pen pluma = new Pen(Color.Black);
            string drawString;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            g.Clear(Color.LightGray);
            g.DrawEllipse(pluma, 750, 20, 80, 50);
            g.DrawLine(pluma, 720, 100, 780, 70);
            g.DrawEllipse(pluma, 670, 100, 80, 50);      
            g.DrawLine(pluma, 740, 140, 800, 180);
            g.DrawEllipse(pluma, 760, 180, 80, 50);
            g.DrawEllipse(pluma, 870, 100, 80, 50);
            g.DrawLine(pluma, 890, 147, 800, 180);

            drawString = "Comida (C)";
            float x = 753.0f;
            float y = 40.0f;
            g.DrawString(drawString, drawFont, drawBrush, x, y);

            drawString = "Tifoidea (T)";
            float x1 = 675.0f;
            float y1 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x1, y1);

            drawString = "Fiebre (F)";
            float x3 = 770.0f;
            float y3 = 195.0f;
            g.DrawString(drawString, drawFont, drawBrush, x3, y3);

            drawString = "Gripa (G)";
            float x4 = 880.0f;
            float y4 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x4, y4);
        }
        private void Caso5()
        {
            Graphics g = this.CreateGraphics();
            Pen pluma = new Pen(Color.Black);
            string drawString;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            g.Clear(Color.LightGray);
            g.DrawEllipse(pluma, 750, 20, 80, 50);
            g.DrawLine(pluma, 720, 100, 780, 70);
            g.DrawEllipse(pluma, 670, 100, 80, 50);
            g.DrawLine(pluma, 740, 140, 800, 180);
            g.DrawEllipse(pluma, 760, 180, 80, 50);
            g.DrawEllipse(pluma, 870, 100, 80, 50);
            g.DrawLine(pluma, 890, 147, 800, 180);

            drawString = "Comida (C)";
            float x = 753.0f;
            float y = 40.0f;
            g.DrawString(drawString, drawFont, drawBrush, x, y);

            drawString = "Tifoidea (T)";
            float x1 = 675.0f;
            float y1 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x1, y1);

            drawString = "Fiebre (F)";
            float x3 = 770.0f;
            float y3 = 195.0f;
            g.DrawString(drawString, drawFont, drawBrush, x3, y3);

            drawString = "Gripa (G)";
            float x4 = 880.0f;
            float y4 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x4, y4);
        }
        private void Caso6()
        {
            Graphics g = this.CreateGraphics();
            Pen pluma = new Pen(Color.Black);
            string drawString;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            g.Clear(Color.LightGray);
            g.DrawEllipse(pluma, 750, 20, 80, 50);
            g.DrawLine(pluma, 720, 100, 780, 70);
            g.DrawEllipse(pluma, 670, 100, 80, 50);
            g.DrawLine(pluma, 740, 140, 800, 180);
            g.DrawEllipse(pluma, 760, 180, 80, 50);
            g.DrawEllipse(pluma, 870, 100, 80, 50);
            g.DrawLine(pluma, 890, 147, 800, 180);

            drawString = "Comida (C)";
            float x = 753.0f;
            float y = 40.0f;
            g.DrawString(drawString, drawFont, drawBrush, x, y);

            drawString = "Tifoidea (T)";
            float x1 = 675.0f;
            float y1 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x1, y1);

            drawString = "Fiebre (F)";
            float x3 = 770.0f;
            float y3 = 195.0f;
            g.DrawString(drawString, drawFont, drawBrush, x3, y3);

            drawString = "Gripa (G)";
            float x4 = 880.0f;
            float y4 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x4, y4);
        }
        private void Caso7()
        {
            Graphics g = this.CreateGraphics();
            Pen pluma = new Pen(Color.Black);
            string drawString;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            g.Clear(Color.LightGray);
            g.DrawEllipse(pluma, 750, 20, 80, 50);
            g.DrawLine(pluma, 720, 100, 780, 70);
            g.DrawEllipse(pluma, 670, 100, 80, 50);
            g.DrawLine(pluma, 740, 140, 800, 180);
            g.DrawEllipse(pluma, 760, 180, 80, 50);
            g.DrawEllipse(pluma, 870, 100, 80, 50);
            g.DrawLine(pluma, 890, 147, 800, 180);
            drawString = "Comida (C)";
            float x = 753.0f;
            float y = 40.0f;
            g.DrawString(drawString, drawFont, drawBrush, x, y);

            drawString = "Tifoidea (T)";
            float x1 = 675.0f;
            float y1 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x1, y1);

            drawString = "Fiebre (F)";
            float x3 = 770.0f;
            float y3 = 195.0f;
            g.DrawString(drawString, drawFont, drawBrush, x3, y3);

            drawString = "Gripa (G)";
            float x4 = 880.0f;
            float y4 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x4, y4);
        }
        private void Caso8()
        {
            Graphics g = this.CreateGraphics();
            Pen pluma = new Pen(Color.Black);
            string drawString;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            g.Clear(Color.LightGray);
            g.DrawEllipse(pluma, 750, 20, 80, 50);
            g.DrawLine(pluma, 720, 100, 780, 70);
            g.DrawEllipse(pluma, 670, 100, 80, 50);
            g.DrawLine(pluma, 750, 120, 885, 180);
            g.DrawEllipse(pluma, 850, 180, 80, 50);
            g.DrawLine(pluma, 910, 150, 900, 180);
            g.DrawEllipse(pluma, 870, 100, 80, 50);

            drawString = "Comida (C)";
            float x = 753.0f;
            float y = 40.0f;
            g.DrawString(drawString, drawFont, drawBrush, x, y);

            drawString = "Tifoidea (T)";
            float x1 = 675.0f;
            float y1 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x1, y1);

            drawString = "Gripa (G)";
            float x4 = 880.0f;
            float y4 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x4, y4);

            drawString = "Dolor (D)";
            float x5 = 865.0f;
            float y5 = 197.0f;
            g.DrawString(drawString, drawFont, drawBrush, x5, y5);
        }
        private void Caso9()
        {
            Graphics g = this.CreateGraphics();
            Pen pluma = new Pen(Color.Black);
            string drawString;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            g.Clear(Color.LightGray);
            g.DrawEllipse(pluma, 750, 20, 80, 50);
            g.DrawLine(pluma, 720, 100, 780, 70);
            g.DrawEllipse(pluma, 670, 100, 80, 50);
            g.DrawLine(pluma, 750, 120, 885, 180);
            g.DrawEllipse(pluma, 850, 180, 80, 50);
            g.DrawLine(pluma, 910, 150, 900, 180);
            g.DrawEllipse(pluma, 870, 100, 80, 50);

            drawString = "Comida (C)";
            float x = 753.0f;
            float y = 40.0f;
            g.DrawString(drawString, drawFont, drawBrush, x, y);

            drawString = "Tifoidea (T)";
            float x1 = 675.0f;
            float y1 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x1, y1);

            drawString = "Gripa (G)";
            float x4 = 880.0f;
            float y4 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x4, y4);

            drawString = "Dolor (D)";
            float x5 = 865.0f;
            float y5 = 197.0f;
            g.DrawString(drawString, drawFont, drawBrush, x5, y5);
        }

        private void Caso10()
        {
            Graphics g = this.CreateGraphics();
            Pen pluma = new Pen(Color.Black);
            string drawString;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            g.Clear(Color.LightGray);
            g.DrawEllipse(pluma, 750, 20, 80, 50);
            g.DrawLine(pluma, 720, 100, 780, 70);
            g.DrawEllipse(pluma, 670, 100, 80, 50);
            g.DrawLine(pluma, 750, 120, 885, 180);
            g.DrawEllipse(pluma, 850, 180, 80, 50);
            g.DrawLine(pluma, 910, 150, 900, 180);
            g.DrawEllipse(pluma, 870, 100, 80, 50);

            drawString = "Comida (C)";
            float x = 753.0f;
            float y = 40.0f;
            g.DrawString(drawString, drawFont, drawBrush, x, y);

            drawString = "Tifoidea (T)";
            float x1 = 675.0f;
            float y1 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x1, y1);

            drawString = "Gripa (G)";
            float x4 = 880.0f;
            float y4 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x4, y4);

            drawString = "Dolor (D)";
            float x5 = 865.0f;
            float y5 = 197.0f;
            g.DrawString(drawString, drawFont, drawBrush, x5, y5);
        }

        private void Caso11()
        {
            Graphics g = this.CreateGraphics();
            Pen pluma = new Pen(Color.Black);
            string drawString;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            g.Clear(Color.LightGray);
            g.DrawEllipse(pluma, 750, 20, 80, 50);
            g.DrawLine(pluma, 720, 100, 780, 70);
            g.DrawEllipse(pluma, 670, 100, 80, 50);
            g.DrawLine(pluma, 750, 120, 885, 180);
            g.DrawEllipse(pluma, 850, 180, 80, 50);
            g.DrawLine(pluma, 910, 150, 900, 180);
            g.DrawEllipse(pluma, 870, 100, 80, 50);

            drawString = "Comida (C)";
            float x = 753.0f;
            float y = 40.0f;
            g.DrawString(drawString, drawFont, drawBrush, x, y);

            drawString = "Tifoidea (T)";
            float x1 = 675.0f;
            float y1 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x1, y1);

            drawString = "Gripa (G)";
            float x4 = 880.0f;
            float y4 = 115.0f;
            g.DrawString(drawString, drawFont, drawBrush, x4, y4);

            drawString = "Dolor (D)";
            float x5 = 865.0f;
            float y5 = 197.0f;
            g.DrawString(drawString, drawFont, drawBrush, x5, y5);
        }

        private void frm_Pal_Paint(object sender, PaintEventArgs e)
        {
            switch (cmbPregunta.SelectedIndex)
            {
                case 0://Probabilidad de Comer y tener Tifoidea
                    Caso0();
                    break;
                case 1://Probabilidad de Comer y tener No Tifoidea
                    Caso1();
                    break;
                case 2://Probabilidad de Tener Tifoidea y Reacciones
                    Caso2();
                    break;
                case 3://Probabilidad de Comer, No Tener Tifoidea y Tener Reacciones
                    Caso3();
                    break;
                case 4://Probabilidad de tener Tifoidea y Gripe y tener Fiebre
                    Caso4();
                    break;
                case 5://Probabilidad de tener Tifoidea y No tener Gripe y tener Fiebre
                    Caso5();
                    break;
                case 6://Probabilidad de No tener Tifoidea y Tener Gripe y tener Fiebre
                    Caso6();
                    break;
                case 7://Probabilidad de No tener Tifoidea Ni Gripe y tener Fiebre
                    Caso7();
                    break;
                case 8://Probabilidad de Tener Tifoidea y Gripe y Tener Dolor
                    Caso8();
                    break;
                case 9://Probabilidad de Tener Tifoidea y No Gripe y Tener Dolor
                    Caso9();
                    break;
                case 10://Probabilidad de No Tener Tifoidea y Tener Gripe y Tener Dolor
                    Caso10();
                    break;
                case 11://Probabilidad de No Tener Tifoidea Ni Gripe y Tener Dolor
                    Caso11();
                    break;

                default:
                    Dibujo_Inicial();
                    break;
            }
        }
    }
}
