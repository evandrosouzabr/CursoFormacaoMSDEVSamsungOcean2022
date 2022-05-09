using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMVC.Models;
using ConsoleMVC.Views;

namespace ConsoleMVC.Controllers
{
    internal class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {
            //aqui chamamos a camada de MODEL e armazenamos todos
            //os produtos do banco de dados
            List<Produto> produtos = produto.Ler();

            //agora vamos exibir os produtos a partir da camada VIEW
            produtoView.Listar(produtos);

            //outra forma 
            //produtoView.Listar(produto.Ler());
        }

    }
}
