using System;
using System.Collections.Generic;
using System.ComponentModel;
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


        }

        private void listBalcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listPronto.Items.Count == 5)
            {
                listPronto.Items.RemoveAt(4);
            }
        }
    }
}
