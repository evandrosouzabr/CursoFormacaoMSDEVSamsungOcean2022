using System;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Primeiro o tipo, depois o nome, somente depois a atribuição.
            int prmeiro = 1;
            int segundo = 10;
            int terceiro = 20;

            // Quando temos um + com strig, o C# entende que é uma junção.
            // Quanto temos + com números (int), o C# entende que é soma.

            Console.WriteLine("Soma de todos: " + (prmeiro + segundo + terceiro));
            Console.WriteLine("Subtração de todos: " + (terceiro - segundo - prmeiro));
            Console.WriteLine("Multiplicação de todos: " + (terceiro * segundo * prmeiro));
            Console.WriteLine("Divisão de todos: " + (terceiro / segundo / prmeiro));
            

            // Operador de atribuição
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine("---------");
            a += 2;
            Console.WriteLine(a);
            Console.WriteLine("---------");
            a *= 3;
            Console.WriteLine(a);
            Console.WriteLine("---------");

            // Utilizando atribuiçã para string
            string s = "ABC";
            Console.WriteLine(s);
            Console.WriteLine("---------");
            s += "DEF";
            Console.WriteLine(s);
            Console.WriteLine("---------");
            

            // Operadores Relacionais
            // Têm o efeito de comparar um dado com o outro
            // Sempre teremos dois resultados possíveis: true ou false (booleano)
            int a = 10;
            bool resposta1 = a < 10;
            bool resposta2 = a < 20;
            bool resposta3 = a > 10;
            bool resposta4 = a > 5;
            bool resposta5 = a >= 10;
            bool resposta6 = a != 10;
            bool resposta7 = a == 10;

            Console.WriteLine(resposta1);
            Console.WriteLine(resposta2);
            Console.WriteLine(resposta3);
            Console.WriteLine(resposta4);
            Console.WriteLine(resposta5);
            Console.WriteLine(resposta6);
            Console.WriteLine(resposta7);
            

            // Análise de falso e verdadeiro dos lados

            // && => espera que as condições sejam true, então, se uma condição for false
            // ele vai devolver false
            bool resposta1 = 2 > 3 && 4 != 5;
            Console.WriteLine(resposta1);

            // || => se uma condição for true, vai retornar true
            bool resposta2 = 2 > 3 || 4 != 5;
            Console.WriteLine(resposta2);

            // ! => NÃO
            bool resposta3 = !(2 > 3) || 4 != 5;
            Console.WriteLine(resposta3);
            */

            // Entrada de dados
            Console.WriteLine("--------------------");
            Console.WriteLine("| Entrada de dados |");
            Console.WriteLine("--------------------");
            Console.Write("Digite seu nome: ");

            //Console.Readline() => Lê a linha que o usuário digitou e aguarda a tecla Enter
            string nome = Console.ReadLine();
            Console.WriteLine($"Seu nome é {nome}.");

        }
    }
}
