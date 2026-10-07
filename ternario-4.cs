using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira um número inteiro positivo: ");
        int n = int.Parse(Console.ReadLine());
        int soma = 0;

        for (int i = 1; i <= n; i++)
        {
            soma += i;
        }
        Console.WriteLine("A soma é: " + soma);
    }
}
