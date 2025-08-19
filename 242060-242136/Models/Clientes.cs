using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace _200038_20371.Models

{
    public class Clientes
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idCidade { get; set; }
        public DateTime dataNasc {  get; set; }
        public double renda { get; set; }
        public string cpf { get; set; }
        public string foto { get; set; }
        public bool venda { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("INSERT INTO clientes (nome,idCidade, dataNasc, renda, cpf, foto, venda) VALUES(@nome,@idCidade, @dataNasc, @renda, @cpf, @foto, @venda)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@idCidade", idCidade);
                Banco.Comando.Parameters.AddWithValue("@dataNasc", dataNasc);
                Banco.Comando.Parameters.AddWithValue("@renda", renda);
                Banco.Comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@venda", venda);
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
                Banco.Comando = new MySqlCommand("SELECT cl.*, ci.nome cidade, ci.uf FROM clientes cl " +
                                                               "inner join cidades ci on (ci.id = cl.idCidade) " +
                                                               "where cl.nome like ?Nome order by cl.nome", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", nome + "%");
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
                Banco.Comando = new MySqlCommand("update clientes set nome = @nome, " +
                                                 "idCidade = @idCidade, " +
                                                 "dataNasc = @dataNasc, " +
                                                 "renda = @renda, " +
                                                 "cpf = @cpf, " +
                                                 "foto = @foto, " +
                                                 "venda = @venda where id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@idCidade", idCidade);
                Banco.Comando.Parameters.AddWithValue("@dataNasc", dataNasc);
                Banco.Comando.Parameters.AddWithValue("@renda", renda);
                Banco.Comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@venda", venda);
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
                Banco.Comando = new MySqlCommand("delete from clientes where id = @id ", Banco.Conexao);
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
