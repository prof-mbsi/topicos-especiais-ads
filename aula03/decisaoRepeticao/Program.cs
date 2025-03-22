using System;

class Program{
    //Aula03: Estruturas de decisão e repetição
    static void Main(){
        //Exercício 1: Receber um inteiro e informar se é positivo, negativo ou zero
        /**/
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());
        if(num == 0){
            Console.Write("O número informado é 0!");
        } else {
            if(num > 0){
                Console.Write("O número informado é positivo!");
            } else {
                Console.Write("O número informado é negativo!");
            }
        }
        
        //Exercício 2: Informar a nota com base no conceito recebido
        /**/
        Console.Write("Informe um conceito (A, B, C, D): ");
        //Faz a leitura de um char convertendo para maiúsculo facilitando a comparação
        char conceito = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();
        switch (conceito){
            case 'A':
                Console.Write("Nota: de 9,0 a 10!");
                break;
            case 'B':
                Console.Write("Nota: de 7,0 a 8,9!");
                break;
            case 'C':
                Console.Write("Nota: de 4,0 a 6,9!");
                break;
            case 'D':
                Console.Write("Nota: abaixo de 4,0!");
                break;
            default:
                Console.Write("Conceito inválido!");
                break;
        }
        
        //Exercício 3: Receber um inteiro menor que 100 e mostrar sua tabuada 
        /**/
        Console.Write("Informe um número para exibir a tabuada: ");
        int tabuada = int.Parse(Console.ReadLine());
        if(tabuada > 0 && tabuada < 100){
            for(int i = 1; i <= 10; i++){
                Console.WriteLine($"{tabuada} * {i} = {tabuada * i}");
            }
        } else {
            Console.Write("Número fora do intervalo permitido!");
        }
        
        //Exercício 4: Somar inteiros até que o usuário informe 0
        /**/
        int soma = 0, num = 0;
        Console.Write("Informe um número para somar: ");
        num = int.Parse(Console.ReadLine());
        while(num != 0){
            soma += num;
            Console.Write("Informe um número para somar: ");
            num = int.Parse(Console.ReadLine());
        }
        Console.Write($"Total informado = {soma} ");
        
        //Exercício 5: Verificar senha 1234 em, no máximo, 3 tentativas
        /**/
        string senhaCorreta = "1234";
        string senha;
        int tentativas = 0;
        do{
            Console.WriteLine("Digite a senha: ");
            senha = Console.ReadLine();
            tentativas++;
            if(senha == senhaCorreta){
                Console.WriteLine("Acesso permitido!");
                break;
            } else {
                Console.WriteLine("Senha incorreta!");
            }
        } while(tentativas < 3);
        if(senha != senhaCorreta){
            Console.WriteLine("Senha bloqueada!");
        }
    }
}

