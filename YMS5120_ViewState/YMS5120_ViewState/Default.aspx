<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YMS5120_ViewState.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblFalse" EnableViewState="false" runat="server" />
        <br />
        <asp:Label ID="lblTrue" EnableViewState="true" runat="server" />
        <br />
        <asp:Button Text="Yazıları Güncelle" OnClick="Unnamed_Click" runat="server" />
        <asp:Button Text="Postback Oluştur" runat="server" />
        <hr />
        <asp:TextBox ID="txtViewState" EnableViewState="true" runat="server" />
        <br />
        <asp:Button Text="Postback Yap" ID="btnPostback" runat="server" />
    </div>
    </form>
</body>
</html>
