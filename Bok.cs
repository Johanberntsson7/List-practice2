namespace List_practice2;

public class Bok
{
    public string Namn { get; set;}

    public string Författare { get; set;}

    public int Publiceringsår { get; set;}

    public Bok (string namn, string författare, int publiceringsår)
    {
        Namn = namn;
        Författare = författare;
        Publiceringsår = publiceringsår;
    }
    public void SkrivUtBokInfo()
    {
        Console.WriteLine($"Bokens namn: {Namn}");
        Console.WriteLine($"Författare: {Författare}");
        Console.WriteLine($"publiceringår: {Publiceringsår}");
    }
}