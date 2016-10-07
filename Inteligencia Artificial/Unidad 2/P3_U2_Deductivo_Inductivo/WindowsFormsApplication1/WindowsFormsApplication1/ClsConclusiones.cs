using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ClsConclusiones
    {
        private string conclusion = "";
        string[] preMay = new string[15]; //string[] preMen = new string[15];
        public string Deductivo(string PraMay, string PdaMay, string TraMay,string CtaMay, string PraMen, string SdaMen, string TraMen)
        {  //posibles oraciones Todos los hombres son libres, Todas las Frutas citricas tienen vitamina C, Juan tiene / es pelo largo. PM.
            //La pina es una fruta citrica, 

            if ((PraMay == "todo" || PraMay == "toda") && (PdaMay == TraMen || TraMay == TraMen) )
            {
                conclusion = PraMen + " " + TraMay + " " + CtaMay;
            }
            /*else if((PraMay == "todo" || PraMay == "toda") && ())
            {

            }*/

            return conclusion;
            /*if (preMay[0] == "todos" || preMay[0] == "todas" || preMay[0] == "las" || preMay[0] == "los" || preMay[0] == "todo" || preMay[0] == "toda")
            {
                /*if (preMay[1] == )
                {

                }
            }
            else if (preMay[1] == "es" && (preMay[0] != "todos" || preMay[0] != "todas"))
            {

            }

            if (preMen[0] == "la" || preMen[0] == "el")
            {

            }
            else if (preMen[1] == "es" && (preMen[0] != "todos" || preMay[0] != "todas"))
            {

            }

            return conclusion;*/
        }

        public string Inductivo(string p1, string p11, string p111, string p2, string p22, string p222, string p3, string p33, string p333)
        {
            preMay = p333.Split('y');
            if ((p11 == p22 && p22 == p33) && (p111 == p222 && p222 == p333))
            {
                if (p11 == "es" && p22 == "es" && p33 == "es")
                {
                    conclusion = "Todo " + preMay[0] + " es " + preMay[1];
                }
                else
                {
                    conclusion = "Todo " + preMay[0] + " tiene " + preMay[1];
                }
            }
            return conclusion;
        }
    }
}
