using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cantina_1._0
{
 
    public partial class Balcao : Form
    {
        public Balcao()
        {
            InitializeComponent();
        }

        private void balcao_Load(object sender, EventArgs e)
        {

            foreach (Venda venda in PersistenciaPedido.Pedidos)
                if (venda.status == status.PRONTO)
                    listBalcao.Items.Add(venda);
              else if(venda.status == status.PREPARANDO)
                {

                }
                else if(venda.status == status.ENTREGUE)
                    listPronto.Items.Add(venda);
                
           
        }

        private void listBalcao_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                
                
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venda pedidoSelecionado = (Venda)listBalcao.SelectedItem;

            if (listBalcao.SelectedItem != null)
            {
                if (listPronto.Items.Count == 5)
                {
                    listPronto.Items.RemoveAt(4);
                }
                pedidoSelecionado.status = status.ENTREGUE;
                listPronto.Items.Insert(0, listBalcao.SelectedItem);

                listBalcao.Items.RemoveAt(listBalcao.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione um Item para entregar: ");
            }
           
        }
    }
}
