using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());
        int divisores = 0;

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                divisores++;
            }
        }

        if (divisores == 2)
        {
            Console.WriteLine(numero + " é um número primo.");
        }
        else
        {
            Console.WriteLine(numero + " não é um número primo.");
        }
    }
}

