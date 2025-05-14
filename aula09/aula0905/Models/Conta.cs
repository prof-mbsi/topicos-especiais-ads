using System;

namespace aula0905.Models {
    public class Conta{
        public Cliente Titular { get; set; }
        
        private double saldo;
        public double Saldo{
            get { return saldo; }
            set
            {
                if (value >= 0)
                    saldo = value;
                else
                    saldo = 0;
            }
        }

        public Conta(Cliente titular, double saldoInicial){
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void ExibirDados(){
            Console.WriteLine($"Titular: {Titular.Nome}, Saldo: {Saldo:C}");
        }
    }
}