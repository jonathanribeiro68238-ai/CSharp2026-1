using Microsoft.EntityFrameworkCore;
using ProjetoWeb.Classes.Entidades;
using ProjetoWeb.Dados;

namespace ProjetoWeb.Classes.Serv
{
    private readonly AlunoContext _dbContext;
    public class AuthService
    {
    }
        public AuthService(AlunoContext dbContext)
        {
            this.
        }


    public async Task<Aluno?> ValidarLoginAsync(string email, string senha)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(senha))
            {
                return null;
            }
            var aluno = await DbContext.Alunos.FirstOrDefaultAsync(a ==> a.Email == email && a.Senha == senha );

            return aluno;
        }
}
