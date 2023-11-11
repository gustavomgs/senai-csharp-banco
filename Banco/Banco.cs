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

        public Banco()
        {
            InitializeComponent();

            this.cliente = new Cliente();
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
    }
}
