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
    public partial class frmProdutos : Form
    {
        Produtos p;
        Marcas m;
        Categoria c;
        public frmProdutos()
        {
            InitializeComponent();
        }

        void limpaControle()
        {
            txtDescricao.Clear();
            txtEstoque.Clear();
            txtiD.Clear();
            txtPesquisar.Clear();
            txtValorVenda.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            picFoto.ImageLocation = "";
        }
        void carregaGrid(string pesquisa)
        {
            p = new Produtos();
            p.descricao = pesquisa;
            DataTable tabela = p.Consultar();
            if (dgvProdutos.Rows.Count > 0 || tabela != null)
                dgvProdutos.DataSource = tabela;
            else
                dgvProdutos.DataSource = null;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Equals(String.Empty)) return;
            p = new Produtos()
            {
                descricao = txtDescricao.Text,
                estoque = Convert.ToUInt16(txtEstoque.Text),
                foto = picFoto.ImageLocation,
                idCategoria = (int)cmbCategoria.SelectedValue,
                idMarca = (int)cmbMarca.SelectedValue,
                valorVenda = Convert.ToDouble(txtValorVenda.Text)
            };
            p.Incluir();
            limpaControle();
            carregaGrid("");
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            m = new Marcas();
            c = new Categoria();

            cmbCategoria.DataSource = c.Consultar();
            cmbMarca.DataSource = m.Consultar();
            cmbCategoria.DisplayMember = "categoria";
            cmbCategoria.ValueMember = "id";
            cmbMarca.DisplayMember = "marca";
            cmbMarca.ValueMember = "id";

            limpaControle();
            carregaGrid("");

            if (dgvProdutos.Columns.Contains("idCategoria"))
                dgvProdutos.Columns["idCategoria"].Visible = false;
            if (dgvProdutos.Columns.Contains("idMarca"))
                dgvProdutos.Columns["idMarca"].Visible = false;
            if (dgvProdutos.Columns.Contains("foto"))
                dgvProdutos.Columns["foto"].Visible = false;
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "X:/fotos/produtos/";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDescricao.Text = dgvProdutos.CurrentRow.Cells["DESCRICAO"].Value.ToString();
            cmbCategoria.Text = dgvProdutos.CurrentRow.Cells["categoria"].Value.ToString();
            cmbMarca.Text = dgvProdutos.CurrentRow.Cells["marca"].Value.ToString();
            txtValorVenda.Text = dgvProdutos.CurrentRow.Cells["preco"].Value.ToString();
            txtEstoque.Text = dgvProdutos.CurrentRow.Cells["estoque"].Value.ToString();
            txtiD.Text = dgvProdutos.CurrentRow.Cells["id"].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtiD.Text.Equals(string.Empty)) return;

            p = new Produtos()
            {
                Id = Convert.ToUInt16(txtiD.Text),
            };
            p.Excluir();
            limpaControle();
            carregaGrid("");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregaGrid(txtPesquisar.Text);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtiD.Text) ||
                string.IsNullOrWhiteSpace(txtEstoque.Text) ||
                string.IsNullOrWhiteSpace(txtValorVenda.Text) ||
                cmbCategoria.SelectedValue == null ||
                cmbMarca.SelectedValue == null)
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
                return;
            }

            if (!int.TryParse(txtiD.Text, out int id) ||
                !double.TryParse(txtEstoque.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double estoque) ||
                !double.TryParse(txtValorVenda.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double valorVenda))
            {
                MessageBox.Show("ID, Estoque ou Valor de Venda inválidos.");
                return;
            }

            p = new Produtos()
            {
                Id = int.Parse(txtiD.Text),
                descricao = txtDescricao.Text,
                estoque = (int)estoque,
                foto = picFoto.ImageLocation,
                idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue),
                idMarca = Convert.ToInt32(cmbMarca.SelectedValue),
                valorVenda = valorVenda
            };
            p.Alterar();
            limpaControle();
            carregaGrid("");
        }
    }
}
