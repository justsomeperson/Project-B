using System;
using System.Collections.Generic;
using System.Threading;

namespace LearnModule
{
    class Klant
    {
        public Klant() { }

        public string voorNaam { get; set; }
        public string achterNaam { get; set; }
        public int telefoonNummer { get; set; }
        public int xPersonen { get; set; }
        public string tijdReservatie { get; set; }
        public string datumReservatie { get; set; }
        public string opmerkingKlant { get; set; }
        public int reserveringsNummer { get; set; }

        public Klant(string voornaam, string achternaam, int telefoonnummer, int xpersonen, string datumreservatie,
                        string tijdreservatie, string opmerkingklant, int reserveringsnummer)
        {
            voorNaam = voornaam;
            achterNaam = achternaam;
            telefoonNummer = telefoonnummer;
            xPersonen = xpersonen;
            datumReservatie = datumreservatie;
            tijdReservatie = tijdreservatie;
            opmerkingKlant = opmerkingklant;
            reserveringsNummer = reserveringsnummer;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            List<Klant> reserveringen = new List<Klant>();
            
            Klant res = new Klant();

            while (!exit)
            {
                Console.WriteLine("Wilt u een reservering maken of bekijken? Vul in: Maken of Bekijken");
                string answer = Console.ReadLine().ToLower(); ;

                if (answer == "maken")
                {
                    Console.WriteLine();
                    Console.WriteLine("Vul uw gegevens in");
                    Console.WriteLine();
                    Klant klant = maakReservatie();
                    if (klant != null)
                    {
                        reserveringen.Add(klant);
                    }
                    Thread.Sleep(2000);
                }
                else if (answer == "bekijken")
                {
                    Console.WriteLine("Vul uw reserveringsnummer in:");
                    string input = Console.ReadLine();
                    




                }
                    
                else if (answer != "maken" && answer != "bekijken")
                    Console.WriteLine("Vul alstublieft Maken of Bekijken in:");
                else
                    exit = true;


                Console.Clear();
                /*Console.WriteLine("Dit zijn uw reserveringen");*/
                for (int i = 0; i < reserveringen.Count; i++)
                {
                    Console.WriteLine("Voornaam: " + reserveringen[i].voorNaam);
                    Console.WriteLine("Achternaam: " + reserveringen[i].achterNaam);
                    Console.WriteLine("Telefoonnummer: " + reserveringen[i].telefoonNummer);
                    Console.WriteLine("Aantal personen: " + reserveringen[i].xPersonen);
                    Console.WriteLine("Datum: " + reserveringen[i].datumReservatie);
                    Console.WriteLine("Tijd: " + reserveringen[i].tijdReservatie);
                    Console.WriteLine("Uw opmerkingen: " + reserveringen[i].opmerkingKlant);
                    Console.WriteLine("Uw reserveringsnummer: " + reserveringen[i].reserveringsNummer);

                    Console.WriteLine();
                    Console.WriteLine();
                }
            }

            static Klant maakReservatie()
            {
                Random random = new Random();
                Klant res = new Klant();

                Console.WriteLine("Voornaam:");
                res.voorNaam = Console.ReadLine();
                Console.WriteLine("Achternaam:");
                res.achterNaam = Console.ReadLine();
                Console.WriteLine("Telefoonnummer:");
                res.telefoonNummer = int.Parse(Console.ReadLine());
                Console.WriteLine("Aantal personen:");
                res.xPersonen = int.Parse(Console.ReadLine());
                if (res.xPersonen < 21)
                {
                    Console.WriteLine("Datum:");
                    res.datumReservatie = Console.ReadLine();
                    Console.WriteLine("Tijd: ");
                    res.tijdReservatie = Console.ReadLine();
                    res.reserveringsNummer = random.Next(10000);
                    Console.WriteLine("Opmerkingen:");
                    res.opmerkingKlant = Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.WriteLine($"Uw reservering is gelukt! Uw reserveringsnummer is {res.reserveringsNummer}.");
                    return res;
                }
                else
                {
                    Console.WriteLine("Voor reserveringen met meer dan 20 personen gelieve bellen naar de zaak.");
                    Thread.Sleep(3000);
                    Console.WriteLine("Druk op enter");
                    Console.ReadLine();
                    return null;
                }
            }
        }
    }
}