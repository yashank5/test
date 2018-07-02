using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dont_Say_Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello...");
            Console.Write("testing..");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Press Any Key to exit");
            Console.ReadKey();
         }
    }
}
