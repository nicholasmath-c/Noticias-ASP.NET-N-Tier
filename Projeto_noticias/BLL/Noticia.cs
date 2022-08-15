using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_noticias.BLL
{
    public class Noticia
    {

        private int cod;

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private string conteudo;

        public string Conteudo
        {
            get { return conteudo; }
            set { conteudo = value; }
        }


        private int cod_categoria;

        public int Cod_categoria
        {
            get { return cod_categoria; }
            set { cod_categoria = value; }
        }




    }
}