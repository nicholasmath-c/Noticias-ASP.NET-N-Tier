using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoNoticia.UI
{
    public partial class NoticiaCAD : System.Web.UI.Page
    {
        DAL.CategoriaDAL catDAL = new DAL.CategoriaDAL();

        BLL.Noticia noticia = new BLL.Noticia();
        //Instanciar a DAL de noticia !
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //Configurar a fonte de dados da DropDownList
                ddlCategoria.DataSource = catDAL.Consultar();
                //Configurar qual coluna do BD sera EXIBIDA
                ddlCategoria.DataTextField = "NOME";
                //Configurar qual coluna do BD sera utilizada como VALOR
                ddlCategoria.DataValueField = "COD";
                //Aplicar na Interface do Usuario os dados da DropDownList
                ddlCategoria.DataBind();
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            noticia.Titulo = txtTitulo.Text;
            noticia.Conteudo = txtConteudo.Text;
            noticia.CodCategoria =
                Convert.ToInt32(ddlCategoria.SelectedValue);
        }
    }
}