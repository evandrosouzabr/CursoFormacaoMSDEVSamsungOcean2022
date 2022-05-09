using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Models
{
    internal class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        //"const" => Define uma constante, ou seja, uma espécie de variável,
        //mas com o valor fixo, que não pode ser mais alterado.
        private const string caminhodobanco = "Database/Produto.csv";

        //"csv" => valores separados por vírgulas
        // CTRL + K + D => identação do código

        //Criamos um CONSTRUTOR (quando a classe é construída com new(),
        //esse método será acionado.
        //para criar o CONSTRUTOR => ctor + TAB + TAB

        public Produto()
        {
            // SPLIT = responsavel por separar uma string.
            // a partir de um parametro. E tem como retorno um array.

            string pasta = caminhodobanco.Split('/')[0];

            //entrar no IF se a pasta nao existir.
            if (!Directory.Exists(pasta))
            {
                //criar uma pasta no nosso projeto.
                Directory.CreateDirectory(pasta);
            }

            //criar o arquivo apenas se nao existir.
            if (!File.Exists(caminhodobanco))
            {
                //criar o arquivo dentro da pasta.
                File.Create(caminhodobanco);
            }

        }

        public List<Produto> Ler()
        {
            List<Produto> listaProdutos = new List<Produto>();

            //ler todas as linhas e vai retornar um ARRAY
            string[] linhas = File.ReadAllLines(caminhodobanco);
            foreach (string item in linhas)
            {
                //1;Xbox;6.744
                string[] atributos = item.Split(';');
                Produto novoProduto = new Produto();
                novoProduto.Codigo = int.Parse(atributos[0]);
                novoProduto.Nome = atributos[1];
                novoProduto.Preco = float.Parse(atributos[2]);
            }
            //Adicionar novo produto na lista
            listaProdutos.Add(novoProduto);

            return listaProdutos;
        }
    }
}
