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
    public partial class FrmMarcas : Form
    {
        Marcas m;
        public FrmMarcas()
        {
            InitializeComponent();
        }

        void limparControles()
        {
            txtiD.Clear();
            txtMarca.Clear();
            txtPesquisar.Clear();
        }
        void carregarGrid(string pesquisa)
        {
            m = new Marcas()
            {
                marca = pesquisa
            };
            dgvMarcas.DataSource = m.Consultar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text.Equals(String.Empty)) return;

            m = new Marcas()
            {
                marca = txtMarca.Text
            };
            m.Incluir();
            limparControles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text.Equals(String.Empty)) return;

            m = new Marcas()
            {
                id = int.Parse(txtiD.Text),
                marca = txtMarca.Text,
            };
            m.Alterar();
            limparControles();
            carregarGrid("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text.Equals(String.Empty)) return;

            m = new Marcas()
            {
                id = int.Parse(txtiD.Text),
            };
            m.Excluir();
            limparControles();
            carregarGrid("");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisar.Text);
        }

        private void dgvCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMarcas.RowCount > 0)
            {
                txtiD.Text = dgvMarcas.CurrentRow.Cells[0].Value.ToString();
                txtMarca.Text = dgvMarcas.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }
    }
}
