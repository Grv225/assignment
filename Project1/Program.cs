using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            {
                ModernAppliance modernAppliances = new ModernAppliance();

                bool exit = false;

                while (!exit)
                {
                    modernAppliances.DisplayMenu();
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            modernAppliances.Checkout();
                            break;
                        case "2":
                            modernAppliances.FindAppliancesByBrand();
                            break;
                        case "3":
                            modernAppliances.DisplayAppliancesByType();
                            break;
                        case "4":
                            modernAppliances.RandomApplianceList();
                            break;
                        case "5":
                            modernAppliances.SaveAndExit();
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }

                    if (!exit)
                    {
                        Console.WriteLine("\nPress any key to return to the main menu...");
                        Console.ReadKey();
                        Console.Clear();
                    }


                }
            }
        }
    }
}

