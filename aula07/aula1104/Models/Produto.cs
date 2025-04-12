using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula1104.Models {
    public class Produto {
        private string nome;
        private double preco;

        //Getter e setter com validação no formato properties
        public string Nome{
            get;
            set;
        }
        public double Preco{
            get { return preco; }
            set{
                if(value > 0){
                    preco = value;
                } else {
                    preco = 0;
                }
            }
        }

        public void exibir(){
            Console.WriteLine($"Produto: {Nome}, preço: R${Preco:F2}");
        }
    }
}