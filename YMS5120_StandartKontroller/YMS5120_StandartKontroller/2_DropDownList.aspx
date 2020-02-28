<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_DropDownList.aspx.cs" Inherits="YMS5120_StandartKontroller._2_DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddlKategoriler" AutoPostBack="true" OnSelectedIndexChanged="btnPostbackYap_Click" runat="server"></asp:DropDownList>
        <hr />
        <asp:Button Text="Postback Yap" ID="btnPostbackYap" OnClick="btnPostbackYap_Click" runat="server" />
    </div>
    </form>
</body>
</html>
