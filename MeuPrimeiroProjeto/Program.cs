using System;

class Program{

    static void Main(){
        Console.WriteLine("Hello, World! ;) ");

        // Solicita o nome do usuário
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        // Solicita a idade do usuário
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        // Exibe uma mensagem personalizada
        Console.WriteLine($"\nOlá, {nome}! Você tem {idade} anos.");

    }

}
