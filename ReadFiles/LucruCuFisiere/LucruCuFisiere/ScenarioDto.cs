using System;
using System.Collections.Generic;
using System.Text;

namespace LucruCuFisiere
{
    public class ScenarioDto
    {
        public string TestCaseName { get; set; }
        public string TestInput { get; set; }
        public string OtherInfo { get; set; }

        public static void WriteXML()
        {
            ScenarioDto myScenario = new ScenarioDto { TestCaseName = "Scenariul1", TestInput = "john.miller@bla.com", OtherInfo = "password123" };
            //myScenario.TestCaseName = "Scenariul1";
            //myScenario.TestInput = "john.miller@bla.com";
            //myScenario.OtherInfo = "password123";
            //System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(ScenarioDto));

            var writer = new System.Xml.Serialization.XmlSerializer(typeof(ScenarioDto));
            var writeFile = new System.IO.StreamWriter(@"C:\Users\kstuchirenea\Desktop\AgileHub\NewGitHub\AgileHub_Automation\ReadFiles\LucruCuFisiere\LucruCuFisiere\WriteXML.xml");

            //var path = @"C:\Users\kstuchirenea\Desktop\AgileHub\NewGitHub\AgileHub_Automation\ReadFiles\LucruCuFisiere\LucruCuFisiere\WriteXML.xml";

            //System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(writeFile, myScenario);
            writeFile.Close();

        }

        public static ScenarioDto ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(ScenarioDto));
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\kstuchirenea\Desktop\AgileHub\NewGitHub\AgileHub_Automation\ReadFiles\LucruCuFisiere\LucruCuFisiere\WriteXML.xml");
            ScenarioDto myScenarioDto = (ScenarioDto)reader.Deserialize(file);
            file.Close();
            return myScenarioDto;
        }

    }
}
