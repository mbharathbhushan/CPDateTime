using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Console.WriteLine(date.ToString());

              


            Console.WriteLine("Universal Time {0}", date.ToUniversalTime().ToString());
            Console.WriteLine("Global Time {0}", date);
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
