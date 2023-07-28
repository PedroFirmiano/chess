using System;
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

            Console.WriteLine("Posicao: " + p.ToString());
        }
    }
}