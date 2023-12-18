using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> szamok = new List<int>();

        Console.WriteLine("Adj meg számokat, 0 végjelig:");
        int szam;
        do
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out szam))
            {
                szamok.Add(szam);

                Console.WriteLine($"Beirt szamok: {string.Join(", ", szamok)}");
            }
            else
            {
                Console.WriteLine("Ervenytelen szam, probald ujra!");
            }
        } while (szam != 0);

    }
}
