using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program wyświetla n-ta liczbę w ciągu fibonacciego");
            Console.Write("Podaj ktorą (n-tą) liczbę w ciągu wyświetnić? ");

            int n;
            do
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out n) && n > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Błędna wartość. Podaj ktorą (n-tą) liczbę w ciągu wyświetnić? Musi to być dodatnia liczba całkowita");
                }
            } while (true);

            FibN(n);


        }
        

        static void FibN(int n) 
        {
            int suma = 0;
            int a = 0;
            int b = 1;

            if (n < 1)
            {
                Console.WriteLine("Błąd. Wartość musi być całkowitą liczbą DODATNIĄ.");
            } else if (n == 1)
            {
               suma = 1;
            } else
            {
                for (int i = 1; i < n; i++)
                {
                    suma = a + b;
                    a = b;
                    b = suma;
                }
            }
            Console.WriteLine(suma);
        }



    }
}
