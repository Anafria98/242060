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
    public partial class FrmContasaReceber : Form
    {
        public FrmContasaReceber()
        {
            InitializeComponent();
        }

        private void FrmContasaReceber_Load(object sender, EventArgs e)
        {
            Clientes  c = new Clientes();
            cboNome.DataSource = c.Consultar();
            cboNome.DisplayMember = "nome";
            cboNome.ValueMember = "id";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
