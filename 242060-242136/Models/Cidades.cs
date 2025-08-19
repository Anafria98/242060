using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _200038_20371.Models
{
    public class Cidades
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("INSERT INTO cidades (nome,uf) VALUES(@nome,@uf)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@uf", uf);
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
                Banco.Comando = new MySqlCommand("SELECT * FROM Cidades where nome like @Nome " +
                                                               "order by nome", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@Nome", nome + "%");
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
                Banco.Comando = new MySqlCommand("update cidades set nome = @nome,uf = @uf where id = @id ", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@uf", uf);
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
                Banco.Comando = new MySqlCommand("delete from cidades where id = @id ", Banco.Conexao);
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
