using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Semantica_P2_U2
{
    class ClsSubClaseAnimalP : ClsSuperClase
    {
        string pajaro;

        public ClsSubClaseAnimalP()
        {
            pajaro = "pajaro";
        }

        public string Pajaro
        {
            get { return pajaro; }
            set { pajaro = value; }
        }
    }
}
