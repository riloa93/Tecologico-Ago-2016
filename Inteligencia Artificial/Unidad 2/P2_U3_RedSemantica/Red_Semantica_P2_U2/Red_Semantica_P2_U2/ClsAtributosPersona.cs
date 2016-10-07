using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Semantica_P2_U2
{
    class ClsAtributosPersona : ClsSubClaseAnimalPers
    {
        string tiene, es, es1;

        public ClsAtributosPersona()
        {
            tiene = "piernas y brazos";
            es = "carnivoro";
            es1 = "inteligente";
        }

        public string Tiene
        {
            get { return tiene; }
            set { tiene = value; }
        }

        public string Es
        {
            get { return es; }
            set { es = value; }
        }

        public string Es1
        {
            get { return es1; }
            set { es1 = value; }
        }
    }
}
