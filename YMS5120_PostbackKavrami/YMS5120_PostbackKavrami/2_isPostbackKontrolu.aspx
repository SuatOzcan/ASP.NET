<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_isPostbackKontrolu.aspx.cs" Inherits="YMS5120_PostbackKavrami._2_isPostbackKontrolu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddlSehirler" runat="server"></asp:DropDownList>
        <br />
        <asp:Button Text="Postback Yap" ID="btnPostbackYap" runat="server" />
    </div>
    </form>
</body>
</html>
