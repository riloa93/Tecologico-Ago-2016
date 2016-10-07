using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Semantica_P2_U2
{
    class ClsSubClasePajaro : ClsSubClaseAnimalP 
    {
        string canario;

        public ClsSubClasePajaro()
        {
            canario = "canario";
        }

        public string Canario
        {
            get { return canario; }
            set { canario = value; }
        }
    }
}
