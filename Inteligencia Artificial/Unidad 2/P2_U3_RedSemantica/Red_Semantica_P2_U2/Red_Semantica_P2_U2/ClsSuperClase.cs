using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Semantica_P2_U2
{
    class ClsSuperClase
    {
        string animal;
        public ClsSuperClase()
        {
            animal = "animal";
        }

        public string Animal
        {
            get { return animal; }
            set { animal = value; }
        }
    }
}
