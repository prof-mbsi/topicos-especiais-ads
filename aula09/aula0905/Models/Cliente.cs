using System;

namespace aula0905.Models {
    public class Cliente{
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente(string nome, string cpf){
            this.Nome = nome;
            this.Cpf = cpf;
        }
    }
}