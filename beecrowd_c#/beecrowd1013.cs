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
        string[] Dados = Console.ReadLine().Split(' ');    
        
        int A = int.Parse(Dados[0]);
        int B = int.Parse(Dados[1]);
        int C = int.Parse(Dados[2]);
        
        int AB = ((A+B) + Math.Abs(A-B))/2;
        int ABC = ((AB+C) + Math.Abs(AB-C))/2;
        
        Console.WriteLine(ABC + " eh o maior");
        Console.Read();
        }
    }
}