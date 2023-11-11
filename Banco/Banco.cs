using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Banco : Form
    {
        Cliente cliente;
        Conexao conexao;

        public Banco()
        {
            InitializeComponent();

            this.cliente = new Cliente();
            this.conexao = new Conexao();

            LoadListOperacoes();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonDpositar_Click(object sender, EventArgs e)
        {
                      
            try
            {
                double valor = Convert.ToDouble(textBoxDeposito.Text);

                cliente.Creditar(valor);

                textBoxDeposito.Clear();

                labelSaldoValor.Text = cliente.saldo.ToString("0.00");

                MessageBox.Show("Depósito realizado com sucesso!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }          
                        
        }

        private void buttonSaque_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBoxSaque.Text);

            cliente.Debitar(valor);

            labelSaldoValor.Text = cliente.saldo.ToString("0.00");

            textBoxSaque.Clear();

            MessageBox.Show("Saque realizado com sucesso!");
        }

        private void ConfigurarListView()
        {           


        }

        private void LoadListOperacoes()
        {
            List<Tuple<string, string>> operacoes = conexao.GetListFromDatabase("movimentacao", "operacao", "valor");

            listBoxOperacoes.Items.Clear();

            foreach (var operacao in operacoes)
            {
                ListViewItem listViewItem = new ListViewItem(operacao.Item1);

                listViewItem.SubItems.Add(operacao.Item2);

                listBoxOperacoes.Items.Add(listViewItem);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
