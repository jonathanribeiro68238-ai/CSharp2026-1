using Microsoft.EntityFrameworkCore;
using ProjetoWeb.Classes.Entidades;



namespace ProjetoWeb.Dados
{
    public class AlunoContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}
