using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _200038_20371.Models
{
    public class VendaDet
    {
        public int Id { get; set; }
        public int idVendaCab { get; set; }
        public int idProduto { get; set; }
        public int qtde { get; set; }
        public double valorUnitario { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand(
                    "INSERT INTO vendadet (idVendaCab, idProduto, qtde, valorUnitario) " +
                    "VALUES (@ID_VENDA, @ID_PRODUTO, @qtde, @VLR_UNIT)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@ID_VENDA", idVendaCab);
                Banco.Comando.Parameters.AddWithValue("@ID_PRODUTO", idProduto);
                Banco.Comando.Parameters.AddWithValue("@qtde", qtde);
                Banco.Comando.Parameters.AddWithValue("@VLR_UNIT", valorUnitario);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
