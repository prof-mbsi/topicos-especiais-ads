using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula1104.Models {
    public class ContaBancaria {
        private Cliente titular;
        private int numero;

        //Construtor que recebe parâmetro
        public ContaBancaria(Cliente titular){
            Titular = titular;
        }

        //Getters e setters padrão no formato properties
        public Cliente Titular{
            get; 
            set;
        }
        public int Numero{
            get;
            set;
        }
        public void exibir(){
            Console.WriteLine($"Titular: {Titular.Nome}, Número: {Numero}, CPF: {Titular.Cpf}");
        }
    }
}