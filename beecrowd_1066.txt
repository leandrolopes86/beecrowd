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
        int tamanho = 5;
        double[] x = new double[tamanho];
        x[0] = double.Parse(Console.ReadLine());
        x[1] = double.Parse(Console.ReadLine());
        x[2] = double.Parse(Console.ReadLine());
        x[3] = double.Parse(Console.ReadLine());
        x[4] = double.Parse(Console.ReadLine());
       // x[5] = double.Parse(Console.ReadLine());
        int positivo = 0;
        int negativo = 0;
        int par = 0;
        int impar = 0;
        //double media = 0;

        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] % 2 == 0)
            {
                par += 1;
            } else
            {
                impar += 1;
            }
            if (x[i] > 0)
            {
                positivo+= 1;
            }
            else if (x[i] < 0)
            {
                negativo+= 1;
            }
        }
        Console.WriteLine($"{par} valor(es) par(es)");
        Console.WriteLine($"{impar} valor(es) impar(es)");
        Console.WriteLine($"{positivo} valor(es) positivo(s)");
        Console.WriteLine($"{negativo} valor(es) negativo(s)");

    }
}