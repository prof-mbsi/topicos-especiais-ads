namespace aula0404.Models{
    public class Produto {
        private string descricao;
        private double preco;
        private int quantidade;

        //Getters e setters
        public void setDescricao(string descricao){
            this.descricao = descricao;
        }
        public string getDescricao(){
            return this.descricao;
        }
        public void setPreco(double preco){
            if(preco > 0){
                this.preco = preco;
            } else{
                Console.WriteLine("O preço não pode ser negativo!");
            }
        }
        public double getPreco(){
            return this.preco;
        }
        public void setQuantidade(int quantidade){
            if(quantidade >= 0){
                this.quantidade = quantidade;
            } else{
                Console.WriteLine("A quantidade não pode ser negativa!");
            }
        }
        public int getQuantidade(){
            return this.quantidade;
        }

        public void exibirProduto(){
            Console.WriteLine($"\nProduto: {descricao}, preço: {preco}, quantidade: {quantidade}");
        }

    }
}