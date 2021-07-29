using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bison.Core.BE18
{
    /// <summary>
    /// This is a top-level wrapper class for the Be18 project.
    /// </summary>
    public class Project
    {
        [DllImport(@"C:\Users\l_toh\OneDrive\Skrivebord\Projects\Bison.Core\Testing\Engine\Be18Eng.dll")]
        static extern int IsLicenseValid();

        private string outputPath = @"C:\Users\l_toh\OneDrive\Skrivebord\Projects\Bison.Core\Testing\test.bexml";
        private string dllPath = @"C:\Users\l_toh\OneDrive\Skrivebord\Projects\Bison.Core\Testing\Engine\Be18Eng.dll";
        public XmlDocument xmlDocument;
        public BE05 Data;

        public Project()
        {
            // Create Xml Document
            xmlDocument = new XmlDocument();

            // Create an XML declaration.
            XmlDeclaration xmldecl = xmlDocument.CreateXmlDeclaration("1.0", null, null);
            xmldecl.Encoding = "ISO-8859-1";

            // Create Root node
            XmlElement rootNode = xmlDocument.CreateElement("BE05");
            xmlDocument.AppendChild(rootNode);
            xmlDocument.InsertBefore(xmldecl, rootNode);

            // Create defaults
            Data = new BE05();
            Data.ToXml(xmlDocument, rootNode);
        }

        public void WriteToXml()
        {
            xmlDocument.Save(outputPath);
        }

        public void RunCalculation()
        {
            int licenceValid = IsLicenseValid();
            Console.WriteLine(licenceValid);
        }
 

    }
}
