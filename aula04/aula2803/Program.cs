using System;

class Program{

    static void Main(){

        //Criação de array pré-definido
        int[] numeros1 = { 15, 30, 7, 90, 45 };
        //Método Max(): retorna maior valor de um array numérico
        Console.WriteLine($"Maior: {numeros1.Max()}");
        //Método Min(): retorna menor valor de um array numérico
        Console.WriteLine($"Menor: {numeros1.Min()}");
        //Método Sum(): retorna a soma dos valores de um array numérico
        int soma = numeros1.Sum();
        Console.WriteLine($"Soma total: {soma}");
        //Método Average(): retorna a média dos valores de um array numérico
        double media = numeros1.Average();
        Console.WriteLine($"A média dos valores é: {media}");

        //Exercício 4: Contar números pares e ímpares
        int[] numeros2 = new int[5];
        int pares = 0, impares = 0;

        //Percorre as posições do array
        for (int i = 0; i < numeros2.Length; i++)
        {
            //Armazena os números informados pelo usuário
            Console.Write($"Digite o {i+1}º número: ");
            numeros2[i] = int.Parse(Console.ReadLine());

            if (numeros2[i] % 2 == 0)
                //Se é divisível por 2, soma mais um na variável pares
                pares++;
            else
                //Senão, soma mais um em impares
                impares++;
        }
        //Exibe as quantidades
        Console.WriteLine($"Quantidade de números pares: {pares}");
        Console.WriteLine($"Quantidade de números ímpares: {impares}");

    }

}