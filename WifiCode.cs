using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiLogin_CodeGenerator
{
    class WifiCode
    {
        private string code;

        public WifiCode(string code)
        {
            Code = code;
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

    }
}
