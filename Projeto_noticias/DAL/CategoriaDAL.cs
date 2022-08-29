using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Projeto_noticias.DAL
{
    public class CategoriaDAL
    {
        //Conexão com objeto GLOBAL da classe Conexão
        Conexao con = new Conexao();

        //Método para Cadastrar (Não possui retorno)
        public void Cadastrar(BLL.Categoria c)
        {
            //Configurar o comando SQL
            SqlCommand cmd = new SqlCommand();
            //Configurar o comando que será executado
            cmd.CommandText = @"INSERT INTO TBCategoria(Nome)
                                VALUES(@nome)";
            //configurar os parâmetros SQL
            cmd.Parameters.AddWithValue("@nome", c.Nome);
            //Configurar a conexão do comando SQL
            cmd.Connection = con.Conectar();
            //Executar o comando SQL no servidor
            cmd.ExecuteNonQuery();
            //Encerrar a conexão com o servidor
            con.Desconectar();
        }

        //Método para Atualizar (Não possui retorno)
        public void Atualizar(BLL.Categoria c)
        {
            //Configurar o comando SQL
            SqlCommand cmd = new SqlCommand();
            //Configurar o comando que será executado
            cmd.CommandText = @"UPDATE TBCategoria SET
                                NOME = @nome 
                                WHERE COD = @cod";
            //configurar os parâmetros SQL
            cmd.Parameters.AddWithValue("@nome", c.Nome);
            cmd.Parameters.AddWithValue("@cod", c.Cod);
            //Configurar a conexão do comando SQL
            cmd.Connection = con.Conectar();
            //Executar o comando SQL no servidor
            cmd.ExecuteNonQuery();
            //Encerrar a conexão com o servidor
            con.Desconectar();
        }

        //Método para Excluir (Não possui retorno)
        public void Excluir(BLL.Categoria c)
        {
            //Configurar o comando SQL
            SqlCommand cmd = new SqlCommand();
            //Configurar o comando que será executado
            cmd.CommandText = @"DELETE FROM TBCategoria 
                                WHERE COD = @cod";
            //configurar os parâmetros SQL
            cmd.Parameters.AddWithValue("@cod", c.Cod);
            //Configurar a conexão do comando SQL
            cmd.Connection = con.Conectar();
            //Executar o comando SQL no servidor
            cmd.ExecuteNonQuery();
            //Encerrar a conexão com o servidor
            con.Desconectar();
        }

        //Método para Retorno (Possui retorno de uma tabela)
        public DataTable Consultar()
        {
            //Tabela de Dados Padrão C# (int, string, bool, ...)
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COD, NOME FROM TBCategoria";
            cmd.Connection = con.Conectar();

            //Adaptador de dados SQL --> C#
            SqlDataAdapter da = new SqlDataAdapter();
            //Configurar o local(objeto) que possui consulta SQL
            da.SelectCommand = cmd;

            //Preencher o DataTable(dt) com os dados JÁ ADAPTADOS DO SQL
            da.Fill(dt); //Executa a conulta no Servidor BD
            con.Desconectar();
            return dt;
        }

        //SOBRECARGA DE MÉTODO
        //Métodos de mesmo nome com assinaturas diferentes
        public DataTable Consultar(BLL.Categoria c)
        {
            //Tabela de Dados Padrão C# (int, string, bool, ...)
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COD, NOME " +
                              "FROM TBCategoria" +
                              "WHERE NOME LIKE @nome";

            cmd.Parameters.AddWithValue("@nome", "%" + c.Nome + "%");

            cmd.Connection = con.Conectar();

            //Adaptador de dados SQL --> C#
            SqlDataAdapter da = new SqlDataAdapter();
            //Configurar o local(objeto) que possui consulta SQL
            da.SelectCommand = cmd;

            //Preencher o DataTable(dt) com os dados JÁ ADAPTADOS DO SQL
            da.Fill(dt); //Executa a conulta no Servidor BD
            con.Desconectar();
            return dt;
        }
    }
}