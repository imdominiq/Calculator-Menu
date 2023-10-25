using System;
namespace Calculator
{
    public class Potegowanie
    {
            public static double MathPow(double potega, double a, double b)
            {
                Console.WriteLine("Podaj pierwsza liczbe:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj druga liczbe:");
                b = Convert.ToInt32(Console.ReadLine());
                potega = Math.Pow(a, b);
                return potega;
            } 
    }
}
