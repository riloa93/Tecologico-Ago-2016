using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Damas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Busca el entero con el que realiza la formula para decidir si existe o no ataque y retorna el coste de la posicion 
        static int CalFitness(int[] Data)
        {
            int Menos = Data.Length;
            Menos = (Menos * Menos - Menos) / 2;
            int Count = 0;
            for (int i = 0; i < Data.Length; i++)
            {
                int Genoma = Data[i];

                for (int j = 0; j < Data.Length; j++)
                {
                    if (j != i && Data[j] == Data[i])
                    {
                        Count++;
                    }

                }



                for (int j = 0; j < Data.Length; j++)
                {
                    if (j != i && Data[j] - j == Data[i] - i)
                    {
                        Count++;
                    }

                    if (j != i && Data[j] + j == Data[i] + i)
                    {
                        Count++;
                    }

                }
            }




            Count = Menos - Count / 2;

            return Count;

        }

        

        public static string[] FindPermutations(string word)
        {
            if (word.Length == 2)
            {
                char[] _c = word.ToCharArray();
                string s = new string(new char[] { _c[1], _c[0] });
                return new string[]
            {
                    word,
                    s
            };
            }

            List<String> _result = new List<String>();
            string[] _subsetPermutations = FindPermutations(word.Substring(1));
            char _firstChar = word[0];
            foreach (string s in _subsetPermutations)
            {
                string _temp = _firstChar.ToString() + s;
                _result.Add(_temp);
                char[] _chars = _temp.ToCharArray();
                for (int i = 0; i < _temp.Length - 1; i++)
                {
                    char t = _chars[i];
                    _chars[i] = _chars[i + 1];
                    _chars[i + 1] = t;
                    string s2 = new string(_chars);
                    _result.Add(s2);
                }
            }
            return _result.ToArray();
        }

        //Realiza las tareas de busqueda por medio de las permutaciones y el metodo de findCal
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int numm = Convert.ToInt16(e.Argument.ToString());

            String num = String.Empty;
            for (int i = 1; i <= numm; i++)
            {
                num += i.ToString();
            }


            string[] dat = FindPermutations(num);
            int ValF = num.Length * (num.Length - 1) / 2;
            List<String> dats = new List<string>();
            dats.AddRange(dat);
            dats.Sort(delegate(String t1, String t2)
            { return (t1.CompareTo(t2)); });

            int count = 0;
            double tot = dats.Count;
            double countx = 0;
            foreach (string item in dats)
            {
                String Res = String.Empty;
                int[] Data = new int[item.Length];
                for (int i = 0; i < item.Length; i++)
                {
                    Data[i] = Convert.ToInt16(item[i].ToString());

                }

                countx++;
                String h = String.Empty;
                if (CalFitness(Data) == ValF)
                {
                    h = item;
                    
                }
                backgroundWorker1.ReportProgress((int)(100 * countx / tot), h);

            }
        }
        int lastp = -1;

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState.ToString()==String.Empty)
            {
                progressBar1.Value = e.ProgressPercentage;    
            }
            else
            {
                progressBar1.Value = e.ProgressPercentage;
                listBox1.Items.Add(e.UserState.ToString());
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                this.Text = listBox1.Items.Count.ToString();    
            }
            
            
        }

        //Se instancia el StopWatch y en el evento del click se envia el proceso en el BackgroundWorker
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        private void button1_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            listBox1.Items.Clear();
            sw.Start();
            backgroundWorker1.RunWorkerAsync(comboBox1.Text);
            
        }

        //Aqui finaliza y manda el mensaje de terminacion y detiene el StopWatch y lo resetea
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("OK! "+sw.ElapsedMilliseconds.ToString()+" ms");
            sw.Stop();
            sw.Reset();
            button1.Enabled = true;
        }

        //Aqui lo que hace es que al hacer la seleccion del indice del listbox manda al metodo que sigue de este y dibuja la solucion
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                return;
            }
            String X = listBox1.SelectedItem.ToString();
            int N = X.Length;
            int[] Dat = new int[N];
            for (int j = 0; j < X.Length; j++)
            {


                Dat[j] = Convert.ToInt16(X[j].ToString());

            }

            Pain(Dat);
        }

        public void Pain(int[] Data)
        {
         
            Bitmap bmp = new Bitmap(pictureBox1.Width-10, pictureBox1.Height-10);
            int w = (pictureBox1.Width-10) / Data.Length;
            int h = (pictureBox1.Height-10) / Data.Length;

            Graphics g = Graphics.FromImage(bmp);

            Random r = new Random();

            for (int i = 0; i < Data.Length; i++)
            {
                Color Rc = Color.FromArgb(r.Next(0, 255),r.Next(0, 255),r.Next(0, 255));

               



                Font f = new Font(this.Font.FontFamily, 28);
                g.DrawString("Q", f, new SolidBrush(Color.Black), new PointF(i * w, (Data[i] - 1) * h));

            }
            for (int j = 0; j <= Data.Length; j++)
            {


                g.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(w * j, 0), new Point(w * j, pictureBox1.Height));
                g.DrawLine(new Pen(new SolidBrush(Color.Black)), new Point(0, h * j), new Point(pictureBox1.Width, h * j));
            }
            pictureBox1.Image = bmp;
          
        }

        private void Form1_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
