<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3_ListBox.aspx.cs" Inherits="YMS5120_StandartKontroller._3_ListBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddlKategoriler" AutoPostBack="true" OnSelectedIndexChanged="ddlKategoriler_SelectedIndexChanged" runat="server"></asp:DropDownList>
        <br />
        <asp:ListBox ID="lstUrunler" Width="300" Height="300" runat="server"></asp:ListBox>
    </div>
    </form>
</body>
</html>
