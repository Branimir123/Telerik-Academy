namespace TrversingDirestoryUsingLinqToXml
{
    using System.IO;
    using System.Xml.Linq;

    internal class StartUp
    {
        private static void Main()
        {
            string directory = "D:\\Terelik-Academy\\05.Databases\\02.XML Processing in .NET'\\02.XML Processing in .NET";
            string fileName = "../../directoryLinqToXml.xml";
            var rootDirectory = new DirectoryInfo(directory);
            string rootString = "root";

            XElement directoryTree = new XElement(rootString);
            directoryTree.Add(TraverseDirectory(rootDirectory));
            directoryTree.Save(fileName);
        }

        private static XElement TraverseDirectory(DirectoryInfo directory)
        {
            string dirString = "dir";
            string nameString = "name";
            var dirElement = new XElement(dirString, new XAttribute(nameString, directory.Name));
            foreach (var dir in directory.GetDirectories())
            {
                dirElement.Add(TraverseDirectory(dir));
            }

            string fileString = "file";
         
            foreach (var file in directory.GetFiles())
            {
                dirElement.Add(new XElement(fileString, new XAttribute(nameString, file.Name)));
            }

            return dirElement;
        }
    }
}
