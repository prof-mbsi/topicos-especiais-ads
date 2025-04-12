using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula1104.Models {
    public class Cliente {
        private string nome;
        private string cpf;

        //Getters e setters padrão no formato properties
        public string Nome{
            get;
            set;
        }
        public string Cpf{
            get;
            set;
        }
    }
}