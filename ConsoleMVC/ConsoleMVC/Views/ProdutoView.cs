using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMVC.Models;

namespace ConsoleMVC.Views
{
    internal class ProdutoView
    {
        //como parâmetro vai receber uma lista de produto
        public void Listar(List<Produto> ListaProduto)
        {
            //percorrer cada produto e exibir para o usuário
            foreach(Produto item in ListaProduto)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco}");
            }
        }
    }
}
