namespace Tabuleiro
{
    //Em qual linha e coluna uma peça está
    class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return Linha + "," + Coluna;
        }
    }
}
