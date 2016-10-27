using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace _03.DeleteFromXmlDocument
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var path = "../../../../catalog.xml";

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlElement root = xmlDoc.DocumentElement;
            const int MaxPrice = 20;

            DeleteAlbums(root, MaxPrice);
            xmlDoc.Save("../../../../catalog-updated.xml");
            Console.WriteLine("Saved in catalog-updated.xml");

        }

        private static void DeleteAlbums(XmlElement root, double maxPrice)
        {
            foreach (XmlElement album in root.SelectNodes("album"))
            {
                string albumPrice = album["price"].InnerText;
                double price = double.Parse(albumPrice);

                if (maxPrice < price)
                {
                    root.RemoveChild(album);
                }
            }
        }
    }
}
