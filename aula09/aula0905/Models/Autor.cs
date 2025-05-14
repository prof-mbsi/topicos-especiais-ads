using System;
using System.Runtime.CompilerServices;

namespace aula0905.Models {
    public class Autor{

        public string Nome { get; set; }
        public string Nacionalidade { get; set; }

        public Autor(string nome, string nacionalidade){
            this.Nacionalidade = nacionalidade;
            this.Nome = nome;
        }

    }
}