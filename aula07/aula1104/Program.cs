using aula1104.Models;

class Program{
    static void Main(){
        Produto p1 = new Produto();
        p1.Nome = "Agua com gas";
        p1.Preco = -3;
        p1.exibir();

        //Parte 2:
        Cliente c =  new Cliente();
        c.Nome = "João";
        c.Cpf = "2233";
        ContaBancaria cb = new ContaBancaria(c);
        cb.exibir();
    }
}
