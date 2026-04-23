
using Estudante.Classes.Entidades;


using var context = new AlunoContext();

context.Database.EnsureCreated();

Aluno pessoa1 = new Aluno("Cloaldo", 12345, "DEV");
context.Alunos.Add(pessoa1);
context.SaveChanges();