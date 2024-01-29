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
            Console.WriteLine("Lutfen yasınızı giriniz");        //KULLANICIDAN DEĞER ALIRKEN STRİNG KULLANIRIZ
                                                                 //O YÜZDEN STRİNGİ INT'E ÇEVİRMEMİZ LAZIM
            string yas1 = Console.ReadLine();
            int yas1Int = Convert.ToInt32(yas1);

            Console.WriteLine("dogdugunuz yılı giriniz");

            string yil1 = Console.ReadLine();
            int yil1Int = Convert.ToInt32(yil1);

            int toplam = yil1Int + yas1Int;



            Console.WriteLine(toplam);
            Console.ReadLine();









        }
    }
}
