<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategoriaCAD.aspx.cs" Inherits="Projeto_noticias.UI.CategoriaCAD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cadastrar Categoria</h1>
            <br />
            Cod: (Automático)<br />
            <br />
            Nome: <br />
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
            <br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
        </div>
    </form>
</body>
</html>
