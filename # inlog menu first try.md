# inlog menu first try 
using System;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            int logingAtempts = 0 ;
            var choice = "";
            string pass = "";
            var userId = "";
            string userName = "";
            string userPassworde = "";
            Console.WriteLine(" login = 1  regestire = 2     Exet = 0");
            choice = Console.ReadLine();
            while (choice != "0")
            {
                if (choice == "1")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Enter your username");
                        userId = Console.ReadLine();
                        Console.WriteLine("Enter your passowerd");
                        do
                        {
                            key = Console.ReadKey(true);
                            if (key.Key != ConsoleKey.Backspace)
                            {
                                pass += key.KeyChar;
                                Console.Write("*");

                            }


                        } while (key.Key != ConsoleKey.Enter);
                        Console.WriteLine();
                        if (userId == userName || pass == userPassworde)
                        {
                            Console.WriteLine("welcome " + userName);
                            choice = "0";
                            break;

                        }
                        else
                        {
                            Console.WriteLine("invalid passworde or username");
                            logingAtempts++;
                        }
                    }
                    if (logingAtempts > 2)
                    {
                        Console.WriteLine("login failure");
                    }

                }
                else if (choice == "2") { 
                    Console.WriteLine("First Name: ");
                    Console.ReadLine();
                Console.WriteLine("last Name: ");
                Console.ReadLine();
                Console.WriteLine("Birth Date: ");
                Console.ReadLine();
                Console.WriteLine("user name: ");
                userName = Console.ReadLine();
                Console.WriteLine("New passowerd");
                userPassworde = Console.ReadLine();
                    Console.WriteLine("your acount is seccesfuly made");
                    choice = "1";
                }

            }
        }
    }

}
