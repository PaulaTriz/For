using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;

        for (int i = 2; i <= 100; i += 2)
        {
            soma += i;
        }
        Console.WriteLine("A soma dos números pares entre 1 e 100 é: " + soma);
    }
}
