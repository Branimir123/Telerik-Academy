namespace GenarateXsdSchemaAndValidateXml
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    internal class Program
    {
        private static void Main()
        {
            var schema = new XmlSchemaSet();
            var xsdPath = "../../catalog.xsd";
            var validXmlPath = "../../../../catalog.xml";
            var invalidXMLPath = "../../invalidCatalog.xml";

            schema.Add(string.Empty, xsdPath);
            XDocument correctDoc = XDocument.Load(validXmlPath);
            XDocument invalidDoc = XDocument.Load(invalidXMLPath);

            ValidateXML(schema, correctDoc);
            ValidateXML(schema, invalidDoc);
        }

        private static void ValidateXML(XmlSchemaSet schema, XDocument correctDoc)
        {
            Console.WriteLine("Validating...");
            bool hasError = false;

            correctDoc.Validate(
                schema, 
                (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                hasError = true;
            });

            Console.WriteLine("XML document {0}", hasError ? "did not validate" : "validated");
            Console.WriteLine();
        }
    }
}
