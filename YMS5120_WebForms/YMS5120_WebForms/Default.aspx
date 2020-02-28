<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YMS5120_WebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label Text="text" ID="lblDeger" runat="server" /><br />
        <asp:Button Text="Button" ID="Button1" OnClick="Button1_Click" runat="server" />
        <br />
        <asp:Label Text="text" ID="lblKelime" runat="server" />
        <br />
        <asp:TextBox ID="txtKelime" runat="server" />
    </div>
    </form>
</body>
</html>
