using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _200038_20371
{
    public class Banco
    {
        public static MySqlConnection Conexao;
        public static MySqlCommand Comando;
        public static MySqlDataAdapter Adaptador;
        public static DataTable datTabela;

        public static void AbrirConexao()
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau;database=vendas");
                Conexao.Open();
            }
            catch(Exception e){
                MostrarErro(e);
            }
        }
        public static void FecharConexao()
        {
            try
            {
                Conexao.Close();
            }
            catch (Exception e)
            {
                MostrarErro(e);
            }
        }
        public static void CriarBanco()
        {
            try
            {
                MySqlConnection conexaoTemp = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");
                conexaoTemp.Open();
                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas", conexaoTemp);
                Comando.ExecuteNonQuery();
                conexaoTemp.Close();

                AbrirConexao();
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS CIDADES " +
                    "(id integer auto_increment primary key," +
                    "nome varchar(20)," +
                    "uf char(02))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS marcas " +
                    "(id integer auto_increment primary key," +
                    "marca varchar(20))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS categorias " +
                    "(id integer auto_increment primary key," +
                    "categoria varchar(20))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS clientes " +
                    "(id integer auto_increment primary key," +
                    "nome varchar(40)," +
                    "idCidade integer," +
                    "dataNasc date," +
                    "renda decimal(10,2)," +
                    "cpf char(14)," +
                    "foto varchar(100)," +
                    "venda boolean)", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS produtos " +
                    "(ID INTEGER PRIMARY KEY AUTO_INCREMENT," +
                    "DESCRICAO VARCHAR(40)," +
                    "idCategoria integer," +
                    "idMarca integer," +
                    "estoque decimal(10,3)," +
                    "valorVenda decimal(10,2)," +
                    "foto varchar(100))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS MARCAS " +
                                            "(id integer auto_increment primary key," +
                                            "marca varchar(20))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS VendaDet " +
                    "(id integer auto_increment primary key, " +
                    "idVendaCab int, " +
                    "idProduto int, " +
                    "qtde decimal(10,3), " +
                    "valorUnitario decimal(10,2))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS VendaCab " +
                    "(id integer auto_increment primary key, " +
                    "idCliente int, " +
                    "data date, " +
                    "total decimal(10,2))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Contas_Receber " +
                    "(id integer auto_increment primary key, " +
                    "idVenda int," +
                    "parcela tinyint," +
                    "data_vencto date," +
                    "data_pagto date," +
                    "vlr_parcela double(10,2)," +
                    "status boolean)", Conexao);
                Comando.ExecuteNonQuery();
                FecharConexao();
            }
            catch (Exception e) {
                MostrarErro(e);
            }
        }
        private static void MostrarErro(Exception e)
        {
            MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
