using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoNoticia.UI
{
    public partial class CategoriaEDT : System.Web.UI.Page
    {
        BLL.Categoria cat = new BLL.Categoria();
        DAL.CategoriaDAL catDAL = new DAL.CategoriaDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            btnAtualizar.Enabled = false;
            if(!IsPostBack)
            {
                //Receber o Cod que esta vindo pela URL
                int codRecebido;
                int.TryParse(Request.QueryString["cod"], out codRecebido);

                cat.Cod = codRecebido;
                cat = catDAL.RetornarCategoria(cat);

                if (cat.Cod != 0)
                {
                    lblCod.Text = cat.Cod.ToString();
                    txtNome.Text = cat.Nome;
                    btnAtualizar.Enabled = true;
                }else
                {
                    lblCod.Text = "Categoria nao encontrada !";
                }
            }
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            cat.Cod = int.Parse(lblCod.Text);
            cat.Nome = txtNome.Text;

            catDAL.Atualizar(cat);
            Response.Redirect("CategoriaCON.aspx");
        }
    }
}