using System;

namespace Kjæledyr
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til Kjeldyr Fabrikk!");

            Console.Write("Hva skal kjæledyret hete? ");
            string navn = Console.ReadLine();
            Console.Write("Hvor gammel er kjæledyret? ");
            int age = int.Parse(Console.ReadLine());

            Kjeldyr mittKjeldyr = new Kjeldyr(navn, age);

            while (true)
            {
                Console.WriteLine("\nHva vil du gjøre?");
                Console.WriteLine("1. Gi mat");
                Console.WriteLine("2. Sjekk om kjæledyret må på do");
                Console.WriteLine("3. Vis status");
                Console.WriteLine("4. Avslutt");

                string valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        mittKjeldyr.Feed();
                        break;
                    case "2":
                        mittKjeldyr.CheckToilet();
                        break;
                    case "3":
                        mittKjeldyr.ShowStatus();
                        break;
                    case "4":
                        Console.WriteLine($"Ha det bra! {navn} kommer til å savne deg!");
                        return;
                    default:
                        Console.WriteLine("Ugyldig valg. Prøv igjen.");
                        break;
                }

            }
        }
    }
