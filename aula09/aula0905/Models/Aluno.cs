using System;

namespace aula0905.Models {
    public class Aluno{
        string Nome { get; set; }
        double Nota1 { get; set; }
        double Nota2 { get; set; }

        public Aluno(string nome, double n1, double n2){
            this.Nome = nome;
            this.Nota1 = n1;
            this.Nota2 = n2;
        }

        public double calcularMedia(){
            return (Nota1 + Nota2) / 2;
        }

        public void exibirResultado(){
            double media = calcularMedia();
            if(media >= 6){
                Console.WriteLine($"Média:{media} .Aprovado!");
            } else{
                if(media >= 4 && calcularMedia() < 6){
                    Console.WriteLine($"Média:{media} .Precisa de substitutiva!");
                } else{
                    Console.WriteLine($"Média:{media} .Reprovado!");
                }
            }
        }
    }
}