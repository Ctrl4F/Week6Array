using System;

namespace Week6Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] predictions = { "win a million", "fall in love", "buy youtube premium ", "join the dark side" };
            //Today you will...
            Random rnd = new Random();
            int randomIndex = rnd.Next(1, predictions.Lenght);
            Console.WriteLine($"Today you will {predictions[randomIndex]}");

        }
    }
}
