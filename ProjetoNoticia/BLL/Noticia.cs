using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoNoticia.BLL
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

        private int codCategoria;
        public int CodCategoria
        {
            get { return codCategoria; }
            set { codCategoria = value; }
        }

    }
}