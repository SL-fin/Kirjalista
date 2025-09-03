using System.Linq.Expressions;
using System.Security.Cryptography;
using Kirjalistaohjelma;

namespace Kirjalista;

public class Kirjalista
{
    public List<Kirja> Kirjat;
    int julkaisuVuosi = 0;
    string kirjaNimi;
    string tekijanNimi;
    string? genre;
    int removed = 0;
    string answer;
    public Kirjalista()
    {

        Kirjat = new List<Kirja>();
    }

    public void LisaaKirja()
    {
        while (true)
        {
            Console.Write("Kerro kirjan nimi: ");
            kirjaNimi = Console.ReadLine();
            bool exists = false;
            foreach (var kirja in Kirjat)
            {
                if (kirja.Nimi.ToLower() == kirjaNimi.ToLower())
                {
                    Console.WriteLine("Kirja on jo listassa, haluatko aloittaa uudelleen? (K|E).");
                    answer = Console.ReadLine().ToUpper();
                    exists = true;
                    break;
                }
            }
            if (exists && answer == "K")
            {
                exists = false;
                continue;
            }
            if (exists && answer == "E")
            {
                exists = false;
                break;
            }
            if (!exists)
            {
                Console.Write("Kerro kirjan tekijän nimi: ");
                tekijanNimi = Console.ReadLine();
                Console.Write("Kerro kirjan genre: ");
                genre = Console.ReadLine();

                while (true)
                {
                    try
                    {
                        Console.Write("Kerro kirjan julkaisuvuosi: ");
                        julkaisuVuosi = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Väärä syöte, yritä uudestaan.");

                    }
                }
                Kirjat.Add(new Kirja(kirjaNimi, tekijanNimi, julkaisuVuosi, genre));
                Console.WriteLine($"Kirja '{kirjaNimi}' lisätty.");
                break;
            }
        }

    }

    public void PoistaKirja()
    {


        while (true)
        {
            Console.WriteLine("Minkä nimisen kirjan haluat poistaa?");
            string? kirjaNimi = Console.ReadLine().ToLower();


            for (int i = Kirjat.Count - 1; i >= 0; i--)
            {
                if (Kirjat[i].Nimi.ToLower() == kirjaNimi)
                {
                    Kirjat.RemoveAt(i);
                    removed++;
                }
            }

            if (removed > 0)
            {
                Console.WriteLine($"Kirja '{kirjaNimi}' poistettu ({removed} kpl).");
                break;
            }

            else
            {
                Console.WriteLine($"Kirjaa '{kirjaNimi}' ei löytynyt.");
            }

            Console.WriteLine("Haluatko jatkaa poistamisella tai lopettaa? (J|L)");
            string jatka = Console.ReadLine().ToUpper();
            if (jatka == "L")
            {
                break;
            }

        }


    }

    public void NaytaKirjat()
    {
        if (Kirjat.Count == 0)
        {
            Console.WriteLine("Ei kirjoja listassa.");
        }
        else
        {
            Console.WriteLine("Kirjat listassa:");
            foreach (var kirja in Kirjat)
            {
                Console.WriteLine(kirja.ToString());
            }
        }
    }

    public void NaytaGenre()
    {
        if (Kirjat.Count == 0)
        {
            Console.WriteLine("Ei kirjoja listassa.");
        }
        else
        {
            Console.Write("Mitä genreä etsit?: ");
            string Genre = Console.ReadLine().ToLower();
            foreach (var kirja in Kirjat)
            {
                if (Genre == kirja.Genre.ToLower())
                {
                    Console.WriteLine(kirja.ToString());
                }
            }
        }
    }

    public void NaytaOtsikko() // tai kirjailija
    {
        if (Kirjat.Count == 0)
        {
            Console.WriteLine("Ei kirjoja listassa.");
        }
        else
        {
            
            while (true)
            {
                Console.WriteLine("Haluatko etsiä otsikon tai kirjailian mukaan? (O|K)");
                string valinta = Console.ReadLine().ToUpper();
                if (valinta == "O")
                {
                    Console.Write("Mitä otsikkoa etsit?: ");
                    string Otsikko = Console.ReadLine().ToLower();
                    foreach (var kirja in Kirjat)
                    {
                        if (Otsikko == kirja.Nimi.ToLower())
                        {
                            Console.WriteLine(kirja.ToString());
                        }
                    }
                }
                else if (valinta == "K")
                {
                    Console.Write("Mitä kirjailijaa etsit?: ");
                    string Kirjailija = Console.ReadLine().ToLower();
                    foreach (var kirja in Kirjat)
                    {
                        if (Kirjailija == kirja.Tekija.ToLower())
                        {
                            Console.WriteLine(kirja.ToString());
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Virheellinen valinta, yritä uudelleen.");
                    continue;
                }
                break;
            }
        }
    }
}
