using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_noticias.UI
{
    public partial class CategoriaCON : System.Web.UI.Page
    {
        BLL.Categoria cat = new BLL.Categoria();
        DAL.CategoriaDAL catDAL = new DAL.CategoriaDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //Verifica se é o primeiro carregar de pagina
            {
                //Configurar a fonte de dados da GridView
                gvResultado.DataSource = catDAL.Consultar();
                //Aplicar os dados carregados no lado Client
                gvResultado.DataBind();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            //Preencher o obj BLL com o conteúdo da UI
            cat.Nome = txtFilter.Text;
            //Preencher a fonte de dados da gridview
            gvResultado.DataSource = catDAL.Consultar(cat);
            //Aplicar os dados no lado Client
            gvResultado.DataBind();
        }
    }
}