using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Entidades;

namespace SistemaBancario.Classes.Contextos

{
    internal class BancoContext : DbContext
    {
        ///<summary>
        /// banco de dados
        /// 
        /// Db permite realizar operações CRUD
        /// </summary>
        public DbSet<Banco> contas {  get; set; }

        // metodos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use a file-based SQLite database to avoid dependency on LocalDB/SQL Server
            // which may not be available on the machine. This keeps the app self-contained
            // and avoids the LocalDB startup error described in the issue.
            optionsBuilder.UseSqlite("Data Source=BancoDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banco>(
                entity =>
            {
                entity.HasKey(e=>e.Id);
                entity.Property(e => e.NumeroConta).IsRequired();
                entity.Property(e => e.Titular).IsRequired().HasMaxLength(50);
                // Use decimal(18,2) which is a valid SQL Server column type for monetary values
                entity.Property(e => e.Saldo).HasColumnType("decimal(18,2)");
            }


            );
        }
    }
}
