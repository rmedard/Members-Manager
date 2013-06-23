using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RNC.Tools
{
    class ConnectionManager
    {
        private XmlDocument xmlDoc;
        private string fileLocation;

        public ConnectionManager()
        {
            fileLocation = @"C:\Users\Medard\documents\visual studio 2012\Projects\RNC\RNC\Tools\SmtpSettings.xml";
            xmlDoc = new XmlDocument();
        }

        public XmlDocument XmlDoc
        {
            get { return xmlDoc; }
            set { xmlDoc = value; }
        }

        public SqlCeConnection getConnection()
        {
            return new SqlCeConnection(Properties.Settings.Default.MembersDBConnectionString);
        }

        public XmlNode getSmtpSettingsXMLRoot()
        {

            if (File.Exists(fileLocation))
            {
                xmlDoc.Load(fileLocation);
                return xmlDoc.DocumentElement;
            }
            return null;
        }

        public void saveXmlDoc()
        {
            xmlDoc.Save(fileLocation);
        }

        //This function read smtpSetting and returns values: Possibility to use serialization.
        public Dictionary<string, string> readSmtpSettings()
        {
            XmlNode rootNode = getSmtpSettingsXMLRoot();
            if (rootNode != null)
            {
                Dictionary<string, string> smtpSettings = new Dictionary<string, string>();
                foreach (XmlNode node in rootNode.ChildNodes)
                {
                    if (node.Name == "Host" && node.Attributes[0].Value != "")
                    {
                        smtpSettings.Add("hostName", node.Attributes[0].Value);
                        smtpSettings.Add("enableSSL", node.Attributes[1].Value);
                        smtpSettings.Add("useDefaultCredentials", node.Attributes[2].Value);
                        smtpSettings.Add("portNumber", node.Attributes[3].Value);
                        foreach (XmlNode childNode in node.ChildNodes)
                        {
                            if (childNode.Name == "SenderName")
                            {
                                smtpSettings.Add("senderName", childNode.FirstChild.Value);
                            }
                            else if (childNode.Name == "Email")
                            {
                                smtpSettings.Add("senderEmail", childNode.FirstChild.Value);
                            }
                            else if (childNode.Name == "Password")
                            {
                                smtpSettings.Add("senderPassword", childNode.FirstChild.Value);
                            }
                        }
                    }
                } 
                return smtpSettings;
            } 
            return null;
        }
    }
}
