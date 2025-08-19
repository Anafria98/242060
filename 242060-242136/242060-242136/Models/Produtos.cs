using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace _200038_20371.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string descricao { get; set; }
        public int idCategoria { get; set; }
        public int idMarca { get; set; }
        public double valorVenda {  get; set; }
        public int estoque {  get; set; }
        public string foto { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("INSERT INTO PRODUTOS (descricao, idCategoria, idMarca, estoque, valorVenda, foto) " +
                    "VALUES (@descricao, @idCategoria, @idMarca, @estoque, @valorVenda, @foto)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao);
                Banco.Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                Banco.Comando.Parameters.AddWithValue("@idMarca", idMarca);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@valorVenda", valorVenda);
                Banco.Comando.Parameters.AddWithValue("@foto", foto ?? "");
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Consultar()
        {
            try
            {
                Banco.Comando = new MySqlCommand(@"
            SELECT 
                p.ID, 
                p.DESCRICAO, 
                c.categoria, 
                m.marca, 
                p.estoque, 
                p.valorVenda AS preco, 
                p.foto 
            FROM Produtos p
            INNER JOIN Marcas m ON m.id = p.idMarca
            INNER JOIN Categorias c ON c.id = p.idCategoria
            WHERE p.descricao LIKE @descricao
            ORDER BY p.descricao", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@descricao", descricao + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);
                return Banco.datTabela;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void Excluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("delete from produtos where id = @id ", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", Id);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Alterar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("update produtos set descricao = @descricao, " +
                                                 "idMarca = @idMarca, " +
                                                 "idCategoria = @idCategoria, " +
                                                 "valorVenda = @valorVenda, " +
                                                 "estoque = @estoque, " +
                                                 "foto = @foto where id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", Id);
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao);
                Banco.Comando.Parameters.AddWithValue("@idMarca", idMarca);
                Banco.Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                Banco.Comando.Parameters.AddWithValue("@valorVenda", valorVenda);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void atualizarEstoque(double qtde)
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand(
                "Update produtos set estoque = estoque - @qtde where id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("qtde", qtde);
                Banco.Comando.Parameters.AddWithValue("id", Id);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
