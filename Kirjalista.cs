using System.Security.Cryptography;
using Kirjalistaohjelma;

namespace Kirjalista;

public class Kirjalista
{
    public List<Kirja> Kirjat;
    public Kirjalista()
    {
        Kirjat = new List<Kirja>();
    }

    public void LisaaKirja()
    {
        Console.Write("Kerro kirjan nimi: ");
        string? kirjaNimi = Console.ReadLine();
        Console.Write("Kerro kirjan tekijän nimi: ");
        string? tekijanNimi = Console.ReadLine();
        Console.Write("Kerro kirjan genre: ");
        string? genre = Console.ReadLine();
        Console.Write("Kerro kirjan julkaisuvuosi: ");
        int julkaisuVuosi = Convert.ToInt32(Console.ReadLine());
        Kirjat.Add(new Kirja(kirjaNimi, tekijanNimi, julkaisuVuosi, genre));
    }


}