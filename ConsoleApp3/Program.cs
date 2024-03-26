using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Números Ímpares");
        Console.WriteLine("2 - Números Pares");

        int escolha = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Os números são:");
          
        for (int i = escolha; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }

        Console.ReadKey();
    }
}


