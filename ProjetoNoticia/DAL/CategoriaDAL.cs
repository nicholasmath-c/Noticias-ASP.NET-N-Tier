using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace ProjetoNoticia.DAL
{
    public class CategoriaDAL
    {
        //Declarar como GLOBAL um objeto da classe de Conexao
        Conexao con = new Conexao();

        //Metodo Cadastrar (nao tem retorno)
        public void Cadastrar(BLL.Categoria c)
        {
            //Configurar o Comando SQL
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO TBCategoria(NOME)
                                VALUES(@nome)";
            //Passa os valores para os parametros sql
            cmd.Parameters.AddWithValue("@nome", c.Nome);
            //Configura a conexao com o BD
            cmd.Connection = con.Conectar();
            //EXECUTA O COMANDO NO SERV.
            cmd.ExecuteNonQuery(); 
            //Encerra a conexao com o BD
            con.Desconectar();
        }

        //Metodo Atualizar (nao tem retorno)
        public void Atualizar(BLL.Categoria c)
        {
            //Configurar o Comando SQL
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE TBCategoria SET
                                    NOME = @nome
                                WHERE
                                    COD = @cod";
            //Passa os valores para os parametros sql
            cmd.Parameters.AddWithValue("@nome", c.Nome);
            cmd.Parameters.AddWithValue("@cod" , c.Cod);
            //Configura a conexao com o BD
            cmd.Connection = con.Conectar();
            //EXECUTA O COMANDO NO SERV.
            cmd.ExecuteNonQuery();
            //Encerra a conexao com o BD
            con.Desconectar();
        }

        //Metodo Excluir (nao tem retorno)
        public void Excluir(BLL.Categoria c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"DELETE FROM TBCategoria 
                                WHERE COD = @cod";
            cmd.Parameters.AddWithValue("@cod", c.Cod);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        //Metodo Consultar (retorna uma tabela de dados)
        public DataTable Consultar()
        {
            //Tabela de Dados Padrao C# (int, string, double, bool, ...)
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COD,NOME FROM TBCategoria";
            cmd.Connection = con.Conectar();

            //Adaptador de Dados SQL-->C# (int, varchar, money, bit, ...)
            SqlDataAdapter da = new SqlDataAdapter();
            //Configurar o local do comando que retorna os dados do SQL
            da.SelectCommand = cmd;
            //Preencher a tabela de dados (C#) fazendo a adaptacao dos dados SQL
            da.Fill(dt); //Somente nesta linha que executa o comando sql (select)

            con.Desconectar();
            return dt;
        }//Chave que fecha o metodo consultar

        //SOBRECARGA DE METODO
        // Metodos com o MESMO NOME porem com 
        //  ASSINATURAS DIFERENTES
        public DataTable Consultar(BLL.Categoria c)
        {
            //Tabela de Dados Padrao C# (int, string, double, bool, ...)
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT COD, NOME 
                                FROM TBCategoria
                                WHERE NOME LIKE @nome";

            cmd.Parameters.AddWithValue("@nome", "%" + c.Nome + "%" );

            cmd.Connection = con.Conectar();

            //Adaptador de Dados SQL-->C# (int, varchar, money, bit, ...)
            SqlDataAdapter da = new SqlDataAdapter();
            //Configurar o local do comando que retorna os dados do SQL
            da.SelectCommand = cmd;
            //Preencher a tabela de dados (C#) fazendo a adaptacao dos dados SQL
            da.Fill(dt); //Somente nesta linha que executa o comando sql (select)

            con.Desconectar();
            return dt;
        }

        //Metodo Retornar os dados recebendo apenas o codigo
        public BLL.Categoria RetornarCategoria(BLL.Categoria c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT Cod, Nome FROM
                                TBCategoria
                                WHERE Cod = @COD";
            cmd.Parameters.AddWithValue("@COD", c.Cod);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows) //Possui linhas de resultado ?
            {
                dr.Read(); //Ativo a leitura do DataReader
                c.Cod = Convert.ToInt32(dr["Cod"]);
                c.Nome = dr["Nome"].ToString();
                dr.Close(); //Limpar da Memoria o resultado
                con.Desconectar();
            }
            else //SENAO encontrar a categoria com o cod recebido
            {
                c.Cod = 0;
                //Zerar o cod para na interface verificar se
                //retornou uma categoria valida.
            }
            return c;
        }
    }
}