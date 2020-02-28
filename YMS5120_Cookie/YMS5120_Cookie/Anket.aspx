<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Anket.aspx.cs" Inherits="YMS5120_Cookie.Anket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Hangi takımı tutuyorsunuz?
        <asp:RadioButtonList ID="rlbTakim" runat="server">
            <asp:ListItem Text="Galatasaray" />
            <asp:ListItem Text="Beşiktaş" />
            <asp:ListItem Text="Trabzonspor" />
            <asp:ListItem Text="Kocaelispor" />
            <asp:ListItem Text="Bursaspor" />
        </asp:RadioButtonList>
        <asp:Button Text="Oy Ver" ID="btnOyVer" OnClick="btnOyVer_Click" runat="server" />
    </div>
    </form>
</body>
</html>
