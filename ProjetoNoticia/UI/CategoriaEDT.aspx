<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategoriaEDT.aspx.cs" Inherits="ProjetoNoticia.UI.CategoriaEDT" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Atualização de Categoria</h1>
            <hr />
            Cod: <asp:Label ID="lblCod" runat="server" Text=""></asp:Label>
            <br />
            Nome:
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" OnClick="btnAtualizar_Click" />
        </div>
    </form>
</body>
</html>
