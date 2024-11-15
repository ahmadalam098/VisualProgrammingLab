


using System;
using System.Xml;

namespace GPS_XML_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateXmlFile();
            ReadXmlFile();
        }

        static void CreateXmlFile()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";
            XmlWriter w = XmlWriter.Create("GPS.xml", settings);

            w.WriteStartDocument();
            w.WriteStartElement("GPS_Log");

            w.WriteStartElement("Position");
            w.WriteAttributeString("DateTime", DateTime.Now.ToString());
            w.WriteElementString("x", "65.8973342");
            w.WriteElementString("y", "72.3452346");

            w.WriteStartElement("SatteliteInfo");
            w.WriteElementString("Speed", "40");
            w.WriteElementString("NoSatt", "7");
            w.WriteEndElement(); // End element of SatteliteInfo

            w.WriteEndElement(); // End element of Position

            w.WriteStartElement("Image");
            w.WriteAttributeString("Resolution", "1024x800");
            w.WriteElementString("Path", @"\images\1.jpg");
            w.WriteEndElement(); // End element of Image

            w.WriteEndElement(); // End element of GPS_Log
            w.WriteEndDocument();
            w.Close();
        }

        static void ReadXmlFile()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("GPS.xml");

            XmlElement root = xmlDoc.DocumentElement;

            Console.WriteLine("GPS Log:");
            Console.WriteLine("---------");

            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name == "Position")
                {
                    Console.WriteLine($"Date Time: {node.Attributes["DateTime"].Value}");
                    Console.WriteLine($"X: {node["x"].InnerText}");
                    Console.WriteLine($"Y: {node["y"].InnerText}");

                    XmlNode satteliteInfo = node["SatteliteInfo"];
                    Console.WriteLine($"Speed: {satteliteInfo["Speed"].InnerText}");
                    Console.WriteLine($"No. of Satellites: {satteliteInfo["NoSatt"].InnerText}");
                }
                else if (node.Name == "Image")
                {
                    Console.WriteLine($"Resolution: {node.Attributes["Resolution"].Value}");
                    Console.WriteLine($"Path: {node["Path"].InnerText}");
                }
            }
        }
    }
}


