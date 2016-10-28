using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace _04.ExtractAllSongsXPath
{
    internal class StartUp
    {
        private static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Song titles in the catalog:");
            Console.WriteLine(string.Concat(Enumerable.Repeat("*", 40)));

            string path = "../../../../catalog.xml";
            using (XmlReader reader = XmlReader.Create(path))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString().Trim());
                    }
                }
            }

            Console.WriteLine(string.Concat(Enumerable.Repeat("*", 40)));
        }
    }
}
