using System;
using System.Linq;
using System.Xml.Linq;

namespace ExtractAllSongsXDocument
{
    internal class StartUp
    {
        private static void Main()
        {
            string path = "../../../../catalog.xml";
            XDocument doc = XDocument.Load(path);

            var songs =
                from song in doc.Descendants("song")
                select new
                {
                    Title = song.Element("title").Value,
                };

            Console.WriteLine("Song titles in the catalog:");

            foreach (var song in songs)
            {
                Console.WriteLine(song.Title.Trim());
            }
        }
    }
}
