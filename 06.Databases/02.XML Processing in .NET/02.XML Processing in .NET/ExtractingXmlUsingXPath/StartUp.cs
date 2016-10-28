using System;
using System.Collections;
using System.Xml;

namespace ExtractingXmlUsingXPath
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var path = "../../../../catalog.xml";

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
           
            var uniqueArtists = GetUniqueArtists(xmlDoc);

            foreach (var uniqueArtist in uniqueArtists.Keys)
            {
                Console.WriteLine($"Artist: {uniqueArtist.ToString().Trim()}\t Number of albums: {uniqueArtists[uniqueArtist]}");
            }
        }

        private static Hashtable GetUniqueArtists(XmlDocument doc)
        {
            var artistPath = "catalog/album/artist";
            XmlNodeList allArtists = doc.SelectNodes(artistPath);
            var artists = new Hashtable();

            foreach (XmlNode artistNode in allArtists)
            {
                var currentArtistName = artistNode.InnerText;

                if (!artists.ContainsKey(currentArtistName))
                {
                    artists[currentArtistName] = 1;
                }
                else
                {
                    artists[currentArtistName] = (int)artists[currentArtistName] + 1;
                }
            }

            return artists;
        }
    }
}
