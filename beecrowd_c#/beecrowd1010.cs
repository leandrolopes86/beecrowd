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
        double prod1 = Convert.ToInt32(x[0]);
        double qtde1 = Convert.ToInt32(x[1]);
        double preco1 = Double.Parse(x[2]);
        double prod2 = Convert.ToInt32(y[0]);
        double qtde2 = Convert.ToInt32(y[1]);
        double preco2 = Double.Parse(y[2]);

        double valor = (qtde1 * preco1) + (qtde2 * preco2);
        
        Console.WriteLine($"VALOR A PAGAR: R$ {valor.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}