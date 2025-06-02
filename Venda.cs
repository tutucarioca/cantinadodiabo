using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantina_1._0
{
    internal class Venda
    {
        private string nomeCliente;
        string data;
        string pagamento;
        public List<pedido> pedidos = new List<pedido>();
        string isviagem;
        private status status;

        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }
        public status Status
        {
            get { return status; }
            set { status = value; }
        }

        public Venda(string nomeCliente, string pagamento, string isviagem)
        {
            this.pedidos = new List<pedido>();
            this.nomeCliente = nomeCliente;
            this.pagamento = pagamento;
            this.isviagem = isviagem;
        }
    }
}
