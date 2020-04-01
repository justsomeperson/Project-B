using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Welkom();

        }

        public static void Welkom()
        {
            //Het Welkomst scherm waar de Admin instructies krijgt om verder te gaan
            Console.WriteLine("Welkom! Admin \n");
            Console.WriteLine("Druk op 'Enter' om de beschikbare tafels te bekijken");
            Console.ReadLine();
            Console.Clear();
            EersteScherm();
        }

        public static void EersteScherm()
        {
            // Tuple array voor Beschikbare tafels voor 4 personen
            var VierPersonen = new Tuple<string, string, int>[] {
                Tuple.Create("Tafel 1", "Vrij", 4),
                Tuple.Create("Tafel 2", "Vrij", 4),
                Tuple.Create("Tafel 3", "Vrij", 4),
                Tuple.Create("Tafel 4", "Vrij", 4),
                Tuple.Create("Tafel 5", "Vrij", 4),
                Tuple.Create("Tafel 6", "Vrij", 4),
                Tuple.Create("Tafel 7", "Vrij", 4),
                Tuple.Create("Tafel 8", "Vrij", 4),
                Tuple.Create("Tafel 9", "Vrij", 4),
                Tuple.Create("Tafel 10", "Vrij", 4)
        };
            // Tuple array voor Beschikbare tafels voor 2 personen
            var TweePersonen = new Tuple<string, string, int>[] {
                Tuple.Create("Tafel 11", "Vrij", 2),
                Tuple.Create("Tafel 12", "Vrij", 2),
                Tuple.Create("Tafel 13", "Vrij", 2),
                Tuple.Create("Tafel 14", "Vrij", 2),
                Tuple.Create("Tafel 15", "Vrij", 2)
            };

            //Tafeloverzicht
            string optie = "";
            while (true)
            {
                //Eerste scherm na Enter waar wordt gevraagd welke tafels de Admin wilt bekijken
                Console.WriteLine("Toets '4' voor de tafels voor 4 personen en '2' voor de tafels voor 2 personen");
                optie = Console.ReadLine();
                Console.Clear();
                if (optie == "4")
                {
                    for (int i = 0; i < VierPersonen.Length; i++)
                        Console.WriteLine(VierPersonen[i].Item1 + " voor 4 personen is " + VierPersonen[i].Item2);
                    Console.WriteLine("\n Om een tafel te reserveren kies dan 'J', om terug te gaan kies dan 'N'");
                    string keuze1 = Console.ReadLine().ToUpper();
                    if (keuze1 == "J")
                    {
                        Console.WriteLine("\n Kies het nummer van de tafel dat u wilt reserveren:");
                        int TafelKeuze = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        //Gelukt kleur verandering
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tafel " + TafelKeuze + " is gereserveerd! Om meer te reserveren kies dan 'J', om verder te gaan kies dan 'N'");
                        //Vierpersonen[Tafelkeuze].Item2 = "Gereserveerd" werkt niet?
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
                    }
                    else if (keuze1 == "N")
                    {
                        Console.Clear();
                        continue;
                    }


                }
                else if (optie == "2")
                {
                    for (int i = 0; i < TweePersonen.Length; i++)
                        Console.WriteLine(TweePersonen[i].Item1 + " voor 2 personen is " + TweePersonen[i].Item2);
                    Console.WriteLine("\n Om een tafel te reserveren kies dan 'J', om terug te gaan kies dan 'N'");
                    string keuze1 = Console.ReadLine().ToUpper();
                    if (keuze1 == "J")
                    {
                        Console.WriteLine("\n Kies het nummer van de tafel dat u wilt reserveren:");
                        int TafelKeuze = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        //Gelukt kleur verandering
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tafel " + TafelKeuze + " is gereserveerd! Om meer te reserveren kies dan 'J', om verder te gaan kies dan 'N'");
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

                    }
                    else if (keuze1 == "N")
                    {
                        Console.Clear();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Helaas zijn er geen tafels voor het ingevoerde aantal " + optie + ". Druk op 'Enter' om opnieuw te proberen");
                    optie = Console.ReadLine();
                    Console.Clear();
                    continue;

                }
            }
        }
    }
}
