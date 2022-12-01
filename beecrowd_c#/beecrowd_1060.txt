using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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

        for (int i = 0; i < 6; i++)
        {
            if (x[i] > 0)
            {
                positivo += 1;
            }
        }
        Console.WriteLine($"{positivo} valores positivos");
    }
}