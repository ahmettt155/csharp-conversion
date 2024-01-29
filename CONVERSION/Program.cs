using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSION
{
    internal class Program
    {
        static void Main(string[] args)
            


        {
            Console.WriteLine("notunuzu giriniz");
            string not = Console.ReadLine();
            int notInt = Convert.ToInt32(not);

            if (notInt > 50)
                Console.WriteLine("geçti");

            else
                Console.WriteLine("kaldı");


            Console.ReadLine();









        }
    }
}
