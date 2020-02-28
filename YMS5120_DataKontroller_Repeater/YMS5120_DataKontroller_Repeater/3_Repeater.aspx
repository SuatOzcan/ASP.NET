<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3_Repeater.aspx.cs" Inherits="YMS5120_DataKontroller_Repeater._3_Repeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .urunItem{
            width:450px;
            height:70px;
            border: 2px solid #0094ff;
            background-color:#ebb1f6;
            font-size:13px;
            font-weight:bold;
            font-family:'Comic Sans MS';
            margin-bottom:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="rptUrunler" runat="server">
            <ItemTemplate>
                <div class="urunItem">
                    <%#Eval("ProductName") %>
                    <br />
                    Fiyat: <%#Eval("UnitPrice","{0:C2}") %>
                    <br />
                    Stok Miktarı: <%#Eval("UnitsInStock") %>
                </div>
            </ItemTemplate>
            <AlternatingItemTemplate>
                <div class="urunItem" style="background-color:aliceblue;">
                    <%#Eval("ProductName") %>
                    <br />
                    Fiyat: <%#Eval("UnitPrice","{0:C2}") %>
                    <br />
                    Stok Miktarı: <%#Eval("UnitsInStock") %>
                </div>
            </AlternatingItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
