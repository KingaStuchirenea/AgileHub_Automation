using System;

namespace ExercisesAgileHub2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercitiile din fisierul "Exercitii22"

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
        }

        //1.Cititi de la tastatura un numar.Verificati daca numarul este egal cu 20.In cazul in care este, afisati mesajul “Numarul tau este egal cu 20!
        public static void Exercitiu1()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 20)
            {
                Console.WriteLine("Numarul tau este egal cu 20!");
            }
            else
            {
                Console.WriteLine("Numarul tau NU este egal cu 20!");
            }
        }

        //2.Cititi de la tastatura un cuvant.Verificati daca cuvantul vostru este “automation” si in cazul in care este adevarat, afisati urmatorul text:” Cuvantul pe care tu l - ai citit este “automation””.
        public static void Exercitiu2()
        {
            Console.WriteLine("Introduceti un cuvant: ");
            string cuvant = (Console.ReadLine());
            if (cuvant == "automation")
            {
                Console.WriteLine("Cuvantul pe care tu l-ai citit este \"automation\"");
            }
        }

        //3.Cititi de la tastatura un character si verificati daca acel character este cifra si in cazul in care este adevarat afisati :”Caracterul* character*pe care l-ai introdus este cifra!”
        public static void Exercitiu3()
        {
            Console.WriteLine("Introduceti un caracter: ");
            char caracter = char.Parse(Console.ReadLine());
            if (char.IsNumber(caracter))
            {
                Console.WriteLine($"Caracterul *{caracter}* pe care l-ai introdus este cifra!");
            }
        }

        //4.Cititi de la tastatura un numar.In cazul in care este mai mic decat 20, adunati acel numar cu 5 si afisati rezultatul final. Afisati fie noul rezultat, fie numarul.
        public static void Exercitiu4()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum;
            if (num < 20)
            {
                sum = num + 5;
                Console.WriteLine($"Numarul introdus este {num}, iar {num} + 5 = {sum}");
            }
            else
            {
                Console.WriteLine($"Numarul introdus este {num} si nu se face nici o adunare.");
            }
        }

        //5.Cititi de la tastatura un numar.Verificati daca numarul este pozitiv si afisati: “Numarul* numar*este pozitiv”.
        public static void Exercitiu5()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine($"Numarul {num} este positiv.");
            }
        }

        //6.Cititi de la tastatura un numar.Verificati daca numarul este mai mic de 20 sau mai mare de 40 si afisati: “Numarul este mai mic de 20 sau mai mare de 40!.”In caz contrar nu afisati nimic.
        public static void Exercitiu6()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 20 || num > 40)
            {
                Console.WriteLine("Numarul este mai mic de 20 sau mai mare de 40!");
            }
        }

        //7.Cititi de la tastaura un numar.Verificati daca numarul este par.Daca numarul este par afisati:”Numarul* numar*pe care l’ati introdus este par!”. In caz contrar nu afisati nimic
        public static void Exercitiu7()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"Numarul {num} pe care l-ati introdus este par!");
            }
        }

        //8.Cititi de la tastatura un numar.Verificati daca numarul este egal cu 20.In cazul in care este, afisati mesajul “Numarul tau este egal cu 20!”, in caz contrar: “Numarul tau este diferit de 20”.
        public static void Exercitiu8()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 20)
            {
                Console.WriteLine("Numarul tau este egal cu 20!");
            }
            else
            {
                Console.WriteLine("Numarul tau este diferit de 20.");
            }
        }

        //9.Cititi de la tastatura un cuvant.Verificati daca cuvantul vostru este “automation” si in cazul in care este adevarat, afisati urmatorul text:” Cuvantul pe care tu l - ai citit este “automation””. In caz contrar afisati mesajul: “Cuvantul pe care l-ai citit nu este “automation””.
        public static void Exercitiu9()
        {
            Console.WriteLine("Introduceti un cuvant: ");
            string cuvant = (Console.ReadLine());
            if (cuvant == "automation")
            {
                Console.WriteLine("Cuvantul pe care tu l-ai citit este \"automation\"");
            }
            else
            {
                Console.WriteLine("Cuvantul pe care tu l-ai citit NU este \"automation\"");
            }
        }

        //10.Cititi de la tastatura un character si verificati daca acel character este cifra si in cazul in care este adevarat afisati :”Caracterul* character*pe care l-ai introdus este cifra!”, in caz contrat afisati “Caracterul* character*pe care l-ai introdus nu este cifra.
        public static void Exercitiu10()
        {
            Console.WriteLine("Introduceti un caracter: ");
            char caracter = char.Parse(Console.ReadLine());
            if (char.IsNumber(caracter))
            {
                Console.WriteLine($"Caracterul *{caracter}* pe care l-ai introdus este cifra!");
            }
            else
            {
                Console.WriteLine($"Caracterul *{caracter}* pe care l-ai introdus NU este cifra!");
            }
        }

        //11.Cititi de la tastatura un numar.In cazul in care este mai mic decat 20, adunati acel numar cu 5 si afisati rezultatul final. In caz contrar scadeti numarul cu 5 si afisati rezultatul final.
        public static void Exercitiu11()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum;
            if (num < 20)
            {
                sum = num + 5;
                Console.WriteLine($"Numarul introdus este {num}, iar {num} + 5 = {sum}");
            }
            else
            {
                sum = num - 5;
                Console.WriteLine($"Numarul introdus este {num}, iar {num} - 5 = {sum}");
            }
        }

        //12.Cititi de la tastatura un numar.Verificati daca numarul este pozitiv si afisati: “Numarul* numar*este pozitiv”. In caz contrar afisati “Numarul* numar*este negativ!.
        public static void Exercitiu12()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine($"Numarul {num} este positiv.");
            }
            else
            {
                Console.WriteLine($"Numarul {num} este negativ.");
            }
        }

        //13.Cititi de la tastatura un numar.Verificati daca numarul este mai mic de 20 sau mai mare de 40 si afisati: “Numarul este mai mic de 20 sau mai mare de 40!.”In caz contrar afisati: “Numarul este intre 20 si 40!”
        public static void Exercitiu13()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 20 || num > 40)
            {
                Console.WriteLine("Numarul este mai mic de 20 sau mai mare de 40!");
            }
            else
            {
                Console.WriteLine("Numarul este intre 20 si 40!");
            }
        }

        //14.Cititi de la tastaura un numar.Verificati daca numarul este par.Daca numarul este par afisati:”Numarul* numar*pe care l’ati introdus este par!”. In caz contrar afisati “Numarul* numar*pe care l’ati introdus este impar!”.
        public static void Exercitiu14()
        {
            Console.WriteLine("Introduceti un numar: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"Numarul {num} pe care l-ati introdus este par!");
            }
            else
            {
                Console.WriteLine($"Numarul {num} pe care l-ati introdus este impar!");
            }
        }

        //15.Cititi de la tastatura un caracter.Daca acel caracter este litera afisati mesajul:”Caracterul* caracter*este litera!”. In cazul in care este o cifra afisati mesajul :”Caracterul* caracter*este o cifra!”. In cazul contrar afisati mesajul: “Caracterul* caracter*nu este nici cifra nici litera
        public static void Exercitiu15()
        {
            Console.WriteLine("Introduceti un caracter: ");
            char caracter = char.Parse(Console.ReadLine());
            if (char.IsLetter(caracter))
            {
                Console.WriteLine($"Caracterul *{caracter}* este litera!");
            }
            else if (char.IsNumber(caracter))
            {
                Console.WriteLine($"Caracterul *{caracter}* este cifra!");
            }
            else
            {
                Console.WriteLine($"Caracterul *{caracter}* nu este nici litera nici cifra!");
            }
        }

        //16.Cititi de la tastatura o ora a zilei.In cazul in care ora respectiva este mai mica de 12 afisati: “Buna dimineata!”. Daca ora este mai mica decat 17 afisati mesajul: “Buna ziua!”. In caz contrar afisati mesajul:”Buna seara!”
        public static void Exercitiu16()
        {
            Console.WriteLine("Introduceti o ora a zilei: ");
            int ora = Convert.ToInt32(Console.ReadLine());
            if (ora > 0 && ora < 12)
            {
                Console.WriteLine("Buna dimineata!");
            }
            else if (ora < 17)
            {
                Console.WriteLine("Buna ziua!");
            }
            else
            {
                Console.WriteLine("Buna seara!");
            }
        }

        //17.Cititi de la tastatura o inaltime a unei persoane in cm si afisati: daca inaltimea este < 150 cm afisati: “Aceasta persoana este miniona”, daca inaltimea este intre 150 si 165, afisati mesajul: “Aceasta persoana este mica de statura”. Daca inaltimea este intre 165 si < 195 afisati mesajul:”Aceasta persoana este inalta”. In caz contrar afisati :”Aceasta persoana este foarte inalta”.
        public static void Exercitiu17()
        {
            Console.WriteLine("Introduceti inaltimea unei persoane in cm: ");
            int inaltime = Convert.ToInt32(Console.ReadLine());
            if (inaltime < 150)
            {
                Console.WriteLine("Aceasta persoana este miniona");
            }
            else if (inaltime < 165)
            {
                Console.WriteLine("Aceasta persoana este mica de statura");
            }
            else
            {
                Console.WriteLine("Aceasta persoana este foarte inalta");
            }
        }

        //18.Cititi 3 numere de la tastatura si afisati cel mai mare numar.
        public static void Exercitiu18()
        {
            Console.WriteLine("Introduceti un numar: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti un numar: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti un numar: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine($"{a} este numarul cel mai mare");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"{b} este numarul cel mai mare");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine($"{c} este numarul cel mai mare");
            }
            else
            {
                Console.WriteLine("Doua sau trei din numerele introduse sunt egale");
            }
        }

        //19.Cititi de la tastatura 2 numere.Faceti un calculator care sa accepte operatiile +,-,*,/ si sa afiseze rezultatul:
        public static void Exercitiu19()
        {
            Console.Write("Introduceti un numar: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti un numar: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti un operator (+, -, *, /) : ");
            char op = Convert.ToChar(Console.ReadLine());
            int rezultat;
            if (op == '+')
            {
                rezultat = a + b;
                Console.WriteLine($"{a} + {b} = {rezultat}");
            }
            else if (op == '-')
            {
                rezultat = a - b;
                Console.WriteLine($"{a} - {b} = {rezultat}");
            }
            else if (op == '*')
            {
                rezultat = a * b;
                Console.WriteLine($"{a} * {b} = {rezultat}");
            }
            else if (op == '/')
            {
                rezultat = a / b;
                Console.WriteLine($"{a} / {b} = {rezultat}");
            }
            else
            {
                Console.WriteLine("Eroare!");
            }
        }

    }
}
