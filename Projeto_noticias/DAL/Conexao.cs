using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient; //Usar SQL



namespace Projeto_noticias.DAL
{
    public class Conexao
    {
        //CONEXAO SQL 

        SqlConnection con;


        public Conexao()
        {
            con = new SqlConnection();

            //configurar a conexão com o banco de dados

            //configurar endereço do servidor, nome do bd, e autenticar


            con.ConnectionString = @"Data Source =(local)\sqlexpress; 
                                     Initial Catalog=BDNoticias;
                                     Integrated Security=true";

        }
        //Metodo Conectar

        public SqlConnection Conectar(){
            if(con.State == ConnectionState.Closed)
            {
                con.Open();    
            }

            return con;
        }

        //metodo desconectar

        public SqlConnection Desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            return con;
        }



    }
}