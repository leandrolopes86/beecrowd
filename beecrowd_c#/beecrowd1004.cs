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
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());

        int prod = A * B;

        Console.WriteLine($"PROD = {prod}");
    }
}

