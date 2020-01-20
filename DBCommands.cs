using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WifiLogin_CodeGenerator.Interfaces;

namespace WifiLogin_CodeGenerator
{
    //Should be abstract? how do this properly???
    public abstract class DBCommands<T> : IAddToDb<T>, IGetDbDataTable, IAddMultipleToDb<T>
    {
        public abstract void AddMultipleToDb(List<T> listOfData);
        public abstract void AddObjToDb(T obj);
        public abstract void AddToDb(string data);
        public abstract DataTable GetDb();
    }
}
