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
        string[] x = Console.ReadLine().Split(' ');
        string[] y = Console.ReadLine().Split(' ');
        double x1 = Double.Parse(x[0]);
        double y1 = Double.Parse(x[1]);
        double x2 = Double.Parse(y[0]);
        double y2 = Double.Parse(y[1]);

        double t1 = Math.Pow((x2 - x1),2);
        double t2 = Math.Pow((y2 - y1),2);

        double t3 = Math.Sqrt(t1 + t2);

        Console.WriteLine($"{t3.ToString("F4", CultureInfo.InvariantCulture)}");
    }
}

