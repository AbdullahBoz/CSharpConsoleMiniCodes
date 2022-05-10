using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examNoteAvg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, homework;
            double avg;
            Console.WriteLine("Please enter the student's first grade: ");
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter the student's second grade: ");
            n2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter the student's third grade: ");
            n3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter the student's homework grade: ");
            homework = Convert.ToInt16(Console.ReadLine());

            avg = n1 + n2 + n3 + homework / 4;
            Console.WriteLine("Student's average grade: {0}", avg);

            Console.ReadKey();
        }
    }
}
