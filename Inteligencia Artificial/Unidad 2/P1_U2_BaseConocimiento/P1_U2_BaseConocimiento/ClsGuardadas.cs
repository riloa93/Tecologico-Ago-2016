using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace P1_U2_BaseConocimiento
{
    class ClsGuardadas
    {
        public static ArrayList bdcPalabra = new ArrayList();
        public static ArrayList bdcDefinicion = new ArrayList();
        public static ArrayList bdcPalabraAcepted = new ArrayList();
        public static ArrayList bdcDefinicionAcepted = new ArrayList();
        public static int tipo = 0;
        public static string word = "", definition = "";

        /*PALABRAS Y DEFINICIONES GUARDADAS AL INICIO DE LA APLICACION*/
        public static void GetBDCPalabra(ArrayList palabras)
        {
            for (int i = 0; i < palabras.Count; i++) bdcPalabra.Add(palabras[i].ToString().Trim());
        }

        public static void GetBDCDefinicion(ArrayList definiciones)
        {
            for (int i = 0; i < definiciones.Count; i++) bdcDefinicion.Add(definiciones[i].ToString().Trim());
        }


        /*PALABRAS Y DEFINICIONES QUE SON ACEPTADAS EN CASO DE USAR ESTATICO EL PROGRAMA*/
        public static void GetBDCPalabra_Aceptada(ArrayList pal)
        {
            for (int i = 0; i < pal.Count; i++) bdcPalabraAcepted.Add(pal[i].ToString().Trim());
        }

        public static void GetBDCDefinicion_Aceptada(ArrayList def)
        {
            for (int i = 0; i < def.Count; i++) bdcDefinicionAcepted.Add(def[i].ToString().Trim());
        }

        public static string Comprobar_Agregar(string palabra)
        {
            string agregado = "";

            for (int i = 0; i < bdcPalabraAcepted.Count; i++)
            {
                if (palabra == bdcPalabraAcepted[i].ToString().Trim())
                {
                    bdcPalabra.Add(palabra.Trim()); bdcDefinicion.Add(bdcDefinicionAcepted[i].ToString());
                    agregado = bdcDefinicionAcepted[i].ToString();
                    break;
                }
            }
            return agregado;
        }


        /*COMPROBACION DE SI EXISTE LA PALABRA QUE SE ESCRIBIO Y ENVIAR LAS DEFINICIONES PARA COMPROBAR SI SE ACEPTA
         UNA NUEVA PALABRA O NO */
        public static bool Exists(string pregunta)
        {
            bool existe = false;

            for (int i = 0; i < bdcPalabra.Count; i++)
            {
                if (pregunta == bdcPalabra[i].ToString().Trim()) { existe = true; break; }
            }

            return existe;
        }
        public static string SetBDCDefinicion(string palabra)
        {
            string defin = "";

            for (int i = 0; i < bdcPalabra.Count; i++)
            {
                if (palabra == bdcPalabra[i].ToString().Trim()) { defin = bdcDefinicion[i].ToString().Trim(); break; }
            }
            return defin ;
        }

        //public static ArrayList SetBDCPalabra() { return bdcPalabra; }
    }
}
