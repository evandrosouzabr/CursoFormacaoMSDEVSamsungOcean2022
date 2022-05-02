using System;
using System.Globalization;

namespace CursoFormacaoMSDEVSamsungOcean2022
{
    internal class Aula04Exercicio01
    {
        static void Main(string[] args)
        {
            var minhaCultura = new CultureInfo("pt-BR");
            Console.WriteLine("Aula 04 - Exercício 01\n\n");
            Console.Write("Digie o nome do aluno: ");
            string nomeAluno = Console.ReadLine();
            double nota1Aluno, nota2Aluno, nota3Aluno, nota4Aluno;
            Console.Write("Digie a nota 1 do {0}: ",nomeAluno);
            nota1Aluno = double.Parse(Console.ReadLine());
            Console.Write("Digie a nota 2 do {0}: ", nomeAluno);
            nota2Aluno = double.Parse(Console.ReadLine());
            Console.Write("Digie a nota 3 do {0}: ", nomeAluno);
            nota3Aluno = double.Parse(Console.ReadLine());
            Console.Write("Digie a nota 4 do {0}: ", nomeAluno);
            nota4Aluno = double.Parse(Console.ReadLine());
            double mediaAluno = ((nota1Aluno + nota2Aluno + nota3Aluno + nota4Aluno) / 4);
            if (mediaAluno >= 6)
            {
                Console.WriteLine("\n{0} foi APROVADO(A) com média: {1}.", nomeAluno, mediaAluno);
            }
            else
            {
                Console.WriteLine("\n{0} foi REPROVADO(A) com média: {1}.", nomeAluno, mediaAluno);
            }
            Console.Write("\n\nTecle ENTER para sair!");
            Console.ReadLine();
        }
    }
}
