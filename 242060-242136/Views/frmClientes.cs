using System;
using System.Data;
using System.Windows.Forms;
using _200038_20371.Models;

namespace _200038_20371.Views
{
    public partial class frmClientes : Form
    {
        Clientes cl;
        Cidades ci;
        public frmClientes()
        {
            InitializeComponent();
        }

        void limparControles()
        {
            txtiD.Clear();
            txtNome.Clear();
            txtUF.Clear();
            mskCPF.Clear();
            txtRenda.Clear();
            dtpNasc.Value = DateTime.Now;
            picFoto.ImageLocation = "";
            chkBloqueia.Checked = false;
            cmbCidade.SelectedIndex = -1;
            txtPesquisar.Clear();
        }
        void carregarGrid(string pesquisa)
        {
            cl = new Clientes()
            {
                nome = pesquisa
            };
            dgvClientes.DataSource = cl.Consultar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals(String.Empty) || txtUF.Text.Equals(String.Empty) || txtRenda.Equals(String.Empty) || mskCPF.Text.Equals(String.Empty)) return;
            cl = new Clientes()
            {
                nome = txtNome.Text,
                idCidade = (int)cmbCidade.SelectedValue,
                dataNasc = dtpNasc.Value,
                renda = Convert.ToDouble(txtRenda.Text),
                cpf = mskCPF.Text,
                foto = picFoto.ImageLocation,
                venda = chkBloqueia.Checked,

            };
            cl.Incluir();
            limparControles();
            carregarGrid("");
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ci = new Cidades();
            cmbCidade.DataSource = ci.Consultar();
            cmbCidade.DisplayMember = "nome";
            cmbCidade.ValueMember = "id";

            limparControles();
            carregarGrid("");

            dgvClientes.Columns["idCidade"].Visible = false;
            dgvClientes.Columns["foto"].Visible = false;
        }

        private void cmbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCidade.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cmbCidade.SelectedItem;
                txtUF.Text = reg["uf"].ToString();
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "X:/fotos/clientes/";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.RowCount > 0)
            {
                txtiD.Text = dgvClientes.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvClientes.CurrentRow.Cells["nome"].Value.ToString();
                cmbCidade.Text = dgvClientes.CurrentRow.Cells["cidade"].Value.ToString();
                txtUF.Text = dgvClientes.CurrentRow.Cells["uf"].Value.ToString();
                chkBloqueia.Checked = (bool)dgvClientes.CurrentRow.Cells["venda"].Value;
                mskCPF.Text = dgvClientes.CurrentRow.Cells["cpf"].Value.ToString();
                dtpNasc.Text = dgvClientes.CurrentRow.Cells["dataNasc"].Value.ToString();
                txtRenda.Text = dgvClientes.CurrentRow.Cells["renda"].Value.ToString();
                picFoto.ImageLocation = dgvClientes.CurrentRow.Cells["foto"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtiD.Text.Equals(String.Empty)) return;

            cl = new Clientes()
            {
                id = int.Parse(txtiD.Text),
                nome = txtNome.Text,
                idCidade = (int)cmbCidade.SelectedValue,
                dataNasc = dtpNasc.Value,
                renda = Convert.ToDouble(txtRenda.Text),
                cpf = mskCPF.Text,
                foto = picFoto.ImageLocation,
                venda = chkBloqueia.Checked,
            };
            cl.Alterar();

            limparControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtiD.Equals(String.Empty)) return;

            if (MessageBox.Show("Deseja excluir o cliente?", "Excluir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cl = new Clientes()
                {
                    id = int.Parse(txtiD.Text)
                };
                cl.Excluir();

                limparControles();
                carregarGrid("");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisar.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
