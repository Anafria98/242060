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
using _200038_20371.Views;

namespace _242136_e_242060.Views
{
    public partial class FrmVendas : Form
    {
        Clientes c;
        Produtos p;
        VendaCab vc;
        VendaDet vd;
        double total;
        public FrmVendas()
        {
            InitializeComponent();
        }

        void limpaProduto()
        {
            cboProdutos.SelectedIndex = -1;
            txtEstoque.Clear();
            txtMarca.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtRenda.Clear();
            txtCategoria.Clear();
            picProduto.ImageLocation = "";
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            c = new Clientes();
            cboClientes.DataSource = c.Consultar();
            cboClientes.DisplayMember = "nome";
            cboClientes.ValueMember = "id";

            p = new Produtos();
            cboProdutos.DataSource = p.Consultar();
            cboProdutos.DisplayMember = "descricao";
            cboProdutos.ValueMember = "id";

            btnCancelar.PerformClick();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvProdutos.RowCount = 0;
            cboClientes.SelectedIndex = -1;
            txtCidade.Clear();
            txtUF.Clear();
            txtRenda.Clear();
            mskCPF.Clear();
            mskDataNasc.Clear();
            chkVenda.Checked = false;
            picCliente.ImageLocation = "";
            total = 0;
            lblTotal.Text = total.ToString("C");
            grbClientes.Enabled = true;
            grbProdutos.Enabled = false;
            limpaProduto();
        }
        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClientes.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboClientes.SelectedItem;
                txtCidade.Text = reg["CIDADE"].ToString();
                txtUF.Text = reg["UF"].ToString();
                txtRenda.Text = reg["RENDA"].ToString();
                mskCPF.Text = reg["CPF"].ToString();
                mskDataNasc.Text = reg["DATANASC"].ToString();
                picCliente.ImageLocation = reg["FOTO"].ToString();
                chkVenda.Checked = (bool)reg["VENDA"];
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cboClientes.SelectedIndex != -1)
            {
                if (chkVenda.Checked)
                {
                    MessageBox.Show("Cliente bloqueado para venda", "Vendas",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnCancelar.PerformClick();
                    return;
                }
                grbClientes.Enabled = false;
                grbProdutos.Enabled = true;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            vc = new VendaCab()
            {
                idCliente = (int)cboClientes.SelectedValue,
                data = DateTime.Now,
                total = total
            };

            int idVenda = vc.Incluir();

            foreach (DataGridViewRow linha in dgvProdutos.Rows)
            {
                vd = new VendaDet()
                {
                    idVendaCab = idVenda,
                    idProduto = Convert.ToInt32(linha.Cells[0].Value),
                    qtde = Convert.ToInt32(linha.Cells[2].Value),
                    valorUnitario = Convert.ToDouble(linha.Cells[3].Value)
                };
                vd.Incluir();

                p = new Produtos()
                {
                    Id = (int)linha.Cells[0].Value
                };
                p.atualizarEstoque(Convert.ToDouble(linha.Cells[2].Value));
            }

            FrmNegociacaoVenda frm = new FrmNegociacaoVenda(idVenda,
                                                            (int)cboClientes.SelectedValue,
                                                            total,
                                                            cboClientes.Text);
            frm.ShowDialog();

            btnCancelar.PerformClick();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtQuantidade.Text, out double quantidade) ||
                !double.TryParse(txtEstoque.Text, out double estoque) ||
                !double.TryParse(txtPreco.Text, out double preco))
            {
                MessageBox.Show("Dados inválidos de quantidade, estoque ou preço.");
                return;
            }

            if (quantidade > estoque)
            {
                MessageBox.Show("Estoque insuficiente", "Vendas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantidade.SelectAll();
                return;
            }

            dgvProdutos.Rows.Add(cboProdutos.SelectedValue, cboProdutos.Text,
                txtQuantidade.Text, txtPreco.Text);

            total += quantidade * preco;
            lblTotal.Text = total.ToString("C");
            limpaProduto();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                double quantidade = double.Parse(dgvProdutos.CurrentRow.Cells[2].Value.ToString());
                double preco = double.Parse(dgvProdutos.CurrentRow.Cells[3].Value.ToString());

                total -= quantidade * preco;
                lblTotal.Text = total.ToString("C");

                dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentRow.Index);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProdutos.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboProdutos.SelectedItem;
                txtEstoque.Text = reg["estoque"].ToString();
                txtPreco.Text = reg["preco"].ToString();
                txtMarca.Text = reg["marca"].ToString();
                txtCategoria.Text = reg["categoria"].ToString();
                picProduto.ImageLocation = reg["foto"].ToString();
            }
        }
    }
}
