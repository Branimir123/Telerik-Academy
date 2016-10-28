using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _07.CreateXmlFromCatalog
{
    internal class StartUp
    {
        private static void Main()
        {
            string path = "../../../../catalog.xml";
            string fileName = "../../updated-catalog.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");

            using (XmlTextWriter writer = new XmlTextWriter(fileName, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("update-catalog");
                writer.WriteAttributeString("name", "update catalog");

                using (XmlReader reader = XmlReader.Create(path))
                {
                    while (reader.Read())
                    {
                        if ((reader.NodeType == XmlNodeType.Element) &&
                            (reader.Name == "name"))
                        {
                            writer.WriteStartElement("album");
                            writer.WriteElementString("name", reader.ReadElementString().Trim());
                        }
                        else if ((reader.NodeType == XmlNodeType.Element) &&
                           (reader.Name == "artist"))
                        {
                            writer.WriteElementString("artist", reader.ReadElementString().Trim());
                        }
                    }
                }

                writer.WriteEndDocument();
                Console.WriteLine($"Saved in {fileName}");
            }
        }
    }
}
