using System;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 2
            //1 - Elabore um algorítimo que receba e calcule a idade média de 5 alunos.

            //Informe a quantidade de alundos a serem cadastrados
            Console.Write("Digite quantos alunos serão cadastrados: ");
            int qtdAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Declarando o vetor de string para salvar os nomes dos alunos
            string[] nomesAlunos;
            nomesAlunos = new string[qtdAlunos];

            //Declarando o vetor de inteiro para salvar as idades dos alunos
            int[] idadesAlunos;
            idadesAlunos = new int[qtdAlunos];

            //Declarando as variáveis para guardar o total e a média das idades
            int totalIdades = 0;
            double mediaIdades = 0;
            
            //Usando o "for" para incluir os dados dos alunos nos vetores
            for (int i = 0; i < qtdAlunos; i++)
            {
                Console.Write("Digite o nome do aluno[{0}]: ", i+1);
                nomesAlunos[i] = Console.ReadLine();
                Console.Write("Digite a idade do aluno[{0}]: ", i+1);
                idadesAlunos[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                //Calculando o somatório das idades
                totalIdades += idadesAlunos[i];
            }

            //Calculando a média das idades
            mediaIdades = Convert.ToDouble(totalIdades) / qtdAlunos;

            //Usando o comando "for" para exibir os dados dos alunos
            for (int i = 0; i < qtdAlunos; i++)
            {
                Console.WriteLine("Aluno[{0}]: {1} tem {2} anos.", i+1, nomesAlunos[i],idadesAlunos[i]);
            }
            
            //Apresentado o somatório e a média das idades dos alunos
            Console.WriteLine();
            Console.WriteLine("O somatório das idades dos {0} alunos é: {1}", qtdAlunos, totalIdades);
            Console.WriteLine("A média de idade dos {0} alunos é: {1:F2}", qtdAlunos, mediaIdades);
        }

        static void PrimeiroExercicio(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            int idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            /*Usando os valores das variáveis, produza a seguinte saída na tela do console:

            Produtos:
                Computador, cujo preço é $ 2100,00
                Mesa de escritório, cujo preço é $ 650,50

            Registro: 30 anos de idade, código 5290 e gênero M


            Medida com oito casas decimais: 53,23456700
            Arredondado(três casas decimais): 53,235
            */

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é {1:C2}", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é {1:C2}", produto2, preco2);
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero {2}", idade, codigo, genero);
            Console.WriteLine("Medida com 8 casas decimais {0:F8}", medida);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);

            //EXERCÍCIO 3a
            //1 - Elabore um algorítimo que receba e calcule a idade média de 5 alunos.
        }

        static void SegundoExercicio(string[] args)
        {
            //EXERCÍCIO 2
            //1 - Elabore um algorítimo que receba e calcule a idade média de 5 alunos.

            //Inserindo dados do Aluno01
            Console.Write("Digite o nome do aluno 01: ");
            string nomeAluno01 = Console.ReadLine();
            Console.Write("Digite a idade do aluno 01: ");
            int idadeAluno01 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //Inserindo dados do Aluno02
            Console.Write("Digite o nome do aluno 02: ");
            string nomeAluno02 = Console.ReadLine();
            Console.Write("Digite a idade do aluno 02: ");
            int idadeAluno02 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //Inserindo dados do Aluno03
            Console.Write("Digite o nome do aluno 03: ");
            string nomeAluno03 = Console.ReadLine();
            Console.Write("Digite a idade do aluno 03: ");
            int idadeAluno03 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //Inserindo dados do Aluno04
            Console.Write("Digite o nome do aluno 04: ");
            string nomeAluno04 = Console.ReadLine();
            Console.Write("Digite a idade do aluno 04: ");
            int idadeAluno04 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //Inserindo dados do Aluno05
            Console.Write("Digite o nome do aluno 05: ");
            string nomeAluno05 = Console.ReadLine();
            Console.Write("Digite a idade do aluno 05: ");
            int idadeAluno05 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            //Calculando a média das idades
            int totalIdadeAlunos = (idadeAluno01 + idadeAluno02 + idadeAluno03 + idadeAluno04 + idadeAluno05);
            double mediaIdadeAlunos = Convert.ToDouble(totalIdadeAlunos) / 5;

            //Exibindo os resultados
            Console.WriteLine("{0} tem {1} anos.", nomeAluno01, idadeAluno01);
            Console.WriteLine("{0} tem {1} anos.", nomeAluno02, idadeAluno02);
            Console.WriteLine("{0} tem {1} anos.", nomeAluno03, idadeAluno03);
            Console.WriteLine("{0} tem {1} anos.", nomeAluno04, idadeAluno04);
            Console.WriteLine("{0} tem {1} anos.", nomeAluno05, idadeAluno05);
            Console.WriteLine("");
            Console.WriteLine("O somatório das idades dos 05 alunos é: {0}", totalIdadeAlunos);
            Console.WriteLine("A média de idade dos 05 alunos é: {0:F2}", mediaIdadeAlunos);
        }
    }
}
