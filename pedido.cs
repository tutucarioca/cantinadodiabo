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

        List<Descricao> extrato = new List<Descricao>(); //lista da classe descricao para fazer o extrato
        double total = 0; //valor total da compra iniciado no 0

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
            //produto, valor, se é chapa ou não

            comboBox1.Items.Add("Pix");
            comboBox1.Items.Add("Cartão Débito");
            comboBox1.Items.Add("Cartão Crédito");
            comboBox1.Items.Add("Dinheiro");
            //metodo de pagamento



        }

        private void button1_Click(object sender, EventArgs e) //adicionar
        {
            if (listBox3.SelectedItem != null && numericQuant.Value > 0) //lista de produto vazia e quantidade vazia
            {
                int quant = (int)numericQuant.Value; //variavel da quantidade
                Descricao produtoSelecionado = (Descricao)listBox3.SelectedItem; //produto que foi selecionado é igual aos itens que tem na classe descricao
                Descricao vendafeita = new Descricao(produtoSelecionado.Nome, produtoSelecionado.Valor, produtoSelecionado.Chapa); //criacao de outra variável é igual ao nome do produto, valor e se é chapa ou não (para balcao)
                vendafeita.Quantidade = (int)numericQuant.Value; //quantidade na variavel
                listBox2.Items.Add(vendafeita); //a variavel venda feita é adicionada na lista do carrinho
                extrato.Add(vendafeita); //tambem adicionado no extrato
                total += produtoSelecionado.Valor * quant; //soma do total é o valor vezes a quantidade
                lbltotal.Text = $" TOTAL: R$ {total:F2}"; //mensagem do total, com a variavel total
                listBox3.SelectedIndex = -1; //o item não fica mais selecionado
                numericQuant.Value = 0; //quantidade volta pro 0, se selecionar um item sobre pra 1
            }

            else if (numericQuant.Value <= 0) //quantidade igual e menor que 0
            {
                MessageBox.Show("Indique uma quantidade válida"); //mensagem de aviso
                numericQuant.Value = 1; //ele vai automaticamente pra 1
            }

            else
            {
                MessageBox.Show("Selecione um item pra ADICIONAR no seu carrinho"); //mensagem de aviso
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null) //se lista do carrinho vazia
            {
                int quant = (int)numericQuant.Value; //variavel da quantidade
                Descricao produtoSelecionado = (Descricao)listBox2.SelectedItem; //produto que foi selecionado é igual aos itens que tem na classe descricao
                listBox2.Items.Remove(produtoSelecionado); //o produto selecionado é retirado do carrrinho
                extrato.Remove(produtoSelecionado); //o produto selecionado é retirado do extrato
                total -= produtoSelecionado.Valor * produtoSelecionado.Quantidade; //o valor é retirado do total
                lbltotal.Text = $"TOTAL: R$ {total:F2}"; //mensagem do total, com a variavel total
                numericQuant.Value = 0; //quantidadevolta pro 0, se selecionar um item sobe pra 1
            }
            else
            {
                MessageBox.Show("Selecione um item pra REMOVER do seu carrinho"); //mensagem de aviso

            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            double dinheiroInt = 0; //varioavel do valor que o cliente coloca se for dinheiro
            double troco = 0; //variavel do troco que ele recebe
            string nomeCliente = textBox1.Text; //variavel do nome do cliente
            string datahora = DateTime.Now.ToString("dd//MM/yyyy  HH: mm:ss"); //variavel da data e hora. dia/ mes/ ano. hora: minuto: segundo
            string tempo = $"Data e Horário: {datahora}"; //variavel do tempo com data e horario
            string viagem = string.Empty; //

            
            List<Descricao> pedido = listBox2.Items.Cast<Descricao>().ToList();
            venda.nomeCliente = textBox1.Text;
            
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
            foreach (pedido pedidos in listBox2.Items)
            {

            }
            Venda venda = new Venda(nomeCliente, datahora, metododepagamento, viagem, List<pedido> pedido, status.PREPARANDO);

            status statusPedido = status.PREPARANDO;

            Venda novoPedido = new Venda()
            {
                    nomeCliente,

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
