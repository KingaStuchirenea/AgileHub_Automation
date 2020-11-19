using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LucruCuFisiere
{
    public class ScenarioDto
    {
        public string TestCaseName { get; set; }
        public string TestInput { get; set; }
        public string OtherInfo { get; set; }
        public List<string> Values { get; set; }

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

        public static void JsonSerialize()
        {
            ScenarioDto myObject = new ScenarioDto
            {
                TestCaseName = "TestCase1",
                TestInput = "Inputul meu",
                OtherInfo = "Alte informatii",
                Values = new List<string> { "value1", "value2", "value3" }
            };


            //string myJson = JsonConvert.SerializeObject(myObject, Formatting.Indented);

            //File.WriteAllText(@"C:\Users\kstuchirenea\Desktop\AgileHub\NewGitHub\AgileHub_Automation\ReadFiles\LucruCuFisiere\LucruCuFisiere\MyJsonExample.json", JsonConvert.SerializeObject(myObject, Formatting.Indented));

            using (StreamWriter file = File.CreateText(@"C:\Users\kstuchirenea\Desktop\AgileHub\NewGitHub\AgileHub_Automation\ReadFiles\LucruCuFisiere\LucruCuFisiere\MyJsonExample2.json"))
            {
                JsonSerializer serializator = new JsonSerializer();
                serializator.Serialize(file, myObject);
            }
            Console.WriteLine("Fisierul json a fost creat");

        }

        public static void JsonDeserialize()
        {
            string myJson = @"{'TestCaseName': 'TestCase1', 'TestInput': 'Inputul meu', 'OtherInfo': 'Alte informatii'}";
            ScenarioDto myObject = JsonConvert.DeserializeObject<ScenarioDto>(myJson);
            Console.WriteLine(myObject.TestCaseName);
        }

        public static List<ScenarioDto> LoadValuesFromJsonFile()
        {
            var myFile = @"C:\Users\kstuchirenea\Desktop\AgileHub\NewGitHub\AgileHub_Automation\ReadFiles\LucruCuFisiere\LucruCuFisiere\MyJsonExample2.json";
            try {
                using (var reader = new StreamReader(myFile))
                {
                    var json = reader.ReadToEnd();
                    var config = JObject.Parse(json).SelectToken("ScenarioDto").ToString();
                    var myTestDataList = JsonConvert.DeserializeObject<List<ScenarioDto>>(config);

                    return myTestDataList;
                }
            }
            catch (Exception)
            {
                throw new Exception($"There is a problem with file {myFile}");
            }
        }

    }
}
