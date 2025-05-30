namespace aula3005.Models{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public Produto(int id, string nome, int quantidade, double preco)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        public string ToString() {
            return $"Id = {this.Id}, Nome = {this.Nome}, Qtd = {this.Quantidade}, Preço: {this.Preco}";
        }
    }
}