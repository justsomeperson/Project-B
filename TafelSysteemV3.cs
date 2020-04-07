using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WelkomTafel();

        }

        public static void WelkomTafel()
        {
            //Het Welkomst scherm waar de Admin instructies krijgt om verder te gaan
            Console.WriteLine("Welkom! Admin \n");
            Console.WriteLine("Druk op 'Enter' om de beschikbare tafels te bekijken");
            Console.ReadLine();
            Console.Clear();
            TafelScherm();
        }

        public static void TafelScherm()
        {
            // List voor Beschikbare tafels voor 4 personen
            List<string> VrijeTafels4 = new List<string>();
            VrijeTafels4.Add("Tafel 1 voor 4");
            VrijeTafels4.Add("Tafel 2 voor 4");
            VrijeTafels4.Add("Tafel 3 voor 4");
            VrijeTafels4.Add("Tafel 4 voor 4");
            VrijeTafels4.Add("Tafel 5 voor 4");
            VrijeTafels4.Add("Tafel 6 voor 4");
            VrijeTafels4.Add("Tafel 7 voor 4");
            VrijeTafels4.Add("Tafel 8 voor 4");
            VrijeTafels4.Add("Tafel 9 voor 4");
            VrijeTafels4.Add("Tafel 10 voor 4");

            List<string> VrijeTafels2 = new List<string>();
            VrijeTafels2.Add("Tafel 11 voor 2");
            VrijeTafels2.Add("Tafel 12 voor 2");
            VrijeTafels2.Add("Tafel 13 voor 2");
            VrijeTafels2.Add("Tafel 14 voor 2");
            VrijeTafels2.Add("Tafel 15 voor 2");

            List<string> GereserveerdeTafels = new List<string>();
            GereserveerdeTafels.Add("Deze tafels zijn gereserveerd:");

            //Tafeloverzicht
            string optie = "";
            while (true)
            {
                //Eerste scherm na Enter waar wordt gevraagd welke tafels de Admin wilt bekijken
                Console.WriteLine("Tafels voor twee: '2', Tafels voor vier: '4', Status van de gereserveerde tafels: 's'");
                optie = Console.ReadLine();
                Console.Clear();
                if (optie == "4")
                {
                    for (int i = 0; i < VrijeTafels4.Count; i++)
                        Console.WriteLine(i + 1 + " - " + VrijeTafels4[i] + " is vrij");
                    Console.WriteLine("\n Om een tafel te reserveren kies dan 'J', om terug te gaan kies dan 'N'");
                    string keuze1 = Console.ReadLine().ToUpper();
                    if (keuze1 == "J")
                    {
                        Console.WriteLine("\n Toets de rij van de gewenste tafel van de bovenstaande lijst in om hem te reserveren");
                        int TafelKeuze = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        //Gelukt kleur verandering
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("De tafel is gereserveerd! Om meer te reserveren of de status te bekijken kies dan 'J', om verder te gaan kies dan 'N'");
                        GereserveerdeTafels.Add(VrijeTafels4[TafelKeuze - 1] + " is gereserveerd voor Meneer/Mevrouw ACHTERNAAM + RESERVERINGSNUMMER op DATUM + TIJD");
                        VrijeTafels4.RemoveAt(TafelKeuze - 1);
                        Console.ResetColor();
                        string keuze2 = Console.ReadLine().ToUpper();
                        if (keuze2 == "J")
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (keuze2 == "N")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Helaas is de ingevoerde opdracht niet herkend. Druk op 'Enter' om opnieuw te proberen");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                    }
                    else if (keuze1 == "N")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Helaas is de ingevoerde opdracht niet herkend. Druk op 'Enter' om opnieuw te proberen");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                }
                else if (optie == "2")
                {
                    for (int i = 0; i < VrijeTafels2.Count; i++)
                        Console.WriteLine(i + 1 + " - " + VrijeTafels2[i]);
                    Console.WriteLine("\n Om een tafel te reserveren kies dan 'J', om terug te gaan kies dan 'N'");
                    string keuze1 = Console.ReadLine().ToUpper();
                    if (keuze1 == "J")
                    {
                        Console.WriteLine("\n Toets de rij van de gewenste tafel van de bovenstaande lijst in om hem te reserveren");
                        int TafelKeuze = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        //Gelukt kleur verandering
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("De tafel is gereserveerd! Om meer te reserveren of de status te bekijken kies dan 'J', om verder te gaan kies dan 'N'");
                        GereserveerdeTafels.Add(VrijeTafels2[TafelKeuze - 1] + " is gereserveerd voor Meneer/Mevrouw ACHTERNAAM + RESERVERINGSNUMMER op DATUM + TIJD");
                        VrijeTafels2.RemoveAt(TafelKeuze - 1);
                        Console.ResetColor();
                        string keuze2 = Console.ReadLine().ToUpper();
                        if (keuze2 == "J")
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (keuze2 == "N")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Helaas is de ingevoerde opdracht niet herkend. Druk op 'Enter' om opnieuw te proberen");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }

                    }
                    else if (keuze1 == "N")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Helaas is de ingevoerde opdracht niet herkend. Druk op 'Enter' om opnieuw te proberen");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                }
                //Status van gereserveerde tafels
                else if (optie == "s")
                {
                    for (int i = 0; i < GereserveerdeTafels.Count; i++)
                        Console.WriteLine(GereserveerdeTafels[i]);
                    Console.WriteLine("\n Druk op 'Enter' om terug te gaan");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                //Foutmelding bij intoetsen verkeerde opdracht
                else
                {
                    Console.WriteLine("Helaas is de ingevoerde opdracht niet herkend. Druk op 'Enter' om opnieuw te proberen");
                    optie = Console.ReadLine();
                    Console.Clear();
                    continue;

                }
            }
        }
    }
}
