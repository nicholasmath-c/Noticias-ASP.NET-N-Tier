using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoNoticia.UI
{
    public partial class CategoriaCON : System.Web.UI.Page
    {
        BLL.Categoria cat = new BLL.Categoria();
        DAL.CategoriaDAL catDAL = new DAL.CategoriaDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Verifica se e o primeiro carregar da pagina
            if (!IsPostBack) 
            {
                //Configurar a fonte de dados da GridView
                gvResultado.DataSource = catDAL.Consultar();
                //Aplicar os dados carregados no lado Client
                gvResultado.DataBind();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            //Preencher o obj BLL com o conteudo da UI
            cat.Nome = txtFiltro.Text;
            //Preencher a Fonte de Dados da GridView
            gvResultado.DataSource = catDAL.Consultar(cat);
            //Aplicar os dados no lado Client
            gvResultado.DataBind();
        }

        protected void gvResultado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int codCategoria;
            codCategoria = Convert.ToInt32(e.CommandArgument);

            //Verifica se o comando da linha e o Excluir
            if(e.CommandName == "cmdExcluir")
            {
                //Executo o comando Excluir na DAL
                cat.Cod = codCategoria; //Preenche o obj BLL
                catDAL.Excluir(cat); //Envia para a camada DAL
                btnFiltrar_Click(null, null); //Executa o botao Filtrar
            }else if(e.CommandName == "cmdEditar")
            {
                Response.Redirect("CategoriaEDT.aspx?cod=" + codCategoria);
            }
        }
    }
}