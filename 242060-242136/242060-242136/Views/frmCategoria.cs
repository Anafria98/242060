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
    public partial class frmCategoria : Form
    {
        Categoria ca;
        public frmCategoria()
        {
            InitializeComponent();
        }

        void limparControles()
        {
            txtiD.Clear();
            txtCategoria.Clear();
            txtPesquisar.Clear();
        }
        void carregarGrid(string pesquisa)
        {
            ca = new Categoria()
            {
                categoria = pesquisa
            };
            dgvCategorias.DataSource = ca.Consultar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Equals(String.Empty)) return;

            ca = new Categoria()
            {
                categoria = txtCategoria.Text
            };
            ca.Incluir();
            limparControles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Equals(String.Empty)) return;

            ca = new Categoria()
            {
                id = int.Parse(txtiD.Text),
                categoria = txtCategoria.Text,
            };
            ca.Alterar();
            limparControles();
            carregarGrid("");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Equals(String.Empty)) return;

            ca = new Categoria()
            {
                id = int.Parse(txtiD.Text),
            };
            ca.Excluir();
            limparControles();
            carregarGrid("");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisar.Text);
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.RowCount > 0)
            {
                txtiD.Text = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
                txtCategoria.Text = dgvCategorias.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }
    }
}
