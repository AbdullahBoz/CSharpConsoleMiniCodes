using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yıldızlar ile Baklava Dilimi Yapımı
            Console.WriteLine("Yıldızlar ile Baklava Yapımı!");
            Console.WriteLine("Sayı Giriniz:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // İlk döngü girilen sayı kadar yıldız oluşturur.
            for (int i = 1; i <= number; i++)
            {
                // İkinci döngümüz boşlukları oluşturur.
                for (int j = number; j > i; j--)
                {
                    Console.Write(" ");
                }
                // üçüncü döngümüz ile baklava diliminin üst kısmını oluşturuyoruz.
                for (int k = 1; k <=i ; k++)
                {
                    Console.Write(" " + "*");
                }
                Console.WriteLine(); // Bu alt satıra inme komutunu vermesseniz yanyana boşluklu yıldızlar oluşur.
            }
            // Dördüncü döngümüz ile baklava diliminin alt satır yıldızlarını oluşturuyoruz.
            for (int t = 1; t <= number; t++)
            {
                // Beşinci döngümüz ile baklava diliminin alt satır boşluklarını oluşturur.
                for (int m = 1; m <= t; m++)
                {
                    Console.Write(' ');
                }
                // Altıncı döngümüz ile geri kalan kısmı tamamlıyoruz.
                for (int n = number; n > t; n--)
                {
                    Console.Write(" " + "*");
                }
                Console.WriteLine();
            }
            // Console.Write(" " + "*" <--- Bu yıldız işaretini değiştirerek herhangi bir şekil ile de oluşturabilirsiniz );
                      
            Console.ReadKey();
        }
    }
}
