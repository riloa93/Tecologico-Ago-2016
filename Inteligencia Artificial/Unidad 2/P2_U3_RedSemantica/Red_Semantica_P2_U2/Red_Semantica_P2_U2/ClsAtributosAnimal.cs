using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Semantica_P2_U2
{
    class ClsAtributosAnimal :ClsSuperClase
    {
        string come, puede, tiene;
        public ClsAtributosAnimal()
        {
            come = "alimentos";
            puede = "respirar";
            tiene = "piel";
        }

        public string Come
        {
            get { return come; }
            set { come = value; }
        }

        public string Puede
        {
            get { return puede; }
            set { puede = value; }
        }

        public string Tiene
        {
            get { return tiene; }
            set { tiene = value; }
        }
    }
}
