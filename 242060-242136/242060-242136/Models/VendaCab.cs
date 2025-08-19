using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _200038_20371.Models
{
    public class VendaCab
    {
        public int id {  get; set; }
        public int idCliente { get; set; }
        public DateTime data {  get; set; }
        public double total { get; set; }

        public int Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("INSERT INTO VendaCab (idCliente, data, total) " +
                                                    "VALUES (@idCliente, @data, @total)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@idCliente", idCliente);
                Banco.Comando.Parameters.AddWithValue("@data", data);
                Banco.Comando.Parameters.AddWithValue("@total", total);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
                return (int)Banco.Comando.LastInsertedId;
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
