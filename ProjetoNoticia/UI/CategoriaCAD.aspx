<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategoriaCAD.aspx.cs" Inherits="ProjetoNoticia.UI.CategoriaCAD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Categoria</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cadastro de Categoria</h1>
            <hr />
            Cod: (Automatico)
            <br />
            Nome:
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
        </div>
    </form>
</body>
</html>
