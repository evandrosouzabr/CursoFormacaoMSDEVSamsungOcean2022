using System;
using ProjetoElevador.Model;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Sistema de Gerenciamento do Elevador");
            Elevador novoElevador = new Elevador();

            // Inicializando o elevador.
            Console.Write("\nInforme a capacidade total do elevador: ");
            int nrMaxPessoas = int.Parse(Console.ReadLine());
            Console.Write("Informe o total de andares no prédio: ");
            int nrMaxAndares = int.Parse(Console.ReadLine());
            novoElevador.Inicializar(nrMaxPessoas, nrMaxAndares);

            // Loop para interação com o usuário até que ele escolha finalizar.
            int opcao = 0;
            while (opcao < 5)
            {
                novoElevador.Informar();
                Console.Write("\n[1] - Entrar no elevador." +
                                 "\n[2] - Sair do elevador." +
                                 "\n[3] - Subir um andar." +
                                 "\n[4] - Descer um andar." +
                                 "\n[5] - Finalizar." +
                                 "\nEscolha uma das opções acima: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        novoElevador.Entrar();
                        break;
                    case 2:
                        novoElevador.Sair();
                        break;
                    case 3:
                        novoElevador.Subir();
                        break;
                    case 4:
                        novoElevador.Descer();
                        break;
                    case 5:
                        Console.WriteLine("\nVocê escolheu finalizar!");
                        break;
                }
            }
        }
    }
}
