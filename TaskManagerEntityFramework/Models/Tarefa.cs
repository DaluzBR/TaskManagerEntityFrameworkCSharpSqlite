
namespace TaskManagerWithEntityFramework.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public required string Titulo { get; set; }
        public required string Descricao { get; set; }
        public DateTime Data { get; set; }
        public bool Status { get; set; }
    }
}