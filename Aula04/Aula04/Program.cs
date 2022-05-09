using System;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array ("Vetor") é uma sequência não ordenada de itens.
            //Todos os item em um Arrey devem ser do mesmo tipo.
            int[] numeros_loteria = { 4, 8, 15, 16, 23, 42 };
            int i = 0;

            for (i = 0; i < numeros_loteria.Length; i++)
            {
                Console.WriteLine(numeros_loteria[i]);
            }
        }

        static void For ()
        {
            // FOR => para
            // i => contador
            // i = 1 => inicia em 1
            // i <= 50 => condição para a quantidade/controle
            // i++ => Controle que vai adicionar +1 em i até chegar na condição de controle.

            int i;
            for (i = 0; i <= 50; i = (i + 3))
            {
                Console.WriteLine(i);
            }
        }

        static void DoWhile02()
        {
            int numero;
            do
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("O número digitado foi: {0}", numero);
            }
            while (numero != 10);
        }

        static void DoWhile01()
        {
            int numero = 1;
            do
            {
                Console.Write(numero + ", ");
                numero++;
            }
            while (numero <= 50);
        }

        static void While()
        {
            int numero, soma;
            soma = 0;
            Console.Write("Informe um número: ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                soma += numero;
                Console.Write("Informe um número: ");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A soma dos números inseridos é: {0}", soma);

            //F9 => indica onde será inciado o debug.
            //F10 => debuga o programa linha por linha
        }

        static void SwitchCase()
        {
            Console.WriteLine("São Paulo/SP a Belo Horizonte/MG");
            Console.Write("Escolha o transporte - [a]Avião | [c]Carro | [o]Ônibus: ");

            char escolha;
            int tempo = 0;

            //Conversão de string para char
            //ToLower = converte string para minúsculo
            //ToUpper = converte strig para maiúsculo
            escolha = char.Parse(Console.ReadLine().ToLower());

            switch (escolha)
            {
                case 'a':
                    tempo = 50;
                    break;
                case 'c':
                    tempo = 480;
                    break;
                case 'o':
                    tempo = 720;
                    break;
                default:
                    tempo = -1;
                    break;
            }

            if (tempo < 0)
                Console.WriteLine("O transporte informado não está disponível.");
            else
                Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos.", tempo);
        }
    }
}
