using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dordeKalansizBolunen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Girilen 5 adet sayıdan 100-200 arasındaki sayıların adetini
            * 100'den küçük olan sayıların toplamını ve
            * 200'den büyük sayılardan 4'e kalansız bölünenlerin sayısını veren program.
           */
            int tp = 0, kalansiz = 0, adet = 0, i = 1;
            do
            {
                Console.WriteLine("Sayi Giriniz: ");
                int sy1 = Convert.ToInt16(Console.ReadLine());
                if (sy1 < 100)
                {
                    tp = tp + 1;
                    i++;
                }
                else if (sy1 <= 200)
                {
                    adet = adet + 1;
                    i++;
                }
                else if (sy1 > 200)
                {
                    if (sy1 % 4 == 0)
                    {
                        kalansiz = kalansiz + 1;
                        i++;
                    }
                }
            }
            while (i <= 5);
            Console.WriteLine("100-200 arasındaki sayıların adeti = {0}", adet);
            Console.WriteLine("100'den küçük olan sayıların toplamı= {0}", tp);
            Console.WriteLine("200'den büyük sayılardan 4'e kalansız bölünenlerin sayısı = {0}", kalansiz);
            Console.ReadKey();

        }
    }
}
