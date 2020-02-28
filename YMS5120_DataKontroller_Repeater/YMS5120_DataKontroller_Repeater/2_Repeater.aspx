<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Repeater.aspx.cs" Inherits="YMS5120_DataKontroller_Repeater._2_Repeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                <asp:Repeater ID="rptCalisanlar" runat="server">
                    <ItemTemplate>
                        <li style="color: deepskyblue; font-weight: bold">
                            <asp:Label Text='<%#Eval("AdSoyad") %>' runat="server" />
                            -
                            <asp:Label Text='<%#Eval("HomePhone") %>' runat="server" />
                        </li>
                    </ItemTemplate>
                    <AlternatingItemTemplate>
                        <li style="color: darkseagreen; font-weight: bold">
                            <asp:Label Text='<%#Eval("AdSoyad") %>' runat="server" />
                            -
                            <asp:Label Text='<%#Eval("HomePhone") %>' runat="server" />
                        </li>
                    </AlternatingItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
    </form>
</body>
</html>
