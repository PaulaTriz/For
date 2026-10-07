using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantos números deseja inserir? ");
        int quantidade = int.Parse(Console.ReadLine());

        if (quantidade <= 0) return;

        Console.Write("Insira o 1º número: ");
        int maior = int.Parse(Console.ReadLine());

        for (int i = 2; i <= quantidade; i++)
        {
            Console.Write("Insira o " + i + "º número: ");
            int numero = int.Parse(Console.ReadLine());
        }
    }
}