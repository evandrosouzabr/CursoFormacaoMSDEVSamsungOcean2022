using System;
using System.Globalization;

namespace FormacaoCS_Aula04_Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * EXERCICIO DE SWITCH
             * ** Aumento de salário de acordo com o cargo**
             * Uma empresa concederá um aumento de salário aos seus funcionários, variável de acordo com o cargo, conforme a tabela abaixo.
             * Programa que lê o salário e o código do cargo de um funcionário e calcula o novo salário.
             * Se o cargo do funcionário não estiver na tabela, ele recebe 40 % de aumento.
             * Código             Cargo               Aumento
             *   1               gerente                10 %
             *   2               engenheiro             20 %
             *   3               técnico                30 %
             * No final é mostrado o salário antigo, o novo salário e a diferença.
            */
            
            Console.WriteLine("Aula 04 - Exercício 03\n\n");

            Console.Write("Informe o valor do salário atual: ");
            double salarioAtual = double.Parse(Console.ReadLine());
            //Console.WriteLine("Valor salário atual: {0:C}", salarioAtual);
            Console.WriteLine("\nOs códigos dos cargos atuais são:" +
                "\n[1] = Gerente" +
                "\n[2] = Engenheiro" +
                "\n[3] = Técnico: ");
            Console.Write("Informe o código do cargo atual: ");
            int codigoCargoAtual = int.Parse(Console.ReadLine());
            double novoSalario, percentual, diferencaSalario;
            string descricaoCargoAtual;

            switch (codigoCargoAtual)
            {
                case 1:
                        percentual = 10;
                        descricaoCargoAtual = "Gerente";
                        break;                   
                case 2:
                        percentual = 20;
                        descricaoCargoAtual = "Engenheiro";
                        break;
                case 3:
                        percentual = 30;
                        descricaoCargoAtual = "Técnico";
                        break;
                default:
                        percentual = 40;
                        descricaoCargoAtual = "Outro Cargo";
                        break;
            }
            diferencaSalario = salarioAtual * percentual / 100;
            novoSalario = salarioAtual + diferencaSalario;
            Console.WriteLine("\n\nO valor do salário atual é: {0:C} ", salarioAtual);
            Console.WriteLine("O percentual de aumento sobre o salário de [{0}] será de {1}%, totalizando: {2:C}", descricaoCargoAtual, percentual, diferencaSalario);
            Console.WriteLine("O novo valor do salário será: {0:C}", novoSalario);
        }
    }
}
