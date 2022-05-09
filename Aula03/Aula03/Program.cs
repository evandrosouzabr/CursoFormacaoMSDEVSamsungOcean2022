using System;
using System.Globalization;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Console.WriteLine("Hello World!");
            string nome = "Evandro";
            int idade = 46;
            double saldo = 10.35784;

            Console.WriteLine(nome + " " + idade + " " + saldo);

            //placeholder => lugar para colocar a variável

            Console.WriteLine("{0} tem {1} anos e saldo de {2} reais", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos e saldo de {saldo} reais");

            //para colocar um número máximo de casas decimais
            Console.WriteLine("{0} tem {1} anos e saldo de {2:F2} reais", nome, idade, saldo);

            //para trocar o ponto
            Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture));
            //Console.WriteLine(saldo.ToString("F4",CultureInfo.GetCultureInfo(pt-br)));
            

            //ESTRUTURA CONDICIONAL
            int x = 5;
            Console.WriteLine("Bom dia!");

            //SE X = 5
            if (x == 5)
            {
                Console.WriteLine("Boa tarde!");
            }

            Console.WriteLine("Boa Noite!");
           

            //VAMOS CRIAR UM PROGRAMA ONDE O USUÁRIO IRÁ CRIAR UM NÚMERO E
            //VAMOS RETORNAR SE É PAR OU ÍMPAR
            // % => Módulo (traz o valor do resto da divisão)

            Console.Write("Entre com um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número {0} é par.", numero);
            }
            else
            {
                Console.WriteLine("O número {0} é ímpar.", numero);
            }
             

            //ESTRUTURA CONDICIONAL - ENCADEAMENTOS
            // Vamos perguntar a hora atual para o usuário e dependendo da hora vamos
            // retornar bom dia, boa tard ou boa noite

            Console.Write("Qual é a hora atual: ");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 0 || hora > 24)
            {
                Console.WriteLine("O valor da hora inserido está incorreto!");
            }
            else if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
            */

            // SWITCH CASE BREAK DEFAULT
            Console.Write("Digite um número inteiro: ");
            int valor = int.Parse(Console.ReadLine());
            switch (valor)
            {
                case 1: Console.WriteLine("O valor é: 1"); break;
                case 2: Console.WriteLine("O valor é: 2"); break;
                case 3: Console.WriteLine("O valor é: 3"); break;
                case 4: Console.WriteLine("O valor é: 4"); break;
                case 5: Console.WriteLine("O valor é: 5"); break;
                default: Console.WriteLine("O valor não foi analisado."); break;
            }
        }
    }
}
