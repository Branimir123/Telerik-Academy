namespace PriceOfAllAlbumsOlderThanFiveYearsUsinLinq
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    internal class Program
    {
        private static void Main()
        {
            string path = "../../../../catalog.xml";

            XDocument doc = XDocument.Load(path);

            var prices =
                from album in doc.Descendants("album")
                where int.Parse(album.Element("year").Value) < 2010
                select new
                {
                    Price = album.Element("price").Value,
                };

            Console.WriteLine("Prices for all albums older than 5 years");
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 40)));

            foreach (var price in prices)
            {
                Console.WriteLine(nameof(price) + ": " + price.Price.Trim());
            }
        }
    }
}
