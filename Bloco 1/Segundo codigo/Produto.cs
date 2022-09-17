using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Segundo_Codigo
{
    public class Produto{
        private string _nome;
        public double Preco {get; private set; }
        public int Quantidade { get; private set; }

        public Produto(){
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
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
            return _nome 
            + ", $" 
            + Preco.ToString("F2", CultureInfo.InvariantCulture) 
            + ", Unidades: " + Quantidade.ToString()
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
