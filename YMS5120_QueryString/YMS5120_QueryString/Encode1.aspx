<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Encode1.aspx.cs" Inherits="YMS5120_QueryString.Encode1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtEncode" runat="server" />
        <asp:Button Text="Gönder" ID="btnGonder" OnClick="btnGonder_Click" runat="server" />
    </div>
    </form>
</body>
</html>
