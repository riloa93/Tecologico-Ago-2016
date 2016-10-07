using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Semantica_P2_U2
{
    class ClsSubClaseCanario : ClsSubClasePajaro
    {
        string esun, come;

        public ClsSubClaseCanario()
        {
            esun = "piolin";
        }

        public string EsUn
        {
            get { return esun; }
            set { esun = value; }
        }
    }
}
