using System;
using System.Resources;

namespace WardrobePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wardrobe = {"hat", "shirt", "jeans", "hoodie", "pants"};
            string[] colors = {"green", "pink", "red", "blue", "yellow"};
            string[] patterns = { "flowery", "striped", "checked", "polka dot", "cirkles" };
            string randomCothes
                string randomWardrope
                string randomPatterns

                Random rnd = new Random();

            Console.WriteLine("would you like some fashion advice?");
            string userInput = Console.ReadLine();

            if(userInput == "no")
            {
                Console.WriteLine("Farewell");
            }
            else
            {
                Console.WriteLine($"Today, you should wear" + 
                    $"{colors[rnd.Next(0,colors.Length]}" + 
                    $"{patterns[rnd.Next(0, patterns.Length]}" + 
                    $"{wardrobe[rnd.Next(0, wardrobe.Length]}");
            }
        }
    }
}
