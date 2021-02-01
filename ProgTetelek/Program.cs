using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        static void Összegzés()
        {
            int[] szamok = { 5, 6, 8, 9, 1, };
            int sum = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                sum += szamok[i];
            }
            Console.WriteLine("Az összeg: " + sum);
        }

        static void Maximum()
        {
            int[] szamok = { 2, 21, 8, 17, 67, };
            int max = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] > max)
                {
                    max = szamok[i];
                }
            }
            Console.WriteLine("A legnagyobb szám: " + max);
        }

        static void Main(string[] args)
        {
            //Összegzés tétele

            Összegzés();

            //Maximum kiválasztás

            Maximum();
        }
    }
}
