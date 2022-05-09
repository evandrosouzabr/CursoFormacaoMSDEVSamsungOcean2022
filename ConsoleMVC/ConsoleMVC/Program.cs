using System;
using ConsoleMVC.Controllers;
using ConsoleMVC.Models;

namespace ConsoleMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Produto produto = new Produto();
            ProdutoController prod = ProdutoController();
            prod.ListarProdutos();
        }
    }
}
