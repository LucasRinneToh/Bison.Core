using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Runtime;
using System.Globalization;
using System.Threading;

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

        private string OutputPath { get; set; } // Path to output .bexml file
        private string Be18Folder { get; set; } // Path to folder that includes the Be18Eng.dll file
        
        public XmlDocument xmlDocument;
        public BE05 Data;
        public Building Building { get; set; } // Direct accessor to building

        public Project(string outputPath, string Be18Folder)
        {
            // Apply en-US to render numeric values with dot instead of comma
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            // Add the Be18 engine dll
            SetDllDirectory(Be18Folder);

            this.OutputPath = outputPath;
            this.Be18Folder = Be18Folder;

            // Create Xml Document
            xmlDocument = new XmlDocument();
            XmlDeclaration xmldecl = xmlDocument.CreateXmlDeclaration("1.0", null, null);
            xmldecl.Encoding = "ISO-8859-1";

            // Create Root node
            XmlElement rootNode = xmlDocument.CreateElement("BE05");
            xmlDocument.AppendChild(rootNode);
            xmlDocument.InsertBefore(xmldecl, rootNode);

            // Create defaults
            Data = new BE05();
            Data.ToXml(xmlDocument, rootNode);

            Building = Data.Building;
        }

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
            string testPath = File.ReadAllText(@"C:\Users\l_toh\OneDrive\Skrivebord\Projects\Bison.Core\Testing\Eksempel_v9_Administration.bexml");

            int bufferSize = 100000;
            StringBuilder modelStringBuffer = new StringBuilder(testPath, bufferSize);
            StringBuilder mem = new StringBuilder(bufferSize);
            int status = bufferSize;

            int res = Be06Keys(modelStringBuffer, mem, ref status, 1);
            Console.WriteLine(mem);
        }
    }
}
