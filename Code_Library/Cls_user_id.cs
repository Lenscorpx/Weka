using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weka.Code_Library
{
    public class Cls_user_id
    {
        private string usr_ID;
        public string User_ID
        {
            get
            {
                return usr_ID;
            }

            set
            {
                usr_ID = value;
            }
        }
        public override string ToString()
        {
            return User_ID;
        }
    }
}
