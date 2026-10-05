using System.Security.Cryptography.X509Certificates;

namespace List_practice2;

class Program
{
    static void Main(string[] args)
    {
        List<Bok> boklista = new List<Bok>();
        Console.WriteLine("Hur många böcker vill du lägga till?");
        int antalBöcker = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < antalBöcker; i++)
        {
            Console.WriteLine("Skriv in boken namn:");
            string namn = Console.ReadLine()!;

            Console.WriteLine("Skriv in bokens författare:");
            string författare = Console.ReadLine()!;

            Console.WriteLine("Skriv in bokens publiceringsår:");
            int publiceringsår = int.Parse(Console.ReadLine()!);

            boklista.Add(new Bok(namn, författare, publiceringsår));

            
        }
        
        foreach (Bok bok in boklista)
        {
            bok.SkrivUtBokInfo();
        }
        Console.WriteLine($"Antal böcker i listan: {boklista.Count}");
        if (boklista.Count > 0)
        {
            Console.WriteLine("Sök efter en bok i listan:");
            string sökNamn = Console.ReadLine()!.ToLower();
            Bok? bokSök = boklista.Find(b => b.Namn.Equals(sökNamn, StringComparison.OrdinalIgnoreCase));

            if (bokSök != null)
            {
                bokSök.SkrivUtBokInfo();
            }
            else
            {
                Console.WriteLine("Boken hittades inte i listan.");
            }
        }
        
        
    }
}
