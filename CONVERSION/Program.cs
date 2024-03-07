using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CONVERSION
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Değer gir");

            int deger = Convert.ToInt32(Console.ReadLine());

            if (deger >= 0)
            {

                Console.WriteLine(deger);
                Console.ReadLine();
            }
             else
            {
                int x = deger * -1;
                Console.WriteLine(x);
                Console.ReadLine();


            }








        }




    }
}
