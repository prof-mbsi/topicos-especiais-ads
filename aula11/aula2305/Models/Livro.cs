namespace aula2305.Models {
    public class Livro {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }

        public Livro(int id, string titulo, int ano) {
            this.Id = id;
            this.Titulo = titulo;
            this.Ano = ano;
        }
    }
}