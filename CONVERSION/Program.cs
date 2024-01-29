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
            Console.WriteLine("1. notunuzu girinz");
            int not1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. notunuzu giriniz");
            int not2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3. notu giriniz");
            int not3 = Convert.ToInt32(Console.ReadLine());

            int ortalama = (not1 + not2 + not3) / 3;

            Console.WriteLine("ortalamanız = " + ortalama);


            if (ortalama >= 60)

            {
                if (ortalama >= 80)
                    Console.WriteLine("S+");

                else
                    Console.WriteLine("A+");

            }
            else
            {
                if (ortalama >= 40)
                    Console.WriteLine("B+");

                else
                    Console.WriteLine("F");

            }
            Console.ReadLine();

        }
    }
}
