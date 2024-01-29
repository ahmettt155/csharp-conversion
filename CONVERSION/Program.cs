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
            Console.WriteLine("Lutfen yasinizi giriniz");
            string kullanici_yas = Console.ReadLine();

            int kullanici_yasInt = Convert.ToInt32(kullanici_yas);
            int kullanici_yasInt2 = int.Parse(kullanici_yas);

            Console.WriteLine(kullanici_yasInt);
            Console.WriteLine(kullanici_yasInt2);
            Console.ReadLine();









        }
    }
}
