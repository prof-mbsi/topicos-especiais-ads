using System;

class Program{
    static void Main(){
        /* Exercício 1: Receber nome e salário de um funcionário e 
        formatar a saída:
        */
        Console.WriteLine("Exercício 1:");
        Console.WriteLine("Informe o nome do funcionário");
        //Guarda a string digitada em nome
        string nome = Console.ReadLine();
        Console.WriteLine("Informe o salário do funcionário: ");
        //Guarda o valor digitado em salario fazendo a conversão (parse)
        //para double
        double salario = double.Parse(Console.ReadLine());
        //Formata a saída conforme solicitado
        Console.WriteLine($"Olá {nome}, o salário é de {salario}");

        /* Exercício 2: Receba 2 inteiros e exiba a soma:
        */
        Console.WriteLine("\nExercício 2:");
        Console.WriteLine("Informe valor inteiro para a: ");
        //Guarda o valor digitado em a fazendo a conversão (parse)
        //para int
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe valor inteiro para b: ");
        //Guarda o valor digitado em b fazendo a conversão (parse)
        //para int
        int b = int.Parse(Console.ReadLine());
        //Calcula a soma
        int soma = a + b;
        //Formata a saída
        Console.WriteLine($"Soma de {a} de {b} é {soma}");

        /* Exercício 3: Receba 2 doubles e exiba a média:
        */
        Console.WriteLine("\nExercício 3:");
        Console.WriteLine("Informe valor double para c: ");
        //Guarda o valor digitado em c fazendo a conversão (parse)
        //para double
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe valor double para d: ");
        //Guarda o valor digitado em d fazendo a conversão (parse)
        //para double
        double d = double.Parse(Console.ReadLine());
        //Calcula a média
        double media = (c + d) / 2;
        //Formata a saída
        Console.WriteLine($"Média entre {c} e {d} é {media}");

        /* Exercício 4: Faça uma calculadora com as 4 operações 
        básicas:
         - entrada 1: double
         - entrada 2: double
         - operação (+, -, *, /): string
        */
        Console.WriteLine("\nExercício 4:");
        Console.WriteLine("Informe primeiro valor: ");
        //Guarda o valor digitado em e fazendo a conversão (parse)
        //para double
        double e = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe operação +, -, *, /: ");
        //Guarda a string digitada em op
        string op = Console.ReadLine();
        Console.WriteLine("Informe segundo valor: ");
        //Guarda o valor digitado em f fazendo a conversão (parse)
        //para double
        double f = double.Parse(Console.ReadLine());
        //Cria uma variável para armazenar o resultado
        double resultado = 0;
        //Escolhe a operação com base na variável op
        switch(op){
            //Caso op == +, faz a soma
            case "+":
                resultado = e + f;
                //termina o switch após encontrar o caso adequado
                break;
            //Caso op == -, faz a subtração
            case "-":
                resultado = e - f;
                break;
            //Caso op == *, faz a multiplicação
            case "*":
                resultado = e * f;
                break;
            //Caso op == /, faz a divisão
            case "/":
                resultado = e / f;
                break;
            //Caso op receba outro valor, exibe mensagem de erro
            default:
                Console.WriteLine("Operação inválida!");
                break;
        }
        //Formata a saída
        Console.WriteLine($"{e} {op} {f} = {resultado}");
    }
}