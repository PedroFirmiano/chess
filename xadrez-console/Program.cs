using System;
using xadrez_console;
using xadrez_console.tabuleiro;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Posicao p;
            p = new Posicao(3, 4);
            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tab);

            Console.WriteLine("Posicao: " + p.ToString());

            
        }
    }
}