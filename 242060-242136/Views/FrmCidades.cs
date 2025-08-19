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
    public partial class FrmCidades : Form
    {
        Cidades c;

        public FrmCidades()
        {
            InitializeComponent();
        }
        void limparControles()
        {
            txtiD.Clear();
            txtNome.Clear();
            txtUF.Clear();
            txtPesquisar.Clear();
        }
        void carregarGrid(string pesquisa)
        {
            c = new Cidades()
            {
                nome = pesquisa
            };
            dgvCidades.DataSource = c.Consultar();
        }

        private void FrmCidades_Load(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals(String.Empty)) return;
            if (txtUF.Text.Equals(String.Empty)) return;

            Cidades c = new Cidades()
            {
                nome = txtNome.Text,
                uf = txtUF.Text
            };
            c.Incluir();
            limparControles();
            carregarGrid("");
        }

        private void dgvCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCidades.RowCount > 0)
            {
                txtiD.Text = dgvCidades.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvCidades.CurrentRow.Cells[1].Value.ToString();
                txtUF.Text = dgvCidades.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
         {
            if (txtNome.Text.Equals(String.Empty)) return;
            if (txtUF.Text.Equals(String.Empty)) return;

            Cidades c = new Cidades()
            {
                id = int.Parse(txtiD.Text),
                nome = txtNome.Text,
                uf = txtUF.Text
            };
            c.Alterar();
            limparControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals(String.Empty)) return;
            if (txtUF.Text.Equals(String.Empty)) return;

            Cidades c = new Cidades()
            {
                id = int.Parse(txtiD.Text),
            };
            c.Excluir();
            limparControles();
            carregarGrid("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisar.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
