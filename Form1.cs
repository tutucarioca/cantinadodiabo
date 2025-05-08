namespace cantina_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total = 0;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Descricao("Feijoada de lata", 8.00));
            listBox1.Items.Add(new Descricao("Laranja", 2.00));
            listBox1.Items.Add(new Descricao("Pudim", 5.00));
            listBox1.Items.Add(new Descricao("Amendoim", 4.00));
            listBox1.Items.Add(new Descricao("Coca de lata", 6.00));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Descricao produtoSelecionado = (Descricao)listBox1.SelectedItem;
                listBox2.Items.Add(produtoSelecionado);
                total += produtoSelecionado.Valor;
                lbltotal.Text = $" TOTAL: R$ {total:F2}";
                listBox1.SelectedIndex = -1;
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
                Descricao produtoSelecionado = (Descricao)listBox2.SelectedItem;
                listBox2.Items.Remove(produtoSelecionado);
                total -= produtoSelecionado.Valor;
                lbltotal.Text = $"TOTAL: R$ {total:F2}";
            }
            else
            {
                MessageBox.Show("Selecione um item pra REMOVER do seu carrinho");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Seu TOTAL é de : R$ {total:F2}");
            listBox2.Items.Clear();
            lbltotal.Text =@$"TOTAL: R$ {total = 0}";

        }
    }
}
