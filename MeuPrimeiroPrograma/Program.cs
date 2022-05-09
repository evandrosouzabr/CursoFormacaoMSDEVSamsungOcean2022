using System;

namespace MeuPrimeiroPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da conta: ");
            var valorConta = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da taxa (entre 0 e 100): ");
            var porcentagemTaxa = double.Parse(Console.ReadLine());
            var valorTaxa = valorConta * porcentagemTaxa / 100;
            var valorTotal = valorConta + valorTaxa;
            Console.WriteLine($"O valor da conta foi de {valorConta:C}.");
            Console.WriteLine($"A taxa do garçom foi de {valorTaxa:C}.");
            Console.WriteLine($"O total da conta ficou em {valorTotal:C}.");

        }
    }
}
