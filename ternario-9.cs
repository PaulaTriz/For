using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Números primos entre 1 e 100:");

        for (int i = 2; i <= 100; i++)
        {
            int divisores = 0;

            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    divisores++;
                }
            }
            if (divisores == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
        
           
        
    