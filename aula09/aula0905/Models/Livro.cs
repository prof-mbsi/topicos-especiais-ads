using System;

namespace aula0905.Models {
    public class Livro{

        public string Titulo { get; set; }
        public Autor Autor { get; set; }
        public int Ano { get; set; }

        public Livro(string titulo, Autor autor, int ano){
            this.Titulo = titulo;
            this.Autor = autor;
            this.Ano = ano;
        }

        public void exibirLivro(){
            Console.WriteLine($"Livro: {Titulo}, autor: {Autor.Nome}, país: {Autor.Nacionalidade}, ano: {Ano}");
        }
    }
}