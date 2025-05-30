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
        private int quantidade = 0;
        private bool chapa;
        private string cliente;

        public string Nome
        {
            get { return nome; }
        }
        public double Valor
        {
            get { return valor; }
        }

        public int Quantidade
        {
            set { quantidade = value; }
            get { return quantidade; }
        }

        public bool Chapa
        {
            get { return chapa; }
            set { chapa = value; }
        }

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }


        public Descricao(string nome, double valor, bool chapa)
        {
            this.nome = nome;
            this.valor = valor;
            this.quantidade = 0;
            this.chapa = chapa;
        }

        public override string ToString()
        {
            if (quantidade > 0)
                return $"{quantidade}x {nome} - R$ {valor:F2}";
            else
            return $"{nome} - R$ {valor:F2}";
        }
    }
}
