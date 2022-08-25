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