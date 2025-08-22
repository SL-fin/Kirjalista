namespace Kirjalistaohjelma
{
    public class Kirja
    {
        public string Nimi { get; set; }
        public string Tekija { get; set; }
        public int Julkaisuvuosi { get; set; }
        public string Genre { get; set; }

        public Kirja(string nimi, string tekija, int julkaisuvuosi, string genre)
        {
            Nimi = nimi;
            Tekija = tekija;
            Julkaisuvuosi = julkaisuvuosi;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{Nimi} - {Tekija} - {Genre}, Julkaistu vuonna {Julkaisuvuosi}";
        }
    }


}