using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira um número inteiro positivo: ");
        int limite = int.Parse(Console.ReadLine());

        for (int i = 0; i <= limite; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}