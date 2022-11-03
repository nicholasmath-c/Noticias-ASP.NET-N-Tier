<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NoticiaCAD.aspx.cs" Inherits="ProjetoNoticia.UI.NoticiaCAD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cadastro e Noticias</h1>
            <hr />
            Codigo da Noticia: (Automatico)
            <br />
            Titulo:
            <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
            <br />
            Conteudo:
            <asp:TextBox ID="txtConteudo" runat="server"></asp:TextBox>
            <br />
            Categoria (Cod):
            <asp:DropDownList ID="ddlCategoria" runat="server"></asp:DropDownList>
            <br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
        </div>
    </form>
</body>
</html>
