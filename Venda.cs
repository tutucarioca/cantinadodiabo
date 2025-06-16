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
        public string nomeCliente { get; set; }
        public string Data { get; set; }
        public string pagamento { get; set; }
        public string isviagem { get; set; }
        public List<Descricao> pedidos { get; set; }
        public status status { get; set; }

        public Venda(string nomeCliente, string data, string pagamento, string isviagem, List<Descricao> pedidos, status status)

        {
            this.nomeCliente = nomeCliente;
            this.Data = data;
            this.isviagem = isviagem;
            this.status = status;
        }
    }
}
    
