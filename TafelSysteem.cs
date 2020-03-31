using System;

public class Class1
{
    public Class1()
    {
        // Beschikbare tafels voor 4 personen
        var vierpers = new Tuple<string, string, int>[] {
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
        // Beschikbare tafels voor 2 personen
        var tweepers = new Tuple<string, string, int>[] {
                Tuple.Create("Tafel 11", "Vrij", 2),
                Tuple.Create("Tafel 12", "Vrij", 2),
                Tuple.Create("Tafel 13", "Vrij", 2),
                Tuple.Create("Tafel 14", "Vrij", 2),
                Tuple.Create("Tafel 15", "Vrij", 2)
            };

        //Console.ForegroundColor = ConsoleColor.KLEUR voor andere tekstkleur Console.ResetColor(); voor reset
        Console.WriteLine("Welkom! WerknemersNaam");

        //Vraagt naar tafel
        Console.WriteLine("Kies een tafel:");

        //User input
        string input = Console.ReadLine();

        Console.WriteLine("{0} is geselecteerd. Wilt u deze reserveren?", input);

        string input2 = Console.ReadLine();

        if (input2 == "ja")
        {
            Console.WriteLine("{0} is gereseveerd!", input);
        }
        else
        {
            Console.WriteLine("Jammer! Kies een andere tafel:");
            while (input2 != "ja")
            {
                string input3 = Console.ReadLine();
                Console.WriteLine("{0} is geselecteerd. Wilt u deze reserveren?", input3);
                input2 = Console.ReadLine();
                if (input2 == "ja")
                {
                    Console.WriteLine("{0} is gereseveerd!", input3);
                }
                else
                {
                    Console.WriteLine("Jammer! Kies een andere tafel:");
                }
            }

        }
    }
}
