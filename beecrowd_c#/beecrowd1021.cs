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
        double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        int div100 = 0;
     
        div100 = (int) valor / 100;
        valor =  valor % 100;

        int div50 = (int)valor / 50;
        valor = valor % 50;

        int div20 = (int)valor / 20;
        valor = valor % 20;

        int div10 = (int)valor / 10;
        valor = valor % 10;

        int div5 = (int)valor / 5;
        valor = valor % 5;

        int div2 = (int)valor / 2;
        valor = valor % 2;
        
        //moedas
        valor = valor * 100;
        int div1 = (int)valor / 100;
        valor = valor % 100;

        int div050 = (int)valor / 50;
        valor = valor % 50;

        int div025 = (int)valor / 25;
        valor = valor % 25;

        int div010 = (int)valor / 10;
        valor = valor % 10;

        int div005 = (int)valor / 5;
        valor = valor % 5;

        int div001 = (int)valor / 1;
        valor = valor % 1;

        Console.WriteLine($"NOTAS:");
        Console.WriteLine($"{div100} nota(s) de R$ 100.00");
        Console.WriteLine($"{div50} nota(s) de R$ 50.00");
        Console.WriteLine($"{div20} nota(s) de R$ 20.00");
        Console.WriteLine($"{div10} nota(s) de R$ 10.00");
        Console.WriteLine($"{div5} nota(s) de R$ 5.00");
        Console.WriteLine($"{div2} nota(s) de R$ 2.00");
        Console.WriteLine($"MOEDAS:");
        Console.WriteLine($"{div1} moeda(s) de R$ 1.00");
        Console.WriteLine($"{div050} moeda(s) de R$ 0.50");
        Console.WriteLine($"{div025} moeda(s) de R$ 0.25");
        Console.WriteLine($"{div010} moeda(s) de R$ 0.10");
        Console.WriteLine($"{div005} moeda(s) de R$ 0.05");
        Console.WriteLine($"{div001} moeda(s) de R$ 0.01");
    }
}

