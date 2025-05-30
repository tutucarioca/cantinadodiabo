using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cantina_1._0
{
    public partial class pedido : Form
    {
        public pedido()
        {
            InitializeComponent();
        }

        List<Descricao> extrato = new List<Descricao>();
        double total = 0;

        public string metododepagamento;





        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox3.Items.Add(new Descricao("Coxinha", 5.00, false));
            listBox3.Items.Add(new Descricao("Pastel de Carne", 6.00, true));
            listBox3.Items.Add(new Descricao("Pastel de Queijo", 5.50, true));
            listBox3.Items.Add(new Descricao("Refrigerante Lata", 4.50, false));
            listBox3.Items.Add(new Descricao("Suco Natural (300ml)", 3.00, false));
            listBox3.Items.Add(new Descricao("Pão de Queijo", 3.50, false));
            listBox3.Items.Add(new Descricao("Hambúrguer Simples", 8.00, true));
            listBox3.Items.Add(new Descricao("Hambúrguer com Queijo", 9.00, true));
            listBox3.Items.Add(new Descricao("X-Tudo", 12.00, true));
            listBox3.Items.Add(new Descricao("Água Mineral (500ml)", 2.50, false));

            comboBox1.Items.Add("Pix");
            comboBox1.Items.Add("Cartão Débito");
            comboBox1.Items.Add("Cartão Crédito");
            comboBox1.Items.Add("Dinheiro");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem != null && numericQuant.Value > 0)
            {
                int quant = (int)numericQuant.Value;
                Descricao produtoSelecionado = (Descricao)listBox3.SelectedItem;
                Descricao vendafeita = new Descricao(produtoSelecionado.Nome, produtoSelecionado.Valor, produtoSelecionado.Chapa);
                vendafeita.Quantidade = (int)numericQuant.Value;
                listBox2.Items.Add(vendafeita);
                extrato.Add(vendafeita);
                total += produtoSelecionado.Valor * quant;
                lbltotal.Text = $" TOTAL: R$ {total:F2}";
                listBox3.SelectedIndex = -1;
                numericQuant.Value = 0;
            }

            else if (numericQuant.Value <= 0)
            {
                MessageBox.Show("Indique uma quantidade válida");
                numericQuant.Value = 1;
            }

            else
            {
                MessageBox.Show("Selecione um item pra ADICIONAR no seu carrinho");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                int quant = (int)numericQuant.Value;
                Descricao produtoSelecionado = (Descricao)listBox2.SelectedItem;
                listBox2.Items.Remove(produtoSelecionado);
                extrato.Remove(produtoSelecionado);
                total -= produtoSelecionado.Valor * produtoSelecionado.Quantidade;
                lbltotal.Text = $"TOTAL: R$ {total:F2}";
                numericQuant.Value = 0;
            }
            else
            {
                MessageBox.Show("Selecione um item pra REMOVER do seu carrinho");

            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            double dinheiroInt = 0;
            double troco = 0;
            string nomeCliente = textBox1.Text;
            string datahora = DateTime.Now.ToString("dd//MM/yyyy  HH: mm:ss");
            string tempo = $"Data e Horário: {datahora}";
            string viagem = string.Empty;

            Venda venda = new Venda(textBox1.Text, comboBox1.SelectedIndex.ToString(), viagem);


            if (string.IsNullOrEmpty(nomeCliente))
            {
                MessageBox.Show("Sem cliente cadastrado");
                return;
            }

            if (string.IsNullOrEmpty(metododepagamento))
            {
                MessageBox.Show("Selecione uma forma de pagamento");
                return;
            }

            while (dinheiroInt < total)
            {

                if (comboBox1.SelectedIndex != 3)
                {
                    if (checkBox1.Checked)
                    {
                        viagem = "para viagem";
                    }
                    else
                    {
                        viagem = "comer aqui";
                    }
                        string extratop = string.Join("\n", extrato);
                        MessageBox.Show($@"
                    Dados do Pedido:

                    Cliente:{nomeCliente}
                    Metódo de Pagamento: {metododepagamento}
                    Produtos: {extratop}
                    Total: R$ {total}
                    {viagem}
                   
                    {tempo}");
                    }

                else if (comboBox1.SelectedIndex == 3)
                {
                    string nome = Microsoft.VisualBasic.Interaction.InputBox("Qual valor que o cliente entregou?", "Valor Troco");
                    if (double.TryParse(nome, out dinheiroInt))
                    {
                        if (dinheiroInt < total)
                        {
                            MessageBox.Show($"Valor insuficiente. Faltam {total - dinheiroInt} R$");
                            return;
                        }
                        else
                        {
                            troco = dinheiroInt - total;
                            MessageBox.Show($"Troco: {troco} R$");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor inválido.");
                    }
                    
                        string extratop = string.Join("\n", extrato);
                        MessageBox.Show(@$"
                        Dados do Pedido:
                        PARA VIAGEM

                        Cliente:{nomeCliente}
                        Metódo de Pagamento: {metododepagamento}
                        Produtos: {extratop}
                        Total: R$ {total}
                        {viagem}
                        
                        {tempo}");
                   
                }

                comboBox1.SelectedIndex = -1;
                listBox2.Items.Clear();
                textBox1.Clear();
                checkBox1.Checked = false;
                lbltotal.Text = @$"TOTAL: R$ {total = 0}";
                break;
            }





        }







        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem != null)
            {
                numericQuant.Value = 1;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                metododepagamento = "Pix";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                metododepagamento = "Cartão de Débito";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                metododepagamento = "Cartão de Crédito";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                metododepagamento = "Dinheiro";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void valorTroco(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Balcao balcao = new Balcao();
            balcao.Show();
        }
    }
}
