using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiLogin_CodeGenerator.Interfaces
{
    interface IAddMultipleToDb<T>
    {
        void AddMultipleToDb(List<T> listOfData);
    }
}
