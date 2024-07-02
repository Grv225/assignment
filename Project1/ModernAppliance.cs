using Project1.ProblemDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class ModernAppliance
    {
        private List<Appliance> appliances;
        private const string APPLIANCES_FILE = "appliances.txt";

        public ModernAppliance()
        {
            appliances = new List<Appliance>();
            ReadAppliances();
        }

        private void ReadAppliances()
        {
            string[] lines = System.IO.File.ReadAllLines(APPLIANCES_FILE);
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                string itemNumber = parts[0];
                Appliance appliance = CreateApplianceFromParts(parts);
                if (appliance != null)
                {
                    appliances.Add(appliance);
                }
            }
        }

        private Appliance CreateApplianceFromParts(string[] parts)
        {
            string itemNumber = parts[0];
            string brand = parts[1];
            int quantity = int.Parse(parts[2]);
            int wattage = int.Parse(parts[3]);
            string color = parts[4];
            double price = double.Parse(parts[5]);

            switch (itemNumber[0])
            {
                case '1':
                    int doors = int.Parse(parts[6]);
                    int height = int.Parse(parts[7]);
                    int width = int.Parse(parts[8]);
                    return new Refrigerator(itemNumber, brand, quantity, wattage, color, price, doors, height, width);
                case '2':
                    string grade = parts[6];
                    int batteryVoltage = int.Parse(parts[7]);
                    return new Vacuum(itemNumber, brand, quantity, wattage, color, price, grade, batteryVoltage);
                case '3':
                    double capacity = double.Parse(parts[6]);
                    string roomType = parts[7];
                    return new Microwave(itemNumber, brand, quantity, wattage, color, price, capacity, roomType);
                case '4':
                case '5':
                    string feature = parts[6];
                    string soundRating = parts[7];
                    return new Dishwasher(itemNumber, brand, quantity, wattage, color, price, feature, soundRating);
                default:
                    return null;
            }
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to Modern Appliances!");
            Console.WriteLine("How May We Assist You?");
            Console.WriteLine("1 – Check out appliance");
            Console.WriteLine("2 – Find appliances by brand");
            Console.WriteLine("3 – Display appliances by type");
            Console.WriteLine("4 – Produce random appliance list");
            Console.WriteLine("5 – Save & exit");
            Console.Write("Enter option: ");
        }

        public void Checkout()
        {
            Console.Write("Enter the item number of an appliance: ");
            string itemNumber = Console.ReadLine();
            Appliance appliance = appliances.FirstOrDefault(a => a.ItemNumber == itemNumber);

            if (appliance == null)
            {
                Console.WriteLine("No appliances found with that item number.");
            }
            else if (appliance.Quantity > 0)
            {
                appliance.Quantity--;
                Console.WriteLine($"Appliance \"{itemNumber}\" has been checked out.");
            }
            else
            {
                Console.WriteLine("The appliance is not available to be checked out.");
            }
        }

        public void FindAppliancesByBrand()
        {
            Console.Write("Enter brand to search for: ");
            string brand = Console.ReadLine();
            var matchingAppliances = appliances.Where(a => a.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)).ToList();

            if (matchingAppliances.Any())
            {
                Console.WriteLine("Matching Appliances:");
                foreach (var appliance in matchingAppliances)
                {
                    Console.WriteLine(appliance);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No matching appliances found.");
            }
        }

        public void DisplayAppliancesByType()
        {
            Console.WriteLine("Appliance Types");
            Console.WriteLine("1 – Refrigerators");
            Console.WriteLine("2 – Vacuums");
            Console.WriteLine("3 – Microwaves");
            Console.WriteLine("4 – Dishwashers");
            Console.Write("Enter type of appliance: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayRefrigerators();
                    break;
                case "2":
                    DisplayVacuums();
                    break;
                case "3":
                    DisplayMicrowaves();
                    break;
                case "4":
                    DisplayDishwashers();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        private void DisplayRefrigerators()
        {
            Console.Write("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors): ");
            int doors = int.Parse(Console.ReadLine());
            var matchingRefrigerators = appliances.OfType<Refrigerator>().Where(r => r.Doors == doors).ToList();

            if (matchingRefrigerators.Any())
            {
                Console.WriteLine("Matching refrigerators:");
                foreach (var refrigerator in matchingRefrigerators)
                {
                    Console.WriteLine(refrigerator);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No matching refrigerators found.");
            }
        }

        private void DisplayVacuums()
        {
            Console.Write("Enter battery voltage value. 18 V (low) or 24 V (high): ");
            int voltage = int.Parse(Console.ReadLine());
            var matchingVacuums = appliances.OfType<Vacuum>().Where(v => v.BatteryVoltage == voltage).ToList();

            if (matchingVacuums.Any())
            {
                Console.WriteLine("Matching vacuums:");
                foreach (var vacuum in matchingVacuums)
                {
                    Console.WriteLine(vacuum);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No matching vacuums found.");
            }
        }

        private void DisplayMicrowaves()
        {
            Console.Write("Room where the microwave will be installed: K (kitchen) or W (work site): ");
            string roomType = Console.ReadLine().ToUpper();
            var matchingMicrowaves = appliances.OfType<Microwave>().Where(m => m.RoomType.StartsWith(roomType)).ToList();

            if (matchingMicrowaves.Any())
            {
                Console.WriteLine("Matching microwaves:");
                foreach (var microwave in matchingMicrowaves)
                {
                    Console.WriteLine(microwave);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No matching microwaves found.");
            }
        }

        private void DisplayDishwashers()
        {
            Console.Write("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu (Quiet) or M (Moderate): ");
            string soundRating = Console.ReadLine().ToUpper();
            var matchingDishwashers = appliances.OfType<Dishwasher>().Where(d => d.SoundRating.StartsWith(soundRating)).ToList();

            if (matchingDishwashers.Any())
            {
                Console.WriteLine("Matching dishwashers:");
                foreach (var dishwasher in matchingDishwashers)
                {
                    Console.WriteLine(dishwasher);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No matching dishwashers found.");
            }
        }

        public void RandomApplianceList()
        {
            Console.Write("Enter number of appliances: ");
            int count = int.Parse(Console.ReadLine());
            Random random = new Random();
            var randomAppliances = appliances.OrderBy(x => random.Next()).Take(count).ToList();

            Console.WriteLine("Random appliances:");
            foreach (var appliance in randomAppliances)
            {
                Console.WriteLine(appliance);
                Console.WriteLine();
            }
        }

        public void SaveAndExit()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(APPLIANCES_FILE))
            {
                foreach (Appliance appliance in appliances)
                {
                    file.WriteLine(appliance.FormatForFile());
                }
            }
            Console.WriteLine("Appliances saved to file. Exiting program.");
        }
    }
}

