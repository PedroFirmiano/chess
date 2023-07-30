using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor  cor {  get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor )
        {
           
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }

        public abstract bool[,] movimentosPosiveis();

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPosiveis();
            for (int i = 0; i < tab.linhas; i++)
            {

                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPosiveis()[pos.linha, pos.coluna];
        }

        public  void incrementarQtdMovimentos()
        {
            qteMovimentos++;
        }
    }
}
