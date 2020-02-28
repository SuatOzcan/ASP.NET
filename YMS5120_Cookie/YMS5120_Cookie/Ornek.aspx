<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ornek.aspx.cs" Inherits="YMS5120_Cookie.Ornek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Kullanıcı Adı:
        <asp:TextBox ID="txtKAdi" runat="server" />
        Şifre:
        <asp:TextBox ID="txtSifre" runat="server" />
        <asp:Button Text="Oluştur" ID="btnOlustur" OnClick="btnOlustur_Click" runat="server" />
        <asp:Label Text="text" ID="lblAd" runat="server" />
        <asp:Label Text="text" ID="lblSifre" runat="server" />
    </div>
    </form>
</body>
</html>
