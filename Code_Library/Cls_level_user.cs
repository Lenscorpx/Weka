using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weka.Code_Library
{
    public class Cls_level_user
    {
        private string level_user;
        public string Level_user
        {
            get
            {
                return level_user;
            }

            set
            {
                level_user = value;
            }
        }
        public override string ToString()
        {
            return Level_user;
        }
    }
}
