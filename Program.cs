using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiLogin_CodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            WifiCodeGenerator codeGenerator;
            SqlController sqlConn;
            SqlCommands sqlCommands;




            while (true)
            {
                

                Console.WriteLine("Do what now?\n" +
                    "1. Get new code\n" +
                    "2. Use existing code");
                while (String.IsNullOrWhiteSpace(Console.ReadLine()))
                {
                    int input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            codeGenerator = new WifiCodeGenerator();
                            codeGenerator.GenerateNewCode();

                            break;

                        default:
                            break;
                    }
                }
                //switch (switch_on)
                //{
                //    default:
                //}
            }
        }

        //void IDoStuff(IAddToDb<Person> conn)
        //{
        //    conn.
        //}
        //void IDoStuff(IAddToDb<Car> conn)
        //{
        //    conn.
        //}
    }
}
