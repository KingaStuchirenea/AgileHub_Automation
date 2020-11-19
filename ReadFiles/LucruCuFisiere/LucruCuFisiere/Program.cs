using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LucruCuFisiere
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adaugare linii in fisier:
            //string[] lines = { "Linia 1", "Linia 2", "Linia 3", "Linia 4", "Linia 5" };
            //foreach(var line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //System.IO.File.WriteAllLines(@"C:\Users\kstuchirenea\Desktop\AgileHub\NewGitHub\AgileHub_Automation\ReadFiles\LucruCuFisiere\LucruCuFisiere\WriteLinesSample.txt", lines);
            //Console.WriteLine("Liniile au fost scrise in fisier");
            //Console.ReadKey();

            //Adaugare text in fisier:
            //string text = "Brașov is located in the central part of the country, about 166 kilometres (103 miles) north of Bucharest and 380 kilometres (236 miles) from the Black Sea. It is surrounded by the Southern Carpathians and is part of the historical region of Transylvania.";
            //System.IO.File.WriteAllText(@"C:\Users\kstuchirenea\Desktop\AgileHub\NewGitHub\AgileHub_Automation\ReadFiles\LucruCuFisiere\LucruCuFisiere\WriteLinesSample.txt", text);
            //Console.WriteLine("Liniile au fost scrise in fisier");
            //Console.ReadKey();

            //Filtrare date la adaugare:
            //string[] lines = { "Linia 1", "Linia 2", "Linia 3", "Linia 4", "Linia 5" };
            //using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\kstuchirenea\Desktop\AgileHub\NewGitHub\AgileHub_Automation\ReadFiles\LucruCuFisiere\LucruCuFisiere\WriteLinesSample.txt"))
            //{
            //    foreach (var line in lines)
            //    {
            //        if (!line.Contains("3"))
            //        {
            //            file.WriteLine(line);
            //        }
            //    }
            //}

            //Adaugare in continuare la fisier, append
            //string[] lines = { "Linia 1", "Linia 2", "Linia 3", "Linia 4", "Linia 5" };
            //using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\kstuchirenea\Desktop\AgileHub\NewGitHub\AgileHub_Automation\ReadFiles\LucruCuFisiere\LucruCuFisiere\WriteLinesSample.txt",true))
            //{
            //    foreach (var line in lines)
            //    {
            //        if (line.Contains("3"))
            //        {
            //            file.WriteLine(line);
            //        }
            //    }
            //}
            //Console.WriteLine("Liniile au fost scrise in fisier");

            //citire din fisier 1
            //string readText = System.IO.File.ReadAllText(@"C:\Users\kstuchirenea\Desktop\AgileHub\NewGitHub\AgileHub_Automation\ReadFiles\LucruCuFisiere\LucruCuFisiere\WriteLinesSample.txt");
            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\kstuchirenea\Desktop\AgileHub\NewGitHub\AgileHub_Automation\ReadFiles\LucruCuFisiere\LucruCuFisiere\WriteLinesSample.txt");
            //Console.WriteLine($"Textul nostru este: {readText}");

            //citire din fisier 2
            //var lines = System.IO.File.ReadLines(@"C:\Users\kstuchirenea\Desktop\AgileHub\NewGitHub\AgileHub_Automation\ReadFiles\LucruCuFisiere\LucruCuFisiere\WriteLinesSample.txt");
            //foreach (var line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //string line;
            //System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\kstuchirenea\Desktop\AgileHub\NewGitHub\AgileHub_Automation\ReadFiles\LucruCuFisiere\LucruCuFisiere\WriteLinesSample.txt");
            //while (!(line = file.Read()).Contains("NumeScenariu"))
            //{
            //    Console.WriteLine(line);
            //}

            //var lines = System.IO.File.ReadLines(@"C:\Users\kstuchirenea\Desktop\AgileHub\NewGitHub\AgileHub_Automation\ReadFiles\LucruCuFisiere\LucruCuFisiere\WriteLinesSample.txt");
            //foreach (var line in lines)
            //{
            //    if (line.Contains("NumeScenariu"))
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //file.Close();
            //Console.WriteLine("Liniile au fost citite din fisier");
            //Console.ReadKey();

            //ScenarioDto.WriteXML();
            //Console.WriteLine("Fisierul a fost creat");
            //Console.ReadKey();

            var myValue = ScenarioDto.ReadXML();
            //Console.WriteLine($"Numele Scenariului este: {myValue.TestCaseName}, Numele proprietatii 2 este: {myValue.TestInput}, proprietatea 3 este: {myValue.OtherInfo}");

            //ScenarioDto.JsonSerialize();

            //ScenarioDto.JsonDeserialize();

            var myList = ScenarioDto.LoadValuesFromJsonFile();

            foreach(var elemnt in myList)
            {
                Console.WriteLine($" elemtul {myList.IndexOf(elemnt)}: {elemnt.TestCaseName}, {elemnt.TestInput}, {elemnt.OtherInfo}, numaril de valori in campul Values {elemnt.Values.Count}");

            }

        }
    }
}
