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
        //Método para Excluir (Não possui retorno)
        //Método para Retorno (Possui retorno de uma tabela)
    }
}