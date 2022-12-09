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
        int tempo = Convert.ToInt32(Console.ReadLine());
        int velocidade = Convert.ToInt32(Console.ReadLine());
        
        double percurso = (tempo * velocidade);
        double media = percurso / 12;
        
        Console.WriteLine($"{media.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}