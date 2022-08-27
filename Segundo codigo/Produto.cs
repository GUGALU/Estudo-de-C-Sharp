using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Segundo_Codigo
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade){
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco){
            Nome = nome;
            Preco = preco;
            Quantidade = 0;//nao precisaria colocar o 0 ja que naturalmente o valor ja e 0, 
            //mas se por acaso seu sistema ja tiver valor fixo em estoque da para colocar aqui
        }

        public double ValorTotalEmEstoque(){
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade){
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade){
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome 
            + ", $" 
            + Preco.ToString("F2", CultureInfo.InvariantCulture) 
            + ", Unidades: " + Quantidade.ToString()
            + ", Total: $ " 
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}