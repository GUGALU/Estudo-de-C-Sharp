using System;
using System.Globalization;
namespace Segundo_Codigo{
    class Program
    {
        static void Main(){
            Dados dados = new Dados();
            string nome = dados.informarNome();
            double preco = dados.informarPreco();

            Produto produto = new Produto(nome, preco);

            Console.WriteLine("Dados do produto: " + produto);

            produto.AdicionarEstoque();
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(qte);
            produto.dadosAtualizados(produto);

            produto.removerEstoque();
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProduto(qte);
            produto.dadosAtualizados(produto);
        }
    }
}