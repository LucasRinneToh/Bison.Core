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

namespace Bison.Core.BE18
{
    /// <summary>
    /// This is a top-level wrapper class for the Be18 project.
    /// </summary>
    public class Project
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool SetDllDirectory(string lpPathName);

        private string OutputPath { get; set; }
        private string Be18Folder { get; set; }
        public XmlDocument xmlDocument;
        public BE05 Data;

        public Project(string outputPath, string Be18Folder)
        {
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
        public void RunCalculation()
        {
            LoadEngine(Be18Folder);
            int licenceValid = IsLicenseValid();
        }
 

    }
}
