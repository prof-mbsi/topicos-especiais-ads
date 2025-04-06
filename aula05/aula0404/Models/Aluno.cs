namespace aula0404.Models{
    class Aluno{
        // Atributos privados
        private string nome;
        private double nota1;
        private double nota2;

        // Getters e setters no formato Properties do C#
        public string Nome{
            get { return nome; }
            set { nome = value; }
        }
        public double Nota1{
            get { return nota1; }
            set { nota1 = value; }
        }
        public double Nota2{
            get { return nota2; }
            set { nota2 = value; }
        }

        // Método para calcular média
        public double CalcularMedia(){
            return (Nota1 + Nota2) / 2;
        }

        // Método para exibir resultado
        public void ExibirResultado()
        {
            double media = CalcularMedia();
            Console.WriteLine($"\n---Aluno---");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Nota 1: {Nota1}");
            Console.WriteLine($"Nota 2: {Nota2}");
            Console.WriteLine($"Média: {media}");
            Console.WriteLine(media >= 6 ? "Situação: Aprovado\n" : "Situação: Reprovado\n");
        }
    }
}