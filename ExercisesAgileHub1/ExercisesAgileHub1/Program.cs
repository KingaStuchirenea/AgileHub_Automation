using System;
using System.Collections.Generic;

namespace ExercisesAgileHub1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Variabiles();
            IfStatement();
            Arrays();
            ListCreation();
            MyDictionary();
            StringFormatting();
            ForLoop();
            WhileLoop();
            //Prerequisites for Methods:
            int x = 2;
            int y = 2;
            int a = foo(x, y);
            Console.WriteLine("\n" + a);
            MainClass2.Main2();
            MainClass3.Main3();

        }

        //Define three variables:
        //A string named productName equal to TV.
        //An integer named productYear equal to 2012.
        //A float named productPrice equal to 279.99f.

        public static void Variabiles()
        {
            // write your code here
            string productName = "TV";
            int productYear = 2012;
            float productPrice = 279.99f;
            // test code
            Console.WriteLine("\nproductName: " + productName);
            Console.WriteLine("productYear: " + productYear);
            Console.WriteLine("productPrice: " + productPrice);
        }

        //In this exercise, you must construct an if statement that checks if the number guess is equal to 500. If that is the case, use Console.WriteLine to display "Success!".
        public static void IfStatement()
        {
            int guess = 500;
            // Write conditional here
            if (guess == 500)
            {
                Console.WriteLine("\nSuccess!");
            }
        }

        //Define an array called fruits that holds the following strings: "apple", "banana", and "orange".
        public static void Arrays()
        {
            // write your code here
            string[] fruits = { "apple", "banana", "orange" };
            // test code
            Console.WriteLine("\n" + fruits[0]);
            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits[2]);
        }

        //Construct a list of the first 5 prime numbers (2, 3, 5, 7, 11) called primeNumbers.
        public static void ListCreation()
        {
            // TODO: add your code here
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.Add(11);
            // test code
            Console.WriteLine("\n" + primeNumbers.Count);
            Console.WriteLine(primeNumbers[0]);
            Console.WriteLine(primeNumbers[1]);
            Console.WriteLine(primeNumbers[2]);
            Console.WriteLine(primeNumbers[3]);
            Console.WriteLine(primeNumbers[4]);
        }

        //Create a new dictionary called inventory that holds 3 names of fruits, and the amount they are in stock.
        //Here is the inventory specification:
        //    3 of type apple
        //    5 of type orange
        //    2 of type banana
        public static void MyDictionary()
        {
            // TODO: add the inventory dictionary here
            Dictionary<string, long> inventory = new Dictionary<string, long>();
            inventory.Add("apple", 3);
            inventory["orange"] = 5;
            inventory.Add("banana", 2);
            Console.WriteLine("\n" + inventory["apple"]);
            Console.WriteLine(inventory["orange"]);
            Console.WriteLine(inventory["banana"]);
        }

        //Use string formatting to format the variables firstName, lastName and age to form the following sentence into the string sentence:
        //John Doe is 27 years old.
        public static void StringFormatting()
        {
            string firstName = "John";
            string lastName = "Doe";
            int age = 27;
            // TODO: change this
            string sentence = String.Format("{0}" + " " + "{1}" + " is " + "{2}" + " years old.", firstName, lastName, age);
            Console.WriteLine("\n" + sentence + "\n");
        }

        //Print the value of variable X to the screen N number of times
        public static void ForLoop()
        {
            string x = "Hi";
            int n = 10;
            // write for loop here
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
        }

        //Print X to the console N time using a while loop
        public static void WhileLoop()
        {
            string x = "Hi";
            int n = 10;
            //write while loop here
            while (n > 0)
            {
                Console.WriteLine(x);
                n--;
            }
        }

        //Write a method that divides two numbers (provided as parameters). Tip: you will need to use the modifiers public and static.
        public static int foo(int x, int y)
        {
            return x / y;
        }

        //Make a class car with the properties numTires = 4, year = 2000, and runs = true, and create three instances of it: car1, car2, and car3.
        class car
        {
            public int numTires = 4;
            public int year = 2000;
            public bool runs = true;
        }
        public class MainClass2
        {
            public static void Main2()
            {
                car car1 = new car();
                car car2 = new car();
                car car3 = new car();
                // Test code
                Console.WriteLine("\n" + car1.numTires);
                Console.WriteLine(car2.year);
                Console.WriteLine(car3.runs);
            }
        }

        //Make a class Vehicle with the properties string Type, int NumTires, int Year, and bool Runs, and create:
        //A car: Type = car with NumTires = 4 from Year = 2000 which Runs = true An oldcar: Type = car with NumTires = 4 from Year = 1980 which Runs = false A bike: Type = bike with NumTires = 2 from Year = 2017 which Runs = true
        //Write Vehicle class here
        class Vehicle
        {
            public string Type;
            public int NumTires;
            public int Year;
            public bool Runs;
            public Vehicle(string type, int numTires, int year, bool runs)
            {
                Type = type;
                NumTires = numTires;
                Year = year;
                Runs = runs;
            }
        }
        public class MainClass3
        {
            public static void Main3()
            {
                //Create vehicles here
                Vehicle car = new Vehicle("car", 4, 2000, true);
                Vehicle oldcar = new Vehicle("car", 4, 1980, false);
                Vehicle bike = new Vehicle("bike", 2, 2017, true);
                // Test code
                Console.WriteLine("\n" + car.Type);
                Console.WriteLine(oldcar.Runs);
                Console.WriteLine(bike.NumTires);
            }
        }

    }


}
