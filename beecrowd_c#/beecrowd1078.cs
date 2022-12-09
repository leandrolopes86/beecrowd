using System;

class beecrowd1078
{
    static void Main(string[] args)
    {

        int i;

        i = int.Parse(Console.ReadLine());

        int[] dividendos = { i };

        int[] divisores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        foreach (int divisor in divisores)
        {
            foreach (int dividendo in dividendo)
            {

                long longResult = Math.BigMul(dividendo, divisor);
                Console.WriteLine("{1} x {0} = {2}", dividendo, divisor, longResult);
            }
        }

    }

}