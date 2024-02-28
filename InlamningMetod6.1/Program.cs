using System;

namespace InlamningMetod6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = Addera(3, 5, 8);
            Console.WriteLine(summa);

        }

        static int Addera(int tal1, int tal2, int tal3)
        {
            int summa = tal1 + tal2 + tal3;
            return summa;

        }

    }

}