namespace PriceOfAlbumsOlderThanFiveYears
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Threading;
    using System.Xml;

    internal class StartUp
    {
        private static void Main()
        {
            string path = "../../../../catalog.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            string xPathQuery = "catalog/album[year<2010]/price";

            Console.WriteLine("Prices for all albums older than 5 years");
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 40)));

            var prices = doc.SelectNodes(xPathQuery);
            foreach (XmlNode price in prices)
            {
                Console.WriteLine(nameof(price) + ": " + price.InnerText);
            }
        }
    }
}
