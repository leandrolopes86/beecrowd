using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Beecrowd
{
    internal class program
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double consumo = (x / y);
            
            Console.WriteLine($"{consumo.ToString("F3", CultureInfo.InvariantCulture)} km/l");
        }
    }
}