namespace Kirjalista;


public class UI
{
    public static void ShowMainMenu()
    {
         Kirjalista kirjalista = new Kirjalista();
        bool continueLoop = false;

        while (true)
        {

            Console.WriteLine("Haluatko Lisätä kirjan |L|, poistaa kirjan |P|, näyttää kaikki kirjat |N| näytetään kirjat genren mukaan |G| etsiä kirja kirjoittajan tai otsikon mukaan |E|?");
            string? valinta = Console.ReadLine()?.ToUpper();

            switch (valinta)
            {
                case "L":
                    kirjalista.LisaaKirja();
                    break;
                case "P":
                    kirjalista.PoistaKirja();
                    break;
                case "N":
                    kirjalista.NaytaKirjat();
                    break;
                case "G":
                    kirjalista.NaytaGenre();
                    break;
                case "E":
                    kirjalista.NaytaOtsikko();
                    break;
            }





            while (!continueLoop)
            {
                Console.WriteLine("Haluatko jatkaa (takaisin alkuun)? (K|E)");
                string? Continue = Console.ReadLine()?.ToUpper();
                if (Continue == "E")
                {
                    continueLoop = true;
                    break;
                }
                if (Continue != "K" && Continue != "E")
                {
                    Console.WriteLine("Väärä syöte, yritä uudestaan.");
                    continueLoop = false;
                    continue;

                }
                else
                {
                    continueLoop = false;
                    break;

                }
            }
            if (continueLoop)
            {
                break;
            } 
        } 
    }
}