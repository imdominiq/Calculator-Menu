namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            a:
            double a = 0;
            double b = 0;
            double suma = 0;
            double roznica = 0;
            double iloczyn = 0;
            double iloraz = 0;
            double potega = 0;
            Console.WriteLine("\n\nWybierz operacje, którą chcesz wykonać:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            Console.WriteLine("5. Potęgowanie\n");
            string operacja = Console.ReadLine();


            switch (operacja)
            {
                case "1":
                    {
                        Console.WriteLine("Wybrałeś dodawanie");
                        Console.WriteLine("\nSuma tych liczb: " + dodawanie(suma, a, b));
                        goto a;
                    }
                    break;

                case "2":
                    {
                        Console.WriteLine("Wybrałeś odejmowanie");
                        Console.WriteLine("\nRóżnica tych liczb: " + odejmowanie(roznica, a, b));
                        goto a;
                    }
                    break;

                case "3":
                    {
                        Console.WriteLine("Wybrałeś mnozenie");
                        Console.WriteLine("\nIloczyn tych liczb: " + mnozenie(iloczyn, a, b));
                        goto a;
                    }
                    break;

                case "4":
                    {
                        Console.WriteLine("Wybrałeś dzielenie");
                        Console.WriteLine("\nIloraz tych liczb: " + dzielenie(iloraz, a, b));
                        goto a;
                    }
                    break;

                case "5":
                    {
                        Console.WriteLine("Wybrałeś potegowanie");
                        Console.WriteLine("\nPotega tych liczb: " + Potegowanie.MathPow(iloraz, a, b));
                        goto a;
                    }
                    break;


            }
        }

        static double dodawanie(double suma, double a, double b)
        {
            Console.WriteLine("Podaj pierwsza liczbe:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe:");
            b = Convert.ToInt32(Console.ReadLine());
            suma = a + b;
            return suma;
        }

        static double odejmowanie(double roznica, double a, double b)
        {
            Console.WriteLine("Podaj pierwsza liczbe:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe:");
            b = Convert.ToInt32(Console.ReadLine());
            roznica = a - b;
            return roznica;
        }

        static double mnozenie(double iloczyn, double a, double b)
        {
            Console.WriteLine("Podaj pierwsza liczbe:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe:");
            b = Convert.ToInt32(Console.ReadLine());
            iloczyn = a * b;
            return iloczyn;
        }

        static double dzielenie(double iloraz, double a, double b)
        {
            Console.WriteLine("Podaj pierwsza liczbe:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe:");
            b = Convert.ToInt32(Console.ReadLine());
            iloraz = a / b;
            return iloraz;
        }

    }
}
