using System.IO;
using System.Text;
using System.Xml;

namespace _09.TraversingDirectory
{
    internal class Program
    {
        public static void Main()
        {
            string directory = "D:\\Terelik-Academy\\05.Databases\\02.XML Processing in .NET'\\02.XML Processing in .NET";
            string fileName = "../../directory.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            var rootDirectory = new DirectoryInfo(directory);

            using (XmlTextWriter writer = new XmlTextWriter(fileName, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("root");
                TraverseDirectory(writer, rootDirectory);
                writer.WriteEndDocument();
            }
        }

        private static void TraverseDirectory(XmlWriter writer, DirectoryInfo directory)
        {
            foreach (var dir in directory.GetDirectories())
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", dir.Name);
                TraverseDirectory(writer, dir);
            }

            foreach (var file in directory.GetFiles())
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", file.Name);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
