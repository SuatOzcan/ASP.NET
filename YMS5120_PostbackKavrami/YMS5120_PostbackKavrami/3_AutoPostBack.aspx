<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3_AutoPostBack.aspx.cs" Inherits="YMS5120_PostbackKavrami._3_AutoPostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Yaşadığınız il : <asp:DropDownList ID="ddlIl" OnSelectedIndexChanged="ddlIl_SelectedIndexChanged" AutoPostBack="true" runat="server"></asp:DropDownList>
    Yaşadığınız ilçe: <asp:DropDownList ID="ddlIlce" runat="server"></asp:DropDownList>
    </div>
    </form>
</body>
</html>
