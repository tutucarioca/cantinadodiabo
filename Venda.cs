using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace cantina_1._0
{
    public class Venda
    {
        public string nomeCliente;
        public string Data;
        public string pagamento;
        public List<Descricao> pedidos = new List<Descricao>();
        public string isviagem;
        public status status;

        public Venda(string nomeCliente, string data, string pagamento, string isviagem, List<pedido> pedidos, status status)

        {
            this.nomeCliente = nomeCliente;
            this.Data = data;
            this.isviagem = isviagem;
            this.status = status;
        }
    }
}
    
