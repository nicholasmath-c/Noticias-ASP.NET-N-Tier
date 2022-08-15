using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_noticias.BLL
{
    public class Categoria
    {

        // popriedades da tabela tb categoria

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