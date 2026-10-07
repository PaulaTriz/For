using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Divisores de " + numero + ":");
        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}