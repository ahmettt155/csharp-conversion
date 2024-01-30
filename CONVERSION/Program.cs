using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CONVERSION
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int bakiye = 600;
            Console.WriteLine("Nasıl bir işlem yapmak istiyorsunuz?");
            Console.WriteLine("1 = Bakiyenizi görüntüleyin");
            Console.WriteLine("2 = belirlediğiniz tutarda para çekin");
            Console.WriteLine("3 = Belirlediğiniz tutarda para yatırın");
            Console.WriteLine("4 = Hesabınızdan çıkış yapın");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("bakiyeniz = " + bakiye + "$");
                Console.ReadLine();

            }
            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kalan tutar = " + (bakiye - cekilecek_tutar));
                Console.WriteLine(cekilecek_tutar + "$ Başarıyla çekilmiştir.");
                Console.ReadLine();
            }
            else if (secim == "3")
            {
                Console.WriteLine("yatırılacak tutarı giriniz");
                int yatiriliacak_tutar = Convert.ToInt32(Console.ReadLine());
                bakiye = bakiye + yatiriliacak_tutar;
                Console.WriteLine(yatiriliacak_tutar + "$ başarıyla yatırılmıştır");
                Console.WriteLine("yeni bakiyeniz = " + bakiye);
                Console.ReadLine();
            }
            else if (secim =="4")
            {
                Console.WriteLine("Çıkış yapılıyor..");
                Thread.Sleep(1500);
            
            }










        }   
            
    }
}
