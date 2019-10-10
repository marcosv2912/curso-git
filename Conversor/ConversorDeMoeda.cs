using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor
{
    class ConversorDeMoeda
    {
        public double cotacao;
        public double qtd;
        public double Preco;

        public double Valores()
        {
            Preco = cotacao * qtd;
            return Preco +(((cotacao*qtd)*6)/100);
        }
        
        
    }
}
