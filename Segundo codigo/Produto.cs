using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Segundo_Codigo
{
    public class Produto{
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(){
        }
        public Produto(string nome, double preco) : this(){
            _nome = nome;
            _preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome,preco){
            _quantidade = quantidade;//nao precisaria colocar o 0 ja que naturalmente o valor ja e 0, 
            //mas se por acaso seu sistema ja tiver valor fixo em estoque da para colocar aqui
        }

        public string Nome{
            get{return _nome;}
            set{   
                if(value != null && value.Length > 1){
                    _nome = value;
                }
            }
        }
        // este || foi apenas teste o correto seria &&

        public double Preco {
            get{return _preco;}
        }

        public double Quantidade{
            get{return _quantidade;}
        }

        public double ValorTotalEmEstoque(){
            return _preco * _quantidade;
        }

        public void AdicionarProduto(int quantidade){
            _quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade){
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome 
            + ", $" 
            + _preco.ToString("F2", CultureInfo.InvariantCulture) 
            + ", Unidades: " + _quantidade.ToString()
            + ", Total: $ " 
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        public void AdicionarEstoque(){
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem adicionados ao estoque:");
        }
        public void dadosAtualizados(Produto produto){
            Console.WriteLine();
            Console.Write("Dados atualizados: " + produto);
        }
        public void removerEstoque(){
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem removidos ao estoque:");
        }
    }
}
