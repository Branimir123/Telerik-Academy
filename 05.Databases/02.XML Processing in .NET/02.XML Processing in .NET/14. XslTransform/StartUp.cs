namespace XslTransform
{
    using System.Xml.Xsl;

    internal class Program
    {
        private static void Main()
        {
            var xslt = new XslCompiledTransform();
            var xmlPath = "../../../catalog.xml";
            var xslPath = "../../../catalogStyle.xslt";
            var htmlFile = "../../catalog.html";

            xslt.Load(xslPath);
            xslt.Transform(xmlPath, htmlFile);
        }
    }
}
