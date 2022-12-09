using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Serialization;
//using System.Net.Http.Headers;

public class beecrowd
{
    public static void Main(string[] args)
    {

        int numero = int.Parse(Console.ReadLine());

        int positivo = 0;
        int negativo = 0;
        int par = 0;
        int impar = 0;

        for (int i = 1; i <= numero; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine($"{i}");
            }
        }

    }
}