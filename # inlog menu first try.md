using System;
using System.Diagnostics;
using System.Threading;

namespace Test_1
{
    public class Gebruiker
    {
        public string gebruikersNaam;
        public string gebruikersWachtwoord;
        public Gebruiker (string gebruikersNaam, string gebruikersWachtwoord)
        {
            this.gebruikersNaam = gebruikersNaam;
            this.gebruikersWachtwoord = gebruikersWachtwoord;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            int inloggenpoging = 0 ; 
            bool scherm = false;
            string wachtwoord = "";
            var gebruikersId = "";
            //string gebruikersNaam = "";
            string adminGebruikersNaam = "admin@restaurant";
            string adminWachtwoord = "1234";
            //string gebruikersWachtwoord = "";
            string schermKeuze = "";
            
            // de program begint vanaf hier en toent dit bodschap aan de user 
            Start:
            Console.WriteLine(" voor inloggen als een klant toets (1) voor het inloggen als een admin toets (2) voor het account maken toets (3)  ");
            schermKeuze = Console.ReadLine();
            
            // while loop voor de menu 
            while (!scherm)
            {
                var arrayGebruiker = new [] {
                new Gebruiker("youssef","1223")
                
                };
                
            // als de user 1 kiest dan kan hij inlogen als een klant     
                if (schermKeuze == "0") {
                    
                    Console.WriteLine(" voor inloggen als een klant toets (1) voor het inloggen als een admin toets (2) voor het account maken toets (3)  ");
                    schermKeuze = Console.ReadLine();
                    Console.Clear();
                }
            // als de schermKeuze is "1" of "2" dan komt de user bijn het inloggen 
                if (schermKeuze == "1" || schermKeuze == "2")
                {
            // for loop gebruiken om te tellen hoeveel keer heeft de user probeerd om te inloggen 
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Voer uw gebruikersnaam in");
                        gebruikersId = Console.ReadLine();
                        Console.WriteLine("Voer uw wachtwoord in");
                        // do loop dat verandert de key naar "*"  
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
                        // gaat lopen door de array en waarden vergelijken 
                        foreach (Gebruiker gebruiker in arrayGebruiker)
                        {
                            // als de waarden gelijk zijn dan is de user inggeloged 
                            if (gebruikersId == gebruiker.gebruikersNaam && wachtwoord == gebruiker.gebruikersWachtwoord)
                            {
                                Console.Clear();
                                Console.WriteLine("welcome " + gebruikersId);
                                Console.WriteLine();
                                

                                goto Start;

                            }
                            else if (adminGebruikersNaam == gebruikersId && adminWachtwoord == wachtwoord)
                            {
                                Console.WriteLine("welkom " + adminGebruikersNaam + " u bent ingelogd als administrator");
                                scherm = false;
                                break;

                            }
                            else
                            {
                                Console.WriteLine("invalid wachtwoordword or gebruikersNaam");
                                inloggenpoging++;
                            }
                        }
                        
                        
                    }
                    if (inloggenpoging > 2)
                    {
                        Console.WriteLine("login failure");
                    }

                }
                else if (schermKeuze == "3") { 
                // de gegevens van de klant vragen 
                    Console.WriteLine("Voer uw voornaam in \n Voornaam: ");
                    Console.ReadLine();
                    Console.WriteLine(" Voer uw achter naam in \n Achternaam: ");
                    Console.ReadLine();
                    Console.WriteLine("Voer uw geboortedatum in \n Geboortedatum: ");
                    Console.ReadLine();
                    Console.WriteLine("voer uw gebruikersnaam in \n Gebruikersnaam: ");
                    var gebruikersNaam = Console.ReadLine();
                    Console.WriteLine("Voer uw wachtwoord in \n Wachtwoord:");
                    var gebruikersWachtwoord = Console.ReadLine();
                    Console.WriteLine("uw account is  gemaakt");
                    
                    Array.Resize(ref arrayGebruiker, arrayGebruiker.Length + 1);
                    arrayGebruiker [arrayGebruiker.Length -1]= new Gebruiker(gebruikersNaam, gebruikersWachtwoord);
                    Console.Clear();
                    Console.WriteLine("uw account is gemaakt");
                    foreach (Gebruiker i in arrayGebruiker) { 
                    Console.WriteLine(i);
                    }
                    goto Start;
                    
                }

            }
        }
    }

}
