using System;
using xadrez_console;
using xadrez_console.tabuleiro;
using xadrez;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Hello World!");

                Posicao p;
                p = new Posicao(3, 4);
                Tabuleiro tab = new Tabuleiro(8, 8);


                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));
                Console.WriteLine("Posicao: " + p.ToString());
                Tela.imprimirTabuleiro(tab);


                Console.WriteLine();


            }
            catch(TabuleiroException e) 
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}