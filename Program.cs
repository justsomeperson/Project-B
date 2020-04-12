using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantMenu
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* PAGINA INDELING: 
             * 0 = Beginscherm, gebruiker kiezen tussen klant of admin
             * 
             * KLant:
             * 1 = Eten of drinken keuze
             * 2 = Soorten eten. Voor-, hoofd- en nagrecht keuze
             * 3 = Voorgerechten menu
             * 4 = Hoofdgerechten menu
             * 5 = Nagrechten menu
             * 6 = Soorten drinken. alcohol, non-alcohol en warme dranken keuze
             * 7 = Alcohol menu
             * 8 = Non-alcohol menu
             * 9 = Warme dranken menu
             * 
             * Admin:
             * 10 = Toevoegen of verwijderen keuze
             * 11 = Selecteren va
             */

            // List van menus 
            var VoorGerechten = new List<string> { "Salade", "Tomatensoep", "Stokbrood", "Uiensoep" };
            var VGInfos = new List<string> { "5,60EUR (Veggie)", "15,70EUR", "12,30EUR", "18,50EUR" };

            var HoofdGerechten = new List<string> { "Pizza", "Steak", "Vis", "Pasta" };
            var HGInfos = new List<string> { "5,60EUR (Veggie)", "15,70EUR", "12,30EUR", "18,50EUR" };

            var NaGerechten = new List<string> { "Sorbet", "Creme brulee", "Dame Blanch" };
            var NGInfos = new List<string> { "5,60EUR", "15,70EUR", "12,30EUR" };

            var AlcoholischeDranken = new List<string> { "Heineken tap", "Witte wijn", "La Chouffe" };
            var ADInfos = new List<string> { "5,60EUR", "15,70EUR", "12,30EUR" };

            var NonAlcoholischen = new List<string> { "Cola", "Spa Blauw", "Casis" };
            var NAInfos = new List<string> { "3,50EUR", "2,20EUR", "3,50EUR" };

            var WarmeDranken = new List<string> { "Koffie", "Thee", "Cappucino" };
            var WDInfos = new List<string> { "5,60EUR", "15,70EUR", "12,30EUR" };

            //pagina teller
            int pagina = 0;

            while (pagina == 0)
            {
                //INTRO TEXT
                Console.WriteLine("Bent u een klant of de Admin?");
                Console.WriteLine("Toets 'K' als u een klant bent en 'A' als u de admin bent");
                var GebruikerKeuze = Console.ReadKey();

                //
                // >>>> Admin code <<<<
                //
                if (GebruikerKeuze.KeyChar == 'a' || GebruikerKeuze.KeyChar == 'A')
                {
                    Console.WriteLine();
                    Console.WriteLine("Toets 'T' om aan het menu een item toe te voegen of toets 'V' of uit het menu een item te verwijderen ");
                    var AanpassingKeuze = Console.ReadKey();

                    // Item toevoegen code
                    if (AanpassingKeuze.KeyChar == 't' || AanpassingKeuze.KeyChar == 'T')
                    {
                        Console.WriteLine();
                        Console.WriteLine("Welk gerecht moet toegevoegd worden?");
                        var ToevoegInput = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Welke prijs en mogelijke info hoort hier bij?");
                        var InfoInput = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("U wilt het volgende toevoegen:");
                        Console.WriteLine('-' + ToevoegInput);
                        Console.WriteLine("     " + InfoInput);
                        Console.WriteLine();
                        Console.WriteLine("Y/N?");

                        var ToevoegAntwoord = Console.ReadKey();

                        if (ToevoegAntwoord.KeyChar == 'y' || ToevoegAntwoord.KeyChar == 'Y')
                        {
                            VoorGerechten.Add(ToevoegInput);
                            VGInfos.Add(InfoInput);

                            int ListLengte = VoorGerechten.Count();
                            int ListPositie = 0;

                            while (ListLengte > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine('-' + VoorGerechten[ListPositie]);
                                Console.WriteLine("     " + VGInfos[ListPositie]);

                                ListLengte--;
                                ListPositie++;
                            }
                        }
                    }

                    // Item verwijderen code
                    if (AanpassingKeuze.KeyChar == 'v' || AanpassingKeuze.KeyChar == 'V')
                    {
                        Console.WriteLine();
                        Console.WriteLine("Welk gerecht moet verwijderd worden?");
                        var VerwijderInput = Console.ReadLine();
                        int VerwijderPositie = VoorGerechten.BinarySearch(VerwijderInput);

                        Console.WriteLine();
                        Console.WriteLine("U weet zeker dat het volgende gerecht verwijderd moet worden:");
                        Console.WriteLine('-' + VoorGerechten[VerwijderPositie]);
                        Console.WriteLine("     " + VGInfos[VerwijderPositie]);
                        Console.WriteLine();
                        Console.WriteLine("Y/N?");

                        var VerwijderAntwoord = Console.ReadKey();

                        if (VerwijderAntwoord.KeyChar == 'y' || VerwijderAntwoord.KeyChar == 'Y')
                        {
                            VoorGerechten.RemoveAt(VerwijderPositie);
                            VGInfos.RemoveAt(VerwijderPositie);

                            int ListLengte = VoorGerechten.Count();
                            int ListPositie = 0;

                            while (ListLengte > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine('-' + VoorGerechten[ListPositie]);
                                Console.WriteLine("     " + VGInfos[ListPositie]);

                                ListLengte--;
                                ListPositie++;
                            }
                        }
                    }
                }

                //
                // >>> Klant code vanaf hier <<<
                //
                if (GebruikerKeuze.KeyChar == 'k' || GebruikerKeuze.KeyChar == 'K')
                {
                    // pagina 1
                    pagina += 1;
                    while (pagina == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Menu keuze:");
                        Console.WriteLine("Selecter welk menu u wilt inzien");
                        Console.WriteLine("Toets 'M' voor de Menukaart of 'D' voor de Drankkaart. Druk toets 'X' in om terug te gaan");

                        //Hier input vd user
                        var MenuKeuze = Console.ReadKey();

                        //Eerste check of de klant wilt eten
                        if (MenuKeuze.KeyChar == 'm' || MenuKeuze.KeyChar == 'M')
                        {
                            // pagina 2
                            pagina += 1;
                            while (pagina == 2)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Dit is de menukaart");
                                Console.WriteLine("Wilt u de voorgerechten, hoofdgerechten of narechten zien?");
                                Console.WriteLine("Toets 'A' voor de voorgerechten, 'B' voor de hoofdgerechten of 'C' voor nagerechten. Druk toets 'X' in om terug te gaan");

                                //Welke gerechten wilt de klant zien input
                                var EetKeuze = Console.ReadKey();

                                // Voorgerechten
                                if (EetKeuze.KeyChar == 'a' || EetKeuze.KeyChar == 'A')
                                {
                                    int ListLengte = VoorGerechten.Count();
                                    int ListPositie = 0;

                                    // pagina 3
                                    pagina += 1;
                                    while (pagina == 3)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("Dit zijn de voorgerechten");
                                                                                
                                        while (ListLengte > 0)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine('-' + VoorGerechten[ListPositie]);
                                            Console.WriteLine("     " + VGInfos[ListPositie]);                                           

                                            ListLengte--;
                                            ListPositie++;
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("Druk toets 'X' in om terug te gaan");
                                        var VGTerug = Console.ReadKey();
                                        
                                        // Terug naar vorige pagina (naar pagina 1)
                                        if (VGTerug.KeyChar == 'x' || VGTerug.KeyChar == 'X')
                                        {
                                            pagina -= 1;
                                            Console.WriteLine();
                                            Console.WriteLine();
                                        }
                                    }                                    
                                }

                                // Hoofdgerechten
                                else if (EetKeuze.KeyChar == 'b' || EetKeuze.KeyChar == 'B')
                                {
                                    int ListLengte = HoofdGerechten.Count();
                                    int ListPositie = 0;

                                    // pagina 4
                                    pagina += 2;
                                    while (pagina == 4)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("Dit zijn de hoofdgerechten");

                                        while (ListLengte > 0)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine('-' + HoofdGerechten[ListPositie]);
                                            Console.WriteLine("     " + HGInfos[ListPositie]);

                                            ListLengte--;
                                            ListPositie++;
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("Druk toets 'X' in om terug te gaan");
                                        var HGTerug = Console.ReadKey();

                                        // Terug naar vorige pagina (naar pagina 1)
                                        if (HGTerug.KeyChar == 'x' || HGTerug.KeyChar == 'X')
                                        {
                                            pagina -= 2;
                                            Console.WriteLine();
                                            Console.WriteLine();
                                        }
                                    }                                    
                                }

                                // Nagerechten
                                else if (EetKeuze.KeyChar == 'c' || EetKeuze.KeyChar == 'C')
                                {
                                    int ListLengte = NaGerechten.Count();
                                    int ListPositie = 0;

                                    // pagina 5
                                    pagina += 3;
                                    while (pagina == 5)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("Dit zijn de nagerechten");

                                        while (ListLengte > 0)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine('-' + NaGerechten[ListPositie]);
                                            Console.WriteLine("     " + NGInfos[ListPositie]);

                                            ListLengte--;
                                            ListPositie++;
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("Druk toets 'X' in om terug te gaan");
                                        var NGTerug = Console.ReadKey();

                                        // Terug naar vorige pagina (naar pagina 1)
                                        if (NGTerug.KeyChar == 'x' || NGTerug.KeyChar == 'X')
                                        {
                                            pagina -= 3;
                                            Console.WriteLine();
                                            Console.WriteLine();
                                        }
                                    }                                   
                                }

                                // Terug naar vorige pagina (naar pagina 1)
                                else if (EetKeuze.KeyChar == 'x' || EetKeuze.KeyChar == 'X')
                                {
                                    pagina -= 1;
                                    Console.WriteLine();
                                    Console.WriteLine();
                                }
                            }                            
                        }

                        //Anders wilt de klant drinken
                        else if  (MenuKeuze.KeyChar == 'd' || MenuKeuze.KeyChar == 'D')
                        {
                            // pagina 6
                            pagina += 5;
                            while (pagina == 6)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Dit is de drankkaart");
                                Console.WriteLine("Wilt u alcoholische, non-alcoholische of warme dranken zien?");
                                Console.WriteLine("Toets 'A' voor alcoholische dranken, 'B' voor non-alcoholische dranken of 'C' voor warme dranken. Druk toets 'X' in om terug te gaan");

                                //Welke gerechten wilt de klant zien input
                                var DrankKeuze = Console.ReadKey();

                                // Alcoholische dranken
                                if (DrankKeuze.KeyChar == 'a' || DrankKeuze.KeyChar == 'A')
                                {
                                    int ListLengte = AlcoholischeDranken.Count();
                                    int ListPositie = 0;

                                    // pagina 7
                                    pagina += 1;
                                    while (pagina == 7)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("Dit zijn de alcoholische dranken");

                                        while (ListLengte > 0)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine('-' + AlcoholischeDranken[ListPositie]);
                                            Console.WriteLine("     " + ADInfos[ListPositie]);

                                            ListLengte--;
                                            ListPositie++;
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("Druk toets 'X' in om terug te gaan");
                                        var ADTerug = Console.ReadKey();

                                        // Terug naar vorige pagina (naar pagina 6)
                                        if (ADTerug.KeyChar == 'x' || ADTerug.KeyChar == 'X')
                                        {
                                            pagina -= 1;
                                            Console.WriteLine();
                                            Console.WriteLine();
                                        }
                                    }                                    
                                }

                                // Non-Alcoholische dranken
                                else if (DrankKeuze.KeyChar == 'b' || DrankKeuze.KeyChar == 'B')
                                {
                                    int ListLengte = NonAlcoholischen.Count();
                                    int ListPositie = 0;

                                    // pagina 8
                                    pagina += 2;
                                    while (pagina == 8)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("Dit zijn de non-alcoholsche dranken");

                                        while (ListLengte > 0)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine('-' + NonAlcoholischen[ListPositie]);
                                            Console.WriteLine("     " + NAInfos[ListPositie]);

                                            ListLengte--;
                                            ListPositie++;
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("Druk toets 'X' in om terug te gaan");
                                        var NATerug = Console.ReadKey();

                                        // Terug naar vorige pagina (naar pagina 6)
                                        if (NATerug.KeyChar == 'x' || NATerug.KeyChar == 'X')
                                        {
                                            pagina -= 2;
                                            Console.WriteLine();
                                            Console.WriteLine();
                                        }
                                    }
                                }

                                // Warme dranken
                                else if (DrankKeuze.KeyChar == 'c' || DrankKeuze.KeyChar == 'C')
                                {
                                    int ListLengte = WarmeDranken.Count();
                                    int ListPositie = 0;

                                    // pagina 9
                                    pagina += 3;
                                    while (pagina == 9)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("Dit zijn de warme dranken");

                                        while (ListLengte > 0)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine('-' + WarmeDranken[ListPositie]);
                                            Console.WriteLine("     " + WDInfos[ListPositie]);

                                            ListLengte--;
                                            ListPositie++;
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("Druk toets 'X' in om terug te gaan");
                                        var WDTerug = Console.ReadKey();

                                        // Terug naar vorige pagina (naar pagina 6)
                                        if (WDTerug.KeyChar == 'x' || WDTerug.KeyChar == 'X')
                                        {
                                            pagina -= 3;
                                            Console.WriteLine();
                                            Console.WriteLine();
                                        }
                                    }                                    
                                }
                                 // Terug naar vorige pagina (naar pagina 1)
                                else if (DrankKeuze.KeyChar == 'x' || DrankKeuze.KeyChar == 'X')
                                {
                                    pagina -= 5;
                                    Console.WriteLine();
                                    Console.WriteLine();
                                }
                            }                                                        
                        }
                        
                        // Terug naar vorige pagina (naar pagina 0)
                        else if (MenuKeuze.KeyChar == 'x' || MenuKeuze.KeyChar == 'X')
                        {
                            pagina -= 1;
                            Console.WriteLine();
                            Console.WriteLine();

                        }
                    }
                    
                }
            }
            
        }
    }
}
