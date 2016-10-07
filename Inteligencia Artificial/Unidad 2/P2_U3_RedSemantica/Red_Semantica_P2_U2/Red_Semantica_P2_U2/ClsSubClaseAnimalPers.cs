using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Semantica_P2_U2
{
    class ClsSubClaseAnimalPers : ClsSuperClase
    {
        string persona;
        public ClsSubClaseAnimalPers()
        {
            persona = "persona";
        }

        public string Persona
        {
            get { return persona; }
            set { persona = value; }
        }
    }
}
