using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira uma palavra: ");
        string palavra = Console.ReadLine();

        for (int i = 0; i < palavra.Length; i++)
        {
            Console.WriteLine(palavra[i]);

        }
    }
}