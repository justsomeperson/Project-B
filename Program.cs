using System;

namespace PRojectBstart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer je reserveringsnummer in");
            string ingevoerde_nummer = Console.ReadLine();

            Console.WriteLine("Voer je naam in");
            string ingevoerde_naam = Console.ReadLine();


            bool is_nummer_correct = ingevoerde_nummer == "0001";
            bool is_naam_correct = ingevoerde_naam == "Ahmed";

            if (is_nummer_correct && is_naam_correct){
                Console.WriteLine("Welkom Ahmed");
            } else
            {
                Console.WriteLine("Reserveringsnummer of naam is incorrect");
            }


            Console.ReadLine();
        }
    }
}
