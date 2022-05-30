using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal class Elevador
    {
        // Declarando as propriedades da classe Elevador.
        public int andarAtual; // Armazena o andar atual em que o elevador está.
        public int totalAndares; // Armazena o número total de andares do prédio.
        public int capacidadeTotal; // Armazena a capacidade total do elevador (número de pessoas).
        public int capacidadeAtual; // Armazena a capacidade atual do elevador (número de pessoas).

        // Declarando os métodos da classe Elevador.

        // Declarando o método construtror da classe Elevador.
        public Elevador()
        {
            capacidadeTotal = 0;
            totalAndares = 0;
            this.andarAtual = 0;
            this.capacidadeAtual = 0;
        }

        // Declarando o método Informar(), para exibir informações sobre o elevador.
        public void Informar()
        {
            Console.WriteLine("\nNo momento, o elevador está no andar: " + andarAtual);
            Console.WriteLine("A capacidade atual do elevador é: " + capacidadeAtual);
            Console.WriteLine("O total andares no prédio é: " + totalAndares);
            Console.WriteLine("A capacidade total deste elevador é: " + capacidadeTotal);
        }

        // Declarando o método Inicializar().
        public void Inicializar(int nrMaxPessoas, int nrMaxAndares)
        {
            capacidadeTotal = nrMaxPessoas;
            totalAndares = nrMaxAndares;
            Console.WriteLine("\nA capacidade deste elevador é de " + capacidadeTotal +
                               " pessoas e o prédio possui " + totalAndares + " andares.");
        }

        // Declarando o método Entrar().
        public void Entrar()
        {
            if (capacidadeAtual < capacidadeTotal)
            {
                capacidadeAtual++;
                int capacidadeOciosa = capacidadeTotal - capacidadeAtual;
                Console.WriteLine("\nVocê entrou no elevador! A capacidade atual é de " + capacidadeAtual +
                                   " pessoas. O elevador ainda suporta " + capacidadeOciosa + " pessoas.");
            }
            else
                Console.WriteLine("\nVocê não pode entrar no elevador, pois a capacidade máxima de " +
                                  capacidadeTotal + " pessoas foi atingida!");
        }

        // Declarando o método Sair().
        public void Sair()
        {
            if (capacidadeAtual > 0)
            {
                capacidadeAtual--;
                int capacidadeOciosa = capacidadeTotal - capacidadeAtual;
                Console.WriteLine("\nVocê saiu do elevador! A capacidade atual é de " + capacidadeAtual +
                                   " pessoas. O elevador ainda suporta " + capacidadeOciosa + " pessoas.");
            }
            else
                Console.WriteLine("\nNão é possível sair.O número de pessoas no elevador é "
                                  + capacidadeAtual);
        }

        // Declarando o método Subir().
        public void Subir()
        {
            if (andarAtual < totalAndares)
            {
                andarAtual++;
                int andaresDisponiveis = totalAndares - andarAtual;
                Console.WriteLine("\nVocê subiu para o " + andarAtual + "º andar. " +
                                  "Ainda é possível subir mais " + andaresDisponiveis + " andares.");
            }
            else
                Console.WriteLine("\nNão é possível subir mais um andar. O elevador está no úlitimo andar!");
        }

        // Declarando o método Descer().
        public void Descer()
        {
            if (andarAtual > 0)
            {
                andarAtual--;
                Console.WriteLine("\nVocê desceu para o " + andarAtual + "º andar. " +
                                  "Ainda é possível descer mais " + andarAtual + " andares.");
            }
            else
                Console.WriteLine("\nNão é possível descer mais um andar. O elevador está no Térreo!");
        }

    }
}
