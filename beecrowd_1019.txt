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
        int x = Convert.ToInt32(Console.ReadLine());

        int h = x / 3600;
        int resth = x % 3600;

        int m = resth / 60;
        int s = resth % 60;

       /* Console.WriteLine($"{h}");
        Console.WriteLine($"{m}");
        Console.WriteLine($"{s}"); */
        Console.WriteLine($"{h}:{m}:{s}");
    }
}

