using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _200038_20371.Models
{
    public class Categoria

    {
        public int id { get; set; }
        public string categoria { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("INSERT INTO categorias (categoria) VALUES(@categoria)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@categoria", categoria);
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
                Banco.Comando = new MySqlCommand("SELECT * FROM categorias where categoria like @categoria " +
                                                               "order by categoria", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@categoria", categoria + "%");
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
                Banco.Comando = new MySqlCommand("update categorias where categoria like @categoria where id = @id ", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@categoria", categoria);
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
                Banco.Comando = new MySqlCommand("delete from categorias where id = @id ", Banco.Conexao);
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

