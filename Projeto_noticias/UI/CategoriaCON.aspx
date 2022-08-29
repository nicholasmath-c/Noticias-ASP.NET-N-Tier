<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategoriaCON.aspx.cs" Inherits="Projeto_noticias.UI.CategoriaCON" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Consulta de Categoria</h1>
            <hr />
            Filtro:
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
            <asp:GridView ID="gvResultado" runat="server" Width="208px">
                <EmptyDataTemplate>
                    Nenhuma Categoria Encontrada!
                </EmptyDataTemplate>
            </asp:GridView>
            <br />
        </div>
    </form>
    <p>
&nbsp;</p>
</body>
</html>
