using System;

namespace Exercicio02
{
    internal class Program
    {
        static void ConstroiTela(String[] args)
        {
            /* Definindo cores e posição do texto no terminal em C#
           Console.BackgroundColor = ConsoleColor.DarkRed;
           Console.ForegroundColor = ConsoleColor.DarkYellow;
           Console.SetCursorPosition(119, 23);
           Console.WriteLine("H");
           */
            //Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("╔");

            //Declarando o vetor para tela horizontal
            char[] telaH = new char[119];
            for (int i = telaH.Length - 1; i >= 2; i--)
            {
                Console.Write("═");
            }
            //Console.SetCursorPosition(0, 120);
            Console.Write("╗");
            //Declarando o vetor para tela vertical
            char[] telaV = new char[23];
            for (int i = telaV.Length - 1; i >= 1; i--)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("║");
                Console.SetCursorPosition(118, i);
                Console.Write("║");
            }
            Console.SetCursorPosition(0, 23);
            Console.Write("╚");

            for (int i = telaH.Length - 1; i >= 2; i--)
            {
                Console.Write("═");
            }
            Console.Write("╝");
        }
        static void Main(string[] args)
        {
            ConstroiTela(args);
            Console.SetCursorPosition(3, 1);
            Console.Write("PROGRAMA - CÁCLULO DE MÉIDA DE IDADE DOS ALUNOS");
            Console.SetCursorPosition(3, 3);
            Console.Write("Informe o número de alunos a serem cadastrados: ");
            int qtdAlunos = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Quantidade de Alunos registrados: {0}",  qtdAlunos);
            ConstroiTela(args);
        }

    }
}
