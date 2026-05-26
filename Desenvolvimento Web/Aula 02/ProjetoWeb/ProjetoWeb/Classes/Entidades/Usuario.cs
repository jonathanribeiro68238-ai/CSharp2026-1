using ProjetoWeb.Classes.Enumeracoes;

namespace ProjetoWeb.Classes.Entidades
{
    abstract public class Usuario
    {
        //ID, Nome, Email, Senha, Regras

        //PROP
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public TipoRegra Regra { get; set; }

    }
}
