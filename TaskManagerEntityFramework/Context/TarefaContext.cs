using Microsoft.EntityFrameworkCore;
using TaskManagerWithEntityFramework.Models;

namespace TaskManagerWithEntityFramework.Context
{
    public class TarefaContext : DbContext
    {

        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options)
        {

        }
        // Identifica a classe Tarefa como uma tabela.
        public DbSet<Tarefa> Tarefas { get; set; }

    }
}