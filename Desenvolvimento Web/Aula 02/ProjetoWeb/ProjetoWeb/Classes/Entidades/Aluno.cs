using ProjetoWeb.Classes.Enumeracoes;

namespace ProjetoWeb.Classes.Entidades
{
    public class Aluno : Usuario
    {
        //PROP
        public int RA {  get; set; }

        public int StatusWIFI { get; set; }

        public string StatusAction { get; set; } = "Aguardando aprovação";

        public Cursos CursoId { get; set; }

        public TipoRegra Regra { get; set; } = TipoRegra.Usuario;
    }
}
