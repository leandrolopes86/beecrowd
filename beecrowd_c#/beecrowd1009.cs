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
        string nome = Console.ReadLine();
        double salario = double.Parse(Console.ReadLine());
        double vendas = double.Parse(Console.ReadLine());

        salario = salario + (vendas * 0.15);

        //Console.WriteLine($"{nome}");
        Console.WriteLine($"TOTAL = R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}

