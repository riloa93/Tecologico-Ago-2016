using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Semantica_P2_U2
{
    class ClsAtributosPajaro : ClsSubClaseAnimalP
    {
        string puede, tiene, pone;
        public ClsAtributosPajaro()
        {
            puede = "volar";
            tiene = "alas";
            pone = "huevos";
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

        public string Pone
        {
            get { return pone; }
            set { pone = value; }
        }
    }
}
