using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();

            Console.WriteLine("Ingresa primer numero a multiplicar : ");

            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa segundo numero a multiplicar : ");

            int n2 = Convert.ToInt32(Console.ReadLine());

            p.MultSinSigno(n1, n2);

            p.NumeroMayor(); 

        p.DelCampoArray();

            p.ContarPalabra();

            Console.WriteLine("Introduce una palabra y te diré si es palíndroma :) ");
            String palabra = Console.ReadLine();

            if (Palindromo(palabra))
                Console.WriteLine("Es palíndroma");
            else
                Console.WriteLine("NO es palíndroma");

            Console.ReadKey();

        }

    public void MultSinSigno(int num1, int num2)
    {
        int aux = 0;
        for (int i = 0; i < num2; i++)
        {
            aux = aux + num1;
        }

        Console.WriteLine(aux);

        Console.ReadKey();
    }

    public void NumeroMayor()
    {
        int[] arreglo = { 43, 34, 112, 67, 21, 54, 66, 99, 1 };

        int aux = arreglo[0];

        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] > aux)
            {
                aux = arreglo[i];
            }
        }

        Console.WriteLine("\nEl numero mayor del arreglo es : ");
        Console.WriteLine(aux);

        Console.ReadKey();
    }

    public void DelCampoArray()
    {

        String[] myArr = {"hola", "mundo", "", null, "¿",
            "Como Estas", "", "?", };

        Console.WriteLine("Valores del arreglo : ");
        ImprimirArray(myArr);

        Array.Resize(ref myArr, 4);

        Console.WriteLine("Arreglo despues de eliminar NULL, Undefined, 0 y false");
        ImprimirArray(myArr);

        Console.ReadKey();
    }

    public static void ImprimirArray(String[] myArr)
    {
        for (int i = 0; i < myArr.Length; i++)
        {
            Console.WriteLine("   [{0}] : {1}", i, myArr[i]);
        }
        Console.WriteLine();
    }

    public void ContarPalabra()
    {
        string[] palabra = {"hola", "mundo", "Como Estas", "si", "¿",
            "Como Estas", "no", "?","si" };

        string aux = palabra[0];
        int conteo = 1;

        for (int i = 0; i < palabra.Length; i++)
        {
            for (int j = 0; j < palabra.Length - 1; j++)
            {
                if (palabra[i] == palabra[j + 1])
                {
                    conteo++;
                }
                else
                    conteo = 1;
            }

            Console.WriteLine("\n Palabra : " + palabra[i] + " se repite " + conteo + " veces.");

        }

        Console.ReadKey();
    }

    public static Boolean Palindromo(string palabra)
    {
        Console.WriteLine("Función llamada con => " + palabra);

        if (palabra.Length < 2)
            return true;

        Console.WriteLine("Vamos a comparar => " + palabra[0]);

        Console.WriteLine("Con => " + palabra[palabra.Length - 1]);

        if (palabra[0] == palabra[palabra.Length - 1])
            return Palindromo(palabra.Substring(1, palabra.Length - 2));

        return false;
    }

    }
}
