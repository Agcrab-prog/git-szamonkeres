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

        // 4. Feladat: Minimum kiválasztás és kiírás
        int minSzam = szamok.Count > 0 ? szamok[0] : 0;
        foreach (var elem in szamok)
        {
            if (elem < minSzam)
            {
                minSzam = elem;
            }
        }
        Console.WriteLine($"A legkisebb szam: {minSzam}");


        // 5. Feladat: Maximum kiválasztás és kiírás
        int maxSzam = szamok.Count > 0 ? szamok[0] : 0;
        foreach (var elem in szamok)
        {
            if (elem > maxSzam)
            {
                maxSzam = elem;
            }
        }
        Console.WriteLine($"A legnagyobb szam: {maxSzam}");

        Console.ReadKey();
    }
}
