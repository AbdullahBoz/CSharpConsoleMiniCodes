using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Burada 3 hakkımız olan basit bir şifre kontrol kodu yazacağız.
            int i = 0, password = 1234, tryng = 3;
            while (i==0)
            {
                Console.Write("Enter your password: ");  
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == password)  // Girilen sayı şifre ile eşit ise döngüden çıkılsın diyoruz.
                {
                    Console.WriteLine("Password is correct!");
                    break;
                }
                else
                {
                    tryng = tryng - 1; // her denemede şifre hakkımızdan 1 eksiltiyoruz.
                    if (tryng == 0)     // Şifre hakkımız 0'a eşitlenirse şifre bloke oldu yazsını gösterip döngüden çıkılsın diyoruz.
                    {
                        Console.WriteLine("Password is blocked!!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please try again!");  // şifre 0'a eşit değilse tekrar şifre istiyoruz.
                    }
                    
                }
            }
            Console.ReadKey();
        }
    }
}
