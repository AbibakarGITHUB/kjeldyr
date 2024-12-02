using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class methods
    {

        public void Feed()
        {
            if (needsFood)
            {
                Console.WriteLine($"{navn} spiser mat og er nå fornøyd!");
                needsFood = false;
                needsToilet = true;
            }
            else
            {
                Console.WriteLine($"{navn} er allerede mett!");
            }
        }

        public void CheckToilet()
        {
            if (needsToilet)
            {
                Console.WriteLine($"{navn} må på do!");
                needsToilet = false;
            }
            else
            {
                Console.WriteLine($"{navn} trenger ikke på do nå.");
            }
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Navn: {navn}, Alder: {age}, Sulten: {needsFood}, Må på do: {needsToilet}");
        }
    }

}
}
