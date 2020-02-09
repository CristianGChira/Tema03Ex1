using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema03Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            // ex 1: Scrieti un program care stocheaza intr-un vector 3 variabile de tip double declarate de voi si le afiseaza parcurgand vectorul.

            Console.WriteLine("ex 1");
            double[] variabile = new double[] { 2.51, 4.7, 3.9 };
            for (int i=0; i<variabile.Length; i++)
            {
                Console.WriteLine("Elementul de la pozitia " + i + " este: " + variabile[i]);
            }
            Console.ReadKey();

            // ex 2: Scrieti un program care afiseaza minimul , respectiv maximul dintr-un array de lungime 10.

            Console.WriteLine();
            Console.WriteLine("ex 2");

            int[] vector = new int[10];
            vector[0] = 2;
            vector[1] = 9;
            vector[2] = 8;
            vector[3] = -5;
            vector[4] = 7;
            vector[5] = 3;
            vector[6] = 0;
            vector[7] = 11;
            vector[8] = 14;
            vector[9] = 5;

            Console.WriteLine("Minimul este "+ vector.Min());
            Console.WriteLine("Maximul este " + vector.Max());

            Console.ReadKey();

            // ex 3: Scrieti o clasa ce declara un array de tip int cu o singura valoare negativa si restul pozitive.
            // Afisati pozitia valorii negative din array.

            Console.WriteLine();
            Console.WriteLine("ex 3");

            int[] arr = new int[] { 7, 11, 14, -5, 8, 1 };

            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine("Elementul negativ din array se afla la pozitia " + i + " si are valoarea " + arr[i]);
                }
            }
            Console.ReadKey();

            // ex 4: Scrieti o clasa ce transforma un String intr-un array de caractere.

            Console.WriteLine();
            Console.WriteLine("ex 4");

            String sir = "Acesta este un sir de caractere.";
            char[] sirDeCaractere = new char[sir.Length];

            for(int i=0; i<sir.Length; i++)
            {
                sirDeCaractere[i] = sir[i];
            }
            for(int j=0; j<sir.Length; j++)
            {
                Console.WriteLine("Caracterul de la pozitia " + j + " este " + sirDeCaractere[j]);
            }
            Console.ReadKey();

            // ex 5: Transformati un sir de caractere astfel: fiecare litera de pe pozitie para sa fie uppercase. 

            Console.WriteLine();
            Console.WriteLine("ex 5");

            String sir2 = "Text proba pentru exercitiul 5";
            char[] sirDeCaractere2 = new char[sir2.Length];

            for (int i = 0; i < sir2.Length; i++)
            {
                if (i%2==0)
                {
                    sirDeCaractere2[i] = sir2.ToUpper()[i];
                }
                else
                {
                    sirDeCaractere2[i] = sir2[i];
                }
                
            }
            String sir2Modificat = new String(sirDeCaractere2);
            Console.WriteLine(sir2Modificat);


            Console.ReadKey();


            // ex 6: Avand un vector de numere intregi, adunati un nr double la valorile stocate
            // si pastrati rezultatul in alt vector corespunzator.

            Console.WriteLine();
            Console.WriteLine("ex 6");


            int[] vector3 = new int[] { 4, 8, 12, 1, 7 };
            double d = 5.2;
            double[] vector3Modificat = new double[vector3.Length + 1];
            for (int i = 0; i < vector3.Length; i++)
            {
                vector3Modificat[i] = (double)vector3[i];
            }
            vector3Modificat[vector3.Length] = d;

            Console.Write(" Vectorul modificat va fi: ");
            for (int j=0; j<vector3Modificat.Length; j++)
            {
                Console.Write(vector3Modificat[j] + " ");
            }
            Console.ReadKey();

        }
    }
}
