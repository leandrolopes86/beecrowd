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

        int div100 = x / 100;
        int rest100 = x % 100;

        int div50 = rest100 / 50;
        int rest50 = rest100 % 50;

        int div20 = rest50 / 20;
        int rest20 = rest50 % 20;

        int div10 = rest20 / 10;
        int rest10 = rest20 % 10;

        int div5 = rest10 / 5;
        int rest5 = rest10 % 5;

        int div2 = rest5 / 2;
        int rest2 = rest5 % 2;

        int div1 = rest2 / 1;
        int rest1 = rest2 % 1;

        Console.WriteLine($"{x}");
        Console.WriteLine($"{div100} nota(s) de R$ 100,00");
        Console.WriteLine($"{div50} nota(s) de R$ 50,00");
        Console.WriteLine($"{div20} nota(s) de R$ 20,00");
        Console.WriteLine($"{div10} nota(s) de R$ 10,00");
        Console.WriteLine($"{div5} nota(s) de R$ 5,00");
        Console.WriteLine($"{div2} nota(s) de R$ 2,00");
        Console.WriteLine($"{div1} nota(s) de R$ 1,00");
    }
}

