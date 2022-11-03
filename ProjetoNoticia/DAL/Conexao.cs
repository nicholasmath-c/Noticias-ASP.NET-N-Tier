using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data; //Trabalhar com DADOS
using System.Data.SqlClient; //Cliente Serv. SQL

namespace ProjetoNoticia.DAL
{
    public class Conexao
    {
        //declarar como GLOBAL uma
        //variavel de conexao sql
        SqlConnection con;

        //Metodo Construtor
        // E executado SEMPRE que um objeto
        // for instanciado da classe
        public Conexao()
        {
            con = new SqlConnection();

            //configurar a conexao com o serv. BD.
            // Endereco do Serv, Nome do DataBase
            // Autenticacao (usuario e senha / Integrada do Windows)
            con.ConnectionString = @"Data Source=(local)\SQL;
                                     Initial Catalog=BDNoticias;
                                     Integrated Security=true";
        }

        //Metodo Conectar - Retorna uma conexao valida com o serv.
        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open(); //Efetivamente abrir a conexao com o serv. SQL
            }
            return con;
        }

        //Metodo Desconectar - Encerra a conexao com o serv.
        public void Desconectar()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close(); //Encerra a conexao com o serv. SQL
            }
        }
    }
}