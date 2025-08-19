using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace _200038_20371.Models
{
    public class Marcas
    {
        public int id { get; set; }
        public string marca { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("INSERT INTO marcas (marca) VALUES(@marca)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@marca", marca);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Consultar()
        {
            try
            {
                Banco.Comando = new MySqlCommand("SELECT * FROM marcas where marca like @marca " +
                                                               "order by marca", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@marca", marca + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);
                Banco.FecharConexao();

                return Banco.datTabela;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void Alterar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("update marcas set marca = @marca where id = @id ", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@marca", marca);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Excluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("delete from marcas where id = @id ", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
