
using System;
using System.Collections.Generic;

namespace Es5Pag278
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quanti biglietti vuoi aquistare");
            int biglietti = int.Parse(Console.ReadLine());
            Random r = new Random();
            int[] arrayBiglietti = new int[biglietti];
            for (int i = 0; i < arrayBiglietti.Length; i++)
            {
                arrayBiglietti[i] = r.Next(10000, 999999);
                Console.WriteLine($"{arrayBiglietti[i]}");
            }
            Console.ReadLine();
        }
    }
}