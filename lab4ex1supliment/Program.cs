using System;

namespace lab4ex1supliment
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Se citesc doua numere de la tastatura. Scrieti un program care va calcula
            cel mai mare divizor comun al numerelor*/

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int cmmdc = 1;

            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0 && m % i == 0)
                {
                    cmmdc = i;
                }
            }

            Console.WriteLine("Cel mai mare divizor comun este " + cmmdc);
            
        }
    }
}
