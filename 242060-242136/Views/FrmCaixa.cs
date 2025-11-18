using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _200038_20371.Models;

namespace _200038_20371.Views
{
    public partial class FrmCaixa : Form
    {
        double totalVenda, pago, troco, dinheiro,
            cartao, cheque, pix, boleto;

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            if (troco < 0)
            {
                MessageBox.Show("Valor pago menor que o valor da Venda", "Caixa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            Caixa c = new Caixa()
            {
                idVendaCab = int.Parse(txtVenda.Text),
                dinheiro = dinheiro,
                cartao = cartao,
                cheque = cheque,
                boleto = boleto,
                pix = pix,
            };

            c.Incluir();

            Close();
        }

        private void txtBoleto_TextChanged(object sender, EventArgs e)
        {
            calcularTroco();
        }

        private void txtPIX_TextChanged(object sender, EventArgs e)
        {
            calcularTroco();
        }

        private void txtCartao_TextChanged(object sender, EventArgs e)
        {
            calcularTroco();
        }

        private void txtCheque_TextChanged(object sender, EventArgs e)
        {
            calcularTroco();
        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {
            calcularTroco();
        }

        public FrmCaixa(String idVendaCab, String idCliente, double total, string nome)
        {
            InitializeComponent();

            txtIdCliente.Text = idCliente;
            txtNomeCliente.Text = nome;
            txtValor.Text = total.ToString("C");
            txtVenda.Text = idVendaCab;

            totalVenda = total;
        }

        void calcularTroco()
        {
            if (txtDinheiro.Text == "") dinheiro = 0;
            else dinheiro = double.Parse(txtDinheiro.Text);

            if (txtCheque.Text == "") cheque = 0;
            else cheque = double.Parse(txtCheque.Text);

            if (txtCartao.Text == "") cartao = 0;
            else cartao = double.Parse(txtCartao.Text);

            if (txtPIX.Text == "") pix = 0;
            else pix = double.Parse(txtPIX.Text);

            if (txtBoleto.Text == "") boleto = 0;
            else boleto = double.Parse(txtBoleto.Text);

            pago = dinheiro + cartao + cheque + pix + boleto;
            troco = pago - totalVenda;

            txtTroco.Text = pago.ToString("C");

            if (troco < 0) txtTroco.ForeColor = Color.Red;
            else txtTroco.ForeColor = Color.Blue;
        }
    }
}
