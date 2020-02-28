<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YMS5120_QueryString.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%-- Link üzerinden direk a href ile gönderme --%>
        <a href="Bilgi.aspx?ad=BilgeAdam">Tıklayınız</a>
        <br />
        <asp:Label Text="Kullanıcı Adı: " ID="lblKAdi" runat="server" />
        <asp:TextBox ID="txtKAdi" runat="server" />
        <br />
        <asp:Label Text="Şifre: " ID="lblSifre" runat="server" />
        <asp:TextBox ID="txtSifre" runat="server" /> <br />
        <asp:Button Text="Göster" ID="btnGoster" OnClick="btnGoster_Click" runat="server" />
  
        <asp:Button  BackColor="#00ffcc" BorderStyle="Dashed" BorderColor="Yellow" CssClass="dynamic" EnableTheming ="true" runat="server"/>
        <asp:Button Text="text" ID="btnBul" OnClick="btnBul_Click" runat="server" />
    </div>
    </form>
</body>
</html>
