using System;

namespace Algoritmo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;

            Console.WriteLine("Inserta un numero");

            Num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Num; i ++)
            {
              System.Console.Write("1, ");
            }

            Console.WriteLine(Num);

        }
    }
}