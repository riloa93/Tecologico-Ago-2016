using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Semantica_P2_U2
{
    class ClsAtributosCanario :ClsSubClasePajaro
    {
        string puede, es;

        public ClsAtributosCanario()
        {
            puede = "cantar";
            es = "amarillo";
        }

        public string Puede
        {
            get { return puede; }
            set { puede = value; }
        }

        public string Es
        {
            get { return es; }
            set { es = value; }
        }
    }
}
