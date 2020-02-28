<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ornek.aspx.cs" Inherits="YMS5120_ViewState.Ornek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button Text="Arttır" ID="btnArttir" OnClick="btnArttir_Click" runat="server" />
        <br />
        <asp:Label ID="lblSayi" runat="server" />
    </div>
    </form>
</body>
</html>
