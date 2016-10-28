using System.Collections.Generic;
using High.Quality.Code.Task1.Bunnies.Models;
using High.Quality.Code.Task1.Bunnies.Enumerations;
using System.IO;

namespace High.Quality.Code.Task1.Bunnies
{
    public class Bunnies
    {
        static void Main(string[] args)
        {
            var bunnies = new List<Bunny>
            {
                new Bunny ("Leonid", 1, FurType.NotFluffy),
                new Bunny ("Rasputin", 2, FurType.ALittleFluffy),
                new Bunny ("Tiberii", 3, FurType.ALittleFluffy),
                new Bunny ("Neron", 1, FurType.ALittleFluffy),
                new Bunny ("Klavdii", 3, FurType.Fluffy),
                new Bunny ("Vespasian", 3, FurType.Fluffy),
                new Bunny ("Domician", 4, FurType.FluffyToTheLimit),
                new Bunny ("Tit", 2, FurType.FluffyToTheLimit)
            };

            var consoleWriter = new ConsoleWriter();

            // Introduce all bunnies
            foreach (var bunny in bunnies)
            {
                bunny.Introduce(consoleWriter);
            }

            // Create bunnies text file 
            var bunniesFilePath = @"..\..\bunnies.txt";
            var fileStream = File.Create(bunniesFilePath);
            fileStream.Close();

            // Save bunnies to a text file
            using (var streamWriter = new StreamWriter(bunniesFilePath))
            {
                foreach (var bunny in bunnies)
                {
                    streamWriter.WriteLine(bunny.ToString());
                }
            }
        }
    }
}
