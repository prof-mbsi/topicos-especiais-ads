namespace aula2305.Models {
    public class Tarefa {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }

        public Tarefa(int id, string descricao, bool concluida)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Concluida = concluida;
        }
    }
}