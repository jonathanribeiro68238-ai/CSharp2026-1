using static System.Console;
//Problena N rainhas
static void pode_colocar (int tabuleiro, int linha, int coluna, int n)
{
    for (int i = 0; i < linha; i++)
    {
        if (tabuleiro == coluna | (tabuleiro - i) == (coluna-lina) | (tabuleiro + i) == (coluna +linha))
        {
            return false;
        }
        else
        {
            return true;
        }

    }

}
static void resolver_n_rainhas(int tabuleiro, int linha, int coluna, int n)
{
    if (linha = n)
    {
        Write(tabuleiro);
        return true;
    }

    for(coluna; coluna < n; coluna++)
    {
        if (pode_colocar(tabuleiro, linha, coluna, n))
        {
            tabuleiro[linha] = coluna;
            resolver_n_rainhas(tabuleiro, linha + 1, 0, n);
            tabuleiro[linha]
        }
    }
}
//-----declaração de variaveis
int n;
//----------processamento de dados