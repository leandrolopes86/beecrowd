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
        double[] x = new double[6];
        x[0] = double.Parse(Console.ReadLine());
        x[1] = double.Parse(Console.ReadLine());
        x[2] = double.Parse(Console.ReadLine());
        x[3] = double.Parse(Console.ReadLine());
        x[4] = double.Parse(Console.ReadLine());
        x[5] = double.Parse(Console.ReadLine());
        int positivo = 0;
        double soma = 0;
        double media = 0;

        for (int i = 0; i < 6; i++)
        {
            if (x[i] > 0)
            {
                positivo += 1;
                soma = soma + x[i];
            }
        }
        media = soma / positivo;
        Console.WriteLine($"{positivo} valores positivos");
        Console.WriteLine($"{media.ToString("F1", CultureInfo.InvariantCulture)}");
    }
}