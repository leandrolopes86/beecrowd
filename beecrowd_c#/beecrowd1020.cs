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

        int ano = x / 365;
        int restano = x % 365;

        int mes = restano / 30;
        int dia = restano % 30;

        Console.WriteLine($"{ano} ano(s)");
        Console.WriteLine($"{mes} mes(es)");
        Console.WriteLine($"{dia} dia(s)"); 
        //Console.WriteLine($"{ano}:{mes}:{dia}");
    }
}

