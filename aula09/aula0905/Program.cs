using System;
using aula0905.Models;

class Program(){
    static void Main(){

        Cliente c1 = new Cliente("Alice", "111");
        Cliente c2 = new Cliente("Bob", "112");
        Cliente c3 = new Cliente("Carla", "113");

        Conta[] contas = new Conta[3];
        contas[0] = new Conta(c1, 1500);
        contas[1] = new Conta(c2, 2000);
        contas[2] = new Conta(c3, 1800);

        Console.WriteLine("Exibição de contas com for iterator:");
        for (int i = 0; i < contas.Length; i++){
            contas[i].ExibirDados();
        }
        
        Console.WriteLine("\nExibição de contas com foreach:");
        foreach (Conta c in contas){
            c.ExibirDados();
        }

        Aluno a1 = new Aluno("Cidadão", 5.5, 8.5);
        Aluno a2 = new Aluno("Fulano", 3.5, 4.0);
        Aluno a3 = new Aluno("Beltrano", 5.5, 4.5);

        //Cria o array com alunos de forma similar à que fazemos em int[] numeros = {1, 2, 3};
        Aluno[] alunos = {
            a1, a2, a3
        };

        Console.WriteLine("\nExibição de alunos com foreach:");
        foreach (Aluno a in alunos){
            a.exibirResultado();
        }

        Autor au1 = new Autor("Clarice Lispector", "Brasil");
        Autor au2 = new Autor("José Saramago", "Portugal");

        //Cria o array instanciando um livro a cada posição
        Livro[] acervo = {
            new Livro("Perto do coração selvagem", au1, 1943),
            new Livro("Terra do Pecado", au2, 1947),
            new Livro("O Lustre", au1, 1946),
            new Livro("A cidade sitiada", au1, 1948),
            new Livro("Ensaio sobre a cegueira", au2, 1995)
        };

        Console.WriteLine("\nExibição de livros com foreach:");
        foreach (Livro l in acervo){
            l.exibirLivro();
        }
    }

}