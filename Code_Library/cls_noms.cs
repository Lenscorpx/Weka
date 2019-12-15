using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weka.Code_Library
{
    public class Cls_noms
    {
        private string noms;
        public string Noms
        {
            get
            {
                return noms;
            }

            set
            {
                noms = value;
            }
        }
        public override string ToString()
        {
            return Noms;
        }
    }
}