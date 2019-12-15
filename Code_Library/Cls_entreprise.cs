using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weka.Code_Library
{
    public class Cls_entreprise
    {
        private string id_entreprise;
        public string Id_entreprise
        {
            get
            {
                return id_entreprise;
            }

            set
            {
                id_entreprise = value;
            }
        }
        public override string ToString()
        {
            return Id_entreprise;
        }
    }
}
