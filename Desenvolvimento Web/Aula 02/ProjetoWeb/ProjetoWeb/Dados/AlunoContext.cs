using Microsoft.EntityFrameworkCore;
using ProjetoWeb.Classes.Entidades;



namespace ProjetoWeb.Dados
{
    public class AlunoContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server = ECFP507D1319377\SQLEXPRESS01; Database =
                    Aluno;Trusted_Connection = True;
                    TrustServerCertificate = True;"
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>(
                entity =>
                {
                    entity.HasKey(e => e.Id);
                    entity.Property(e => e.Name).IsRequired(); //Name
                    entity.Property(e => e.Email); //Email
                    entity.Property(e => e.Senha); //Senha
                    entity.Property(e => e.CursoId).IsRequired(); //Curso
                    entity.Property(e => e.RA).IsRequired(); //RA
                    entity.Property(e => e.StatusAction).IsRequired(); //StatusAction
                    entity.Property(e => e.StatusWIFI).IsRequired(); //StatusWIFI
                    
                }
                
                );
        }
    }
}
