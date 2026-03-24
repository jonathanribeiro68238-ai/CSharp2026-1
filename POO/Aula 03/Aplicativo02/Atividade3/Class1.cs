using System;

class program

namespace Atividade3
{
    internal class Aluno
    {
        public string NomeDoAluno;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double Resultado;
        public double NotaFinal()
        {
            return Resultado = Nota1 + Nota2 + Nota3;
        }

        public bool AprovadoOuReprovado()
        {
            if (NotaFinal() < 60) {
                return true; 
            }
            else
            {
                return false;
            }
       }

        public double Ponto()
        {
            return 60 - Resultado;
        }
    }
}
