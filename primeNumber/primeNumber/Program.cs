using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz. \nGirilen sayının asal olup olmadığı kontrol edilecektir!");
            int number = Convert.ToInt16(Console.ReadLine());
            bool primeNumber = true;
            if (number % 2 == 0)
            {
                primeNumber = false;
                Console.WriteLine("Sayı asal değildir!");
            }
            if (primeNumber)
                Console.WriteLine("Girdiğiniz sayı asaldır!");
            Console.ReadKey();
        }
    }
}
