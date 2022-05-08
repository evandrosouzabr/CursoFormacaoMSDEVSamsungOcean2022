using System;

namespace FormacaoCS_Aula04_Exercicio02
{
    internal class Aula04Exercicio02
    {
        static void Main(string[] args)
        {
            //2 - CRIE UM ALGORITMO QUE LÊ 3 NÚMEROS INTEIROS E RETORNE QUAL É O MAIOR

            Console.WriteLine("Aula 04 - Exercício 02\n\n");

            Console.Write("Digie o primeiro número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.Write("Digie o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            Console.Write("Digie o terceiro número: ");
            int terceiroNumero = int.Parse(Console.ReadLine());

            if (primeiroNumero > segundoNumero && primeiroNumero > terceiroNumero)
            {
                Console.WriteLine("O primeiro número é o maior!");
            }
            else if (segundoNumero > primeiroNumero && segundoNumero > terceiroNumero)
            {
                Console.WriteLine("O segundo número é o maior!");
            }
            else if (terceiroNumero > primeiroNumero && terceiroNumero > segundoNumero)
            {
                Console.WriteLine("O terceiro número é o maior!");
            }
            else if (primeiroNumero == segundoNumero && primeiroNumero > terceiroNumero)
            {
                Console.WriteLine("O primeiro e o segundo números são iguais e são maiores que o terceiro número!");
            }
            else if (primeiroNumero == terceiroNumero && primeiroNumero > segundoNumero)
            {
                Console.WriteLine("O primeiro e o terceiro números são iguais e são maiores que o segundo número!");
            }
            else if (segundoNumero == terceiroNumero && segundoNumero > primeiroNumero)
            {
                Console.WriteLine("O segundo e o terceiro números são iguais e são maiores que o primeir0 número!");
            }
            else
            {
                Console.Write("Os três números são iguais!");
            }
        }
    }
}
