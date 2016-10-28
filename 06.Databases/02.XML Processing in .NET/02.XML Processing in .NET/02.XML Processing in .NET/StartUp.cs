using System;
using System.Collections;
using System.Xml;

namespace _02.XML_Processing_in.NET
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var path = "../../../../catalog.xml";

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            var catalogRoot = xmlDoc.DocumentElement;

            var uniqueArtists = GetUniqueArtists(catalogRoot);

            foreach (var uniqueArtist in uniqueArtists.Keys)
            {
                Console.WriteLine($"Artist: {uniqueArtist.ToString().Trim()}\t Number of albums: {uniqueArtists[uniqueArtist]}");
            }


        }

        private static Hashtable GetUniqueArtists(XmlElement xmlRootElement)
        {
            string tagName = "album";

            var uniqueArtists = new Hashtable();

            var albums = xmlRootElement.GetElementsByTagName(tagName);

            foreach (XmlNode album in albums)
            {
                var currentArtistName = album["artist"].InnerText;

                if (!uniqueArtists.ContainsKey(currentArtistName))
                {
                    uniqueArtists[currentArtistName] = 1;
                }
                else
                {
                    uniqueArtists[currentArtistName] = (int)uniqueArtists[currentArtistName] + 1;
                }
            }

            return uniqueArtists;
        }
    }
}
