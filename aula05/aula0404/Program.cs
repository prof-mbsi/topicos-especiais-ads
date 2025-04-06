using aula0404.Models;

class Program{
    static void Main(){
        Produto p = new Produto();
        p.setDescricao("Água");
        p.setPreco(5.0);
        p.setQuantidade(30);
        p.exibirProduto();

        Livro livro = new Livro();
        livro.setTitulo("A Moreninha");
        livro.setAutor("Joaquim Manuel de Macedo");
        livro.setAno(1844);
        livro.exibirLivro();

        //Acessando os atributos de aluno pelos métodos Properties do C#
        Aluno aluno = new Aluno();
        aluno.Nome = "Carlos";
        aluno.Nota1 = 5.5;
        aluno.Nota2 = 6.5;
        aluno.ExibirResultado();
    }
}