namespace AppTarefas.Models
{
    public class Tarefa
    {
        // Nome da chave primária deve ser Nome da Classe + "Id"
        public int TarefaId { get; set; } // Id é a chave primária
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public bool Concluida { get; set; }
    }
}
