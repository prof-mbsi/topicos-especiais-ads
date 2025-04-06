namespace aula0404.Models{
    class Livro{
        // Atributos privados
        private string titulo;
        private string autor;
        private int ano;

        // Getters e setters
        public void setTitulo(string titulo){
            this.titulo = titulo;
        }
        public string getTitulo(){
            return this.titulo;
        }
        public void setAutor(string autor){
            this.autor = autor;
        }
        public string getAutor(){
            return this.autor;
        }
        public void setAno(int ano){
            this.ano = ano;
        }
        public int getAno(){
            return this.ano;
        }

        // Método para exibir os dados do livro
        public void exibirLivro(){
            Console.WriteLine($"\n---Livro---");
            Console.WriteLine($"Título: {this.titulo}");
            Console.WriteLine($"Autor: {this.autor}");
            Console.WriteLine($"Ano: {this.ano}");
        }
    }
}