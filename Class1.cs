using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantina_1._0
{
    public class Descricao
    {
        private string nome;
        private double valor;

        public string Nome
        {
            get { return nome; }
        }
        public double Valor
        {
            get { return valor; }
        }

        public Descricao(string nome, double valor)
        {
            this.nome = nome;
            this.valor = valor;
        }

        public override string ToString()
        {
            return $"{nome} - R$ {valor:F2}";
        }
    }
}
