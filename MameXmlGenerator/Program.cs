using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using HyperspinXmlGenerator.Models;

namespace MameXmlGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1 && args[0] == "-help")
            {
                Console.Write("\tExample: MameXmlGenerator.exe C:\\temp MAME.xml haveRoms.txt MAME-haveRoms_smaller.xml");
                return;
            }
            else if (args.Length != 4)
            {
                Console.WriteLine("Usage: app [path] [xml file to read] [have roms filename] [exported filename.xml]");
                return;
            }

            // The absolute path to where the MAME.xml and haveRoms.txt files live
            string path = args[0];
            string mameFile = args[1];
            string haveRomsFile = args[2];
            string outputFileName = args[3];

            // read the haveRoms that was generated from hyperspin
            string[] names = null;
            List<string> namesList = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader($"{path}/{haveRomsFile}"))
                {
                    string result = reader.ReadToEnd();
                    names = result.Split('\n');
                    foreach (string s in names)
                    {
                        // get rid of the carriage return
                        int idx = s.IndexOf("\r");
                        if (idx > 0)
                        {
                            namesList.Add(s.Remove(s.IndexOf("\r")));
                        }
                        else
                        {
                            namesList.Add(s);
                        }

                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            // The main mame.xml file we'll manipulate (new file created without nodes with names not found in the names list
            XmlReader xmlReader = XmlReader.Create($"{path}\\{mameFile}");

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("\t");
            XmlWriter writer = XmlWriter.Create($"{path}\\{outputFileName}", settings);

            /*
            < header >
                < listname > MAME </ listname >
                < lastlistupdate > 04 / 21 / 2015 </ lastlistupdate >
                < listversion > .160 Ongoing </ listversion >
                < exporterversion > HyperList XML Exporter Version 1.3 Copywrite(c) 2009 - 2011 William Strong</ exporterversion >
            </ header >
           */

            writer.WriteStartElement("menu");
            writer.WriteStartElement("header");

            writer.WriteStartElement("listname");
            writer.WriteString("MAME");
            writer.WriteEndElement();

            writer.WriteStartElement("lastlistupdate");
            writer.WriteString("04 / 21 / 2015");
            writer.WriteEndElement();

            writer.WriteStartElement("listversion");
            writer.WriteString(".160 Ongoing");
            writer.WriteEndElement();

            writer.WriteStartElement("exporterversion");
            writer.WriteString("HyperList XML Exporter Version 1.3 Copywrite(c) 2009 - 2011 William Strong");
            writer.WriteEndElement();

            writer.WriteEndElement();

            // begin game
            /*
            <game name="88games" index="true" image ="'">
             <description> &apos; 88 Games </description>
             <cloneof></cloneof>
             <crc></crc>
             <manufacturer> Konami </manufacturer>
             <year> 1988 </year>
             <genre> Sports / Track & amp; Field </genre>
                 <rating> AAMA - Green(Suitable For All Ages) </rating>
                 <enabled> Yes </enabled>
             </game>
             */


            while (xmlReader.Read())
            {
                mameMachine mameMachine = new mameMachine();
                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                    if (xmlReader.EOF)
                    {
                        break;
                    }

                    switch (xmlReader.Name)
                    {
                        case "game":
                            string name = xmlReader.GetAttribute("name");
                            if (namesList.Contains(name))
                            {
                                writer.WriteNode(xmlReader, false);
                            }
                            break;
                    }
                }
            }
            xmlReader.Close();

            // end menu
            writer.WriteEndElement();
            writer.Close();
        }
    }
}
