<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kategoriler.aspx.cs" Inherits="YMS5120_QueryString.Kategoriler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="rptKategori" runat="server">
            <ItemTemplate>
                <a href="<%#Eval("CategoryID","Urunler.aspx?kategoriId={0}") %>"><%#Eval("CategoryName") %></a>
                <br />
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
