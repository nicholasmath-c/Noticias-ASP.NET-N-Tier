<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategoriaCON.aspx.cs" Inherits="ProjetoNoticia.UI.CategoriaCON" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Consulta de Categorias</h1>
            <hr />
            Filtro:
            <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
            <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" style="height: 26px" />
            <br />
            <br />
            <asp:GridView ID="gvResultado" runat="server" OnRowCommand="gvResultado_RowCommand">
                <Columns>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="btnExcluir" runat="server" CausesValidation="false" CommandName="cmdExcluir" CommandArgument='<%#Eval("Cod")%>' OnClientClick="return confirm('Deseja Realmente Exluir ?')" Text="Excluir" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="btnEditar" runat="server" CausesValidation="false" CommandName="cmdEditar" CommandArgument='<%#Eval("Cod")%>' Text="Editar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>
                    Nenhuma Categoria Encontrada !
                </EmptyDataTemplate>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
