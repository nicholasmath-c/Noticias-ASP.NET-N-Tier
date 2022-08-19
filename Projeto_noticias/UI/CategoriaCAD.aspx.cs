using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_noticias.UI
{
    public partial class CategoriaCAD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Instanciar um OBJ da camada BLL
            BLL.Categoria c = new BLL.Categoria();
            c.Nome = txtNome.Text;

            //Instanciar um OBJ da camada DAL
            DAL.CategoriaDAL cDAL = new DAL.CategoriaDAL();

            //Enviar para a camada DAL o objeto BLL preenchido
            cDAL.Cadastrar(c);

            //Escrever no HTML que está do lado Client
            Response.Write("<script>alert('Registro Cadastrado!')</script>");
        }
    }
}