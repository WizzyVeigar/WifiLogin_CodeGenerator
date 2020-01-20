using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiLogin_CodeGenerator
{
    class WifiCodeGenerator
    {
        string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";


        internal WifiCode GenerateNewCode()
        {
            string result = string.Empty;

            for (int i = 0; i <= 15; i++)
            {
                result += symbols[new Random(Guid.NewGuid().GetHashCode()).Next(0, symbols.Length)].ToString();
            }


            return new WifiCode(result);
        }
    }
}
