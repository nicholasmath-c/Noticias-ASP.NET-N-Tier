using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoNoticia.BLL
{
    public class Categoria
    {
        // propfull + [tab] + [tab]
        private int cod;
        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


    }
}