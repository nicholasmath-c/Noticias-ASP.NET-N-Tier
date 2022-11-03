using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoNoticia.UI
{
    public partial class CategoriaCAD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Instanciar um obj da camada BLL
            BLL.Categoria c = new BLL.Categoria();
            //Preencher o obj com o conteudo da interface
            c.Nome = txtNome.Text;

            //Instanciar um objeto da camada DAL
            DAL.CategoriaDAL cDAL = new DAL.CategoriaDAL();

            //Enviar para a camada DAL o objeto da BLL preenchido
            cDAL.Cadastrar(c);

            //Escrever no HTML que esta do lado Client
            Response.Write("<script>alert('Registro Cadastrado !')</script>");

            txtNome.Text = "";
        }
    }
}