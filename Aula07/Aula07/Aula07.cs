using System;
using System.IO;
using ClosedXML.Excel;
using System.Linq;

namespace Aula07
{
    internal class Aula07
    {
        static void Main(string[] args)
        {
            string enderecoArquivo = @"E:\evandrosouzabr\Desktop\AULA07_DADOS\banco_de_dados.xlsx";

            XLWorkbook arquivoExcel = new XLWorkbook(enderecoArquivo);
            IXLWorksheet planilha = arquivoExcel.Worksheets.First(w => w.Name == "Plan1");

            int totalLinhas = planilha.Rows().Count();      

            for (int l = 2; l < totalLinhas; l++)
            {
                var nome = planilha.Cell($"A{l}").Value.ToString();
                Console.WriteLine(nome);
            }

        }

        static void manipulaArquivo()
        {
            string enderecoArquivo = @"E:\evandrosouzabr\Desktop\AULA07_DADOS\dados.txt";

            FileStream arquivo = new FileStream(enderecoArquivo, FileMode.Open);

            StreamReader leitor = new StreamReader(arquivo);

            //Percorrer o arquivo até terminar de ler
            //Queremos que fique no while apenas enquanto o EndOfStream for FALSE

            while (!leitor.EndOfStream)
            {
                string linha = leitor.ReadLine();
                Profissional novoProfissional = ConverterStringParaProfissional(linha);

                //interpolação $ -> Terão códigos C# no meio da string
                string mensagem = (novoProfissional.nome + " " + novoProfissional.idade + " " + novoProfissional.especialidade);
                Console.WriteLine(mensagem);
            }
            arquivo.Close();
            leitor.Close();
        }

        //Vamos criar uma função que vai receber um texto e devolver o profissional
        static Profissional ConverterStringParaProfissional(string linha)
        {
            Profissional profissional = new Profissional(); 
            // Lucas 28 Dados  <- 1ª linha do arquivo

            //split responsável por dividir a string de acordo com um padrão
            //nessa caso, o padrão é um espaço em branco: ' '
            string[] campos = linha.Split(' ');
            profissional.nome = campos[0];
            profissional.idade = int.Parse(campos[1]);
            profissional.especialidade = campos[2];

            return profissional;
        }

        class Profissional
        {
            //Atalho para criar as propriedades dentro de uma classe: "prop" <tab> <tab>
            //GET -> Leitura da Propriedade
            //SET -> "Setar" (armazenar) um valor para a proriedade
            public string nome { get; set; }
            public int idade { get; set; }
            public string especialidade { get; set; }
        }
    }
}
