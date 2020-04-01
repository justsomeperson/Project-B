# inlog menu seconde try 
using System;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            int inloggenpoging = 0 ;
            var scherm = true;
            string wachtwoord = "";
            var gebruikersId = "";
            string gebruikersNaam = "";
            string gebruikersWachtwoord = "";
            string schermKeuze = "";
            Console.WriteLine(" voor inloggen toets (1) voor het account maken toets (2) ");
            schermKeuze = Console.ReadLine();
            while (scherm)
            {
                if (schermKeuze == "1")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Voer uw gebruikersnaam in");
                        gebruikersId = Console.ReadLine();
                        Console.WriteLine("Voer uw wachtwoord in");
                        do
                        {
                            key = Console.ReadKey(true);
                            if (key.Key != ConsoleKey.Backspace)
                            {
                                wachtwoord += key.KeyChar;
                                Console.Write("*");

                            }


                        } while (key.Key != ConsoleKey.Enter);
                        Console.WriteLine();
                        if (gebruikersId == gebruikersNaam || wachtwoord == gebruikersWachtwoord)
                        {
                            Console.WriteLine("welcome " + gebruikersNaam);
                            scherm = false;
                            break;

                        }
                        else
                        {
                            Console.WriteLine("invalid wachtwoordword or gebruikersNaam");
                            inloggenpoging++;
                        }
                    }
                    if (inloggenpoging > 2)
                    {
                        Console.WriteLine("login failure");
                    }

                }
                else if (schermKeuze == "2") { 

                    Console.WriteLine("Voer uw voornaam in \n Voornaam: ");
                    Console.ReadLine();
                Console.WriteLine(" Voer uw achter naam in \n Achternaam: ");
                Console.ReadLine();
                Console.WriteLine("Voer uw geboortedatum in \n Geboortedatum: ");
                Console.ReadLine();
                Console.WriteLine("voer uw gebruikersnaam in \n Gebruikersnaam: ");
                gebruikersNaam = Console.ReadLine();
                Console.WriteLine("Voer uw wachtwoord in \n Wachtwoord:");
                gebruikersWachtwoord = Console.ReadLine();
                    Console.WriteLine("uw account is  gemaakt");
                    schermKeuze = "1";
                }

            }
        }
    }

}
