using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using System.Globalization;
using System.Threading;
using Bison.Core.BE18.Elements;

namespace Bison.Core.BE18
{
    /// <summary>
    /// This is a top-level wrapper class for the Be18 project.
    /// </summary>
    public class Project
    {
        // Use kernel32 to import SetDllDirectory method
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool SetDllDirectory(string lpPathName);

        // File locations
        private string OutputPath { get; set; } // Path to output .bexml file
        private string Be18Folder { get; set; } // Path to folder that includes the Be18Eng.dll file

        // Data
        public XmlDocument xmlDocument;
        public BE05 Data;
        public Building Building { get; set; } // Direct accessor to building

        public Project(string outputPath, string Be18Folder)
        {
            // Apply en-US to render numeric values with dot instead of comma
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            // Add the Be18 engine dll
            SetDllDirectory(Be18Folder);

            // Create defaults
            Data = new BE05();
            Building = Data.Building;

            // Set values
            this.OutputPath = outputPath;
            this.Be18Folder = Be18Folder;
        }

        // Check if dll can be found
        public void LoadEngine(string dllFolder)
        {
            if (!Directory.Exists(dllFolder))
            {
                throw new InvalidOperationException("Unable to locate Be18 file");
            }
            return;
        }

        public void WriteToXml()
        {
            // Create Xml Document
            xmlDocument = new XmlDocument();
            XmlDeclaration xmldecl = xmlDocument.CreateXmlDeclaration("1.0", null, null);
            xmldecl.Encoding = "ISO-8859-1";

            // Create Root node
            XmlElement rootNode = xmlDocument.CreateElement("BE05");
            xmlDocument.AppendChild(rootNode);
            xmlDocument.InsertBefore(xmldecl, rootNode);

            Data.ToXml(xmlDocument, xmlDocument.DocumentElement);
            xmlDocument.Save(OutputPath);
        }

        // Load functions from Be18
        [DllImport("Be18Eng.dll")]
        static extern int IsLicenseValid();
        [DllImport("Be18Eng.dll")]
        static extern int Be06Keys(StringBuilder buffer, StringBuilder memory, ref int status, int uk);

        public void RunCalculation()
        {
            LoadEngine(Be18Folder);
            int licenceValid = IsLicenseValid();

            // Read XML file
            Data.ToXml(xmlDocument, xmlDocument.DocumentElement);
            string projectData = xmlDocument.OuterXml;

            int bufferSize = 100000;
            StringBuilder modelStringBuffer = new StringBuilder(projectData, bufferSize);
            StringBuilder mem = new StringBuilder(bufferSize);
            int status = bufferSize;

            int res = Be06Keys(modelStringBuffer, mem, ref status, 1);
            Console.WriteLine(mem);
        }
    }
}
