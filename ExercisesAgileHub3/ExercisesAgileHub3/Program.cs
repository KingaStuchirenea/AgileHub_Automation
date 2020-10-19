using System;
using System.Linq;

namespace ExercisesAgileHub3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercitii din fisierul "Exercitii23"

            Exercitiu1();
            Exercitiu2();
            Exercitiu3();
            Exercitiu4();
            Exercitiu5();
            Exercitiu6();
            Exercitiu7();
            Exercitiu8();
            Exercitiu9();
            Exercitiu10();
            Exercitiu11();
            Exercitiu12();
            Exercitiu13();
            Exercitiu14();
            Exercitiu15();
            Exercitiu16();
            Exercitiu17();
            Exercitiu18();
            Exercitiu19();
            Exercitiu20();
            Exercitiu21();
            Exercitiu22();
            Exercitiu23();
            Exercitiu24();
            Exercitiu25();
            Exercitiu26();
            Exercitiu27();
        }

        //1.	Scrieti un program care sa afiseze primele 10 numere naturale.
        public static void Exercitiu1()
        {
            int i = 0;
            while (i < 10)
            {
                Console.Write(i + " ");
                i++;
            }
        }

        //2.	Scrieti un program care sa afiseze suma primelor 10 numere naturale.
        public static void Exercitiu2()
        {
            int i = 0;
            int sum = 0;
            Console.WriteLine("Suma primelor 10 numere naturale este: ");
            while (i < 10)
            {
                sum = sum + i;
                i++;
            } 
            Console.WriteLine(sum);
        }

        //3.	Cititi un numar de la tastatura. Afisati toate numerele mai mici decat numarul citit de voi.
        public static void Exercitiu3()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = int.Parse(Console.ReadLine());
            int x = 0;
            while (x < num)
            {
                Console.Write(x + " ");
                x++;
            }
        }

        //4.	Cititi un numar de la tastatura. Afisati toate numerele de la 3 pana la numarul citit de voi.
        public static void Exercitiu4()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = int.Parse(Console.ReadLine());
            int x = 3;
            while (x < num)
            {
                Console.Write(x + " ");
                x++;
            }
        }

        //5.	Cititi un numar de la tastatura. Afisati suma numerelor mai mici decat numarul citit de voi.
        public static void Exercitiu5()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = int.Parse(Console.ReadLine());
            int x = 0;
            int sum = 0;
            while (x < num)
            {
                sum = sum + x;
                x++;
            }
            Console.WriteLine("Suma numerelor mai mici decat numarul citit este: " + sum);
        }

        //6.	Afisati cubul primelor 5 numere naturale.
        public static void Exercitiu6()
        {
            Console.WriteLine("Cubul primelor 5 numere naturale: ");
            int num = 0;
            while (num < 5)
            {
                int cub = num * num * num;
                Console.WriteLine(cub + " ");
                num++;
            }
        }

        //7.	Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru.
        public static void Exercitiu7()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < num)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            }
        }

        //8.	Scrieti un program care sa afiseze primele 10 numere naturale.( do while)
        public static void Exercitiu8()
        {
            int i = 0;
            do
            {
                Console.Write(i + " ");
                i++;
            } while (i < 10);
        }

        //9.	Scrieti un program care sa afiseze suma primelor 10 numere naturale. ( do while)
        public static void Exercitiu9()
        {
            int i = 0;
            int sum = 0;
            Console.WriteLine("Suma primelor 10 numere naturale este: ");
            do
            {
                sum = sum + i;
                i++;
            } while (i < 10);
            Console.WriteLine(sum);
        }

        //10.	Cititi un numar de la tastatura.Afisati toate numerele mai mici decat numarul citit de voi. .( do while)
        public static void Exercitiu10()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = int.Parse(Console.ReadLine());
            int x = 0;
            do
            {
                Console.Write(x + " ");
                x++;
            }
            while (x < num);
        }

        //11.	Cititi un numar de la tastatura.Afisati toate numerele de la 3 pana la numarul citit de voi. .( do while)
        public static void Exercitiu11()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = int.Parse(Console.ReadLine());
            int x = 3;
            do
            {
                Console.Write(x + " ");
                x++;
            }
            while (x < num);
        }

        //12.	Cititi un numar de la tastatura.Afisati suma numerelor mai mici decat numarul citit de voi. .( do while)
        public static void Exercitiu12()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = int.Parse(Console.ReadLine());
            int x = 0;
            int sum = 0;
            do
            {
                sum = sum + x;
                x++;
            }
            while (x < num);
            Console.WriteLine("Suma numerelor mai mici decat numarul citit este: " + sum);
        }

        //13.	Afisati cubul primelor 5 numere naturale. .( do while)
        public static void Exercitiu13()
        {
            Console.WriteLine("Cubul primelor 5 numere naturale: ");
            int num = 0;
            do
            {
                int cub = num * num * num;
                Console.WriteLine(cub + " ");
                num++;
            } while (num < 5);
        }

        //14.	Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru. .( do while)
        public static void Exercitiu14()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            do
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            } while (i < num);
        }

        //15.	Scrieti un program care sa afiseze primele 10 numere naturale. (for)
        public static void Exercitiu15()
        {
            for (int i = 0; i < 10; i++)
                Console.Write(i + " ");
        }

        //16.	Scrieti un program care sa afiseze suma primelor 10 numere naturale. (for)
        public static void Exercitiu16()
        {
            int sum = 0;
            Console.WriteLine("Suma primelor 10 numere naturale este: ");
            for (int i = 0; i < 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }

        //17.	Cititi un numar de la tastatura.Afisati toate numerele mai mici decat numarul citit de voi. (for)
        public static void Exercitiu17()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = int.Parse(Console.ReadLine());
            for (int x = 0; x < num; x++)
            {
                Console.Write(x + " ");
            }
        }

        //18.	Cititi un numar de la tastatura.Afisati toate numerele de la 3 pana la numarul citit de voi. (for)
        public static void Exercitiu18()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = int.Parse(Console.ReadLine());
            for (int x = 3; x < num; x++)
            {
                Console.Write(x + " ");
            }
        }

        //19.	Cititi un numar de la tastatura.Afisati suma numerelor mai mici decat numarul citit de voi. (for)
        public static void Exercitiu19()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int x = 0; x < num; x++)
            {
                sum = sum + x;
            }
            Console.WriteLine("Suma numerelor mai mici decat numarul citit este: " + sum);
        }

        //20.	Afisati cubul primelor 5 numere naturale. (for)
        public static void Exercitiu20()
        {
            Console.WriteLine("Cubul primelor 5 numere naturale: ");
            for (int num = 0; num < 5; num++)
            {
                int cub = num * num * num;
                Console.WriteLine(cub + " ");
            }
        }

        //21.	Cititi un numar de la tastatura si afisati numerele pare mai mici decat numarul vostru. (for)
        public static void Exercitiu21()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        //22.	Afisati al doilea element din urmatorul array: “sun”, “moon”, “clouds”.
        public static void Exercitiu22()
        {
            string[] myArray = new string[] {"sun", "moon", "clouds"};
            Console.WriteLine(myArray[1]);
        }

        //23.	Afisati cherry din urmatorul array: “lemons”, “watermelon”, “cherry”
        public static void Exercitiu23()
        {
            string[] myArray = new string[] { "lemons", "watermelon", "cherry" };
            Console.WriteLine(myArray.Last());
        }

        //24.	Afisati array-ul in ordine inversa: “mom”, “dad”, “child”.
        public static void Exercitiu24()
        {
            string[] myArray = new string[] { "mom", "dad", "child" };
            string displayArray = string.Join(", ", myArray.Reverse());
            Console.WriteLine(displayArray);
        }

        //25.	Afisati array-ul sortat: “mom”, “dad”, “child”.
        public static void Exercitiu25()
        {
            string[] myArray = new string[] { "mom", "dad", "child" };
            myArray = myArray.OrderBy(arr => arr).ToArray();
            //myArray = myArray.OrderByDescending(arr => arr).ToArray();
            string displayArray = string.Join(", ", myArray);
            Console.WriteLine(displayArray);
        }

        //26.	Cititi de la tastatura elementele unui array de marime 5. (string)
        public static void Exercitiu26()
        {
            string[] myArray = new string[5];
            string readArray = string.Join(", ", myArray);
            Console.Write("Introduceti 5 elemente de tip string despartite prin \", \" : ");
            readArray = Console.ReadLine(); 
            Console.WriteLine("Array-ul contine elementele: " + readArray);
        }

        //27.	Cititi de la tastatura elementele unui array de marime 5.(int)
        public static void Exercitiu27()
        {
            int[] myArray = new int[5];
            Console.WriteLine("Introduceti 5 elemente de tip int: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("element {0}: ", i);
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array-ul contine elementele: ");
            foreach(var item in myArray)
            {
                Console.Write(item + " ");
            }
        }

    }
}
