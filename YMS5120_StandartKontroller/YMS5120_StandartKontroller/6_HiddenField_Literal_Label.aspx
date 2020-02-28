<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="6_HiddenField_Literal_Label.aspx.cs" Inherits="YMS5120_StandartKontroller._6_HiddenField_Literal_Label" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        span{
            color:hotpink;
            text-decoration:underline;
        }
        .yazi{
            color:darkviolet;
            text-decoration:overline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>HIDDENFIELD</h2>
        <p>
            Sayfa üzerinde gizli olarak (sayfada görselliği olmadan ancak kaynak kodda kendisini görebileceğiniz şekilde) bir takım metinsel verilerin tutulmasına olanak sağlayan kontrolümüzdür. Aslında type attribute'u "hidden" olan inputtan başka birşey değildir. Özellikle ViewState kavramı içerisinde görebileceğimiz bu kontrol, en çok sayfada postback esnasında kaybedilmek istenmeyen verilerin saklanması için kullanılmaktadır.
        </p>
        <asp:HiddenField ID="hdnGizliDeger" Value="Gizli olduğu için göremiyoruz" runat="server" />
        <h2>LITERAL</h2>
        <p>
            Server tarafta HTML kodların işlenebilmesi için kullanılan kontrolümüzdür. Hemen hemen tüm kontrollerin HTML taraflı bir çıktısı vardır. (Label => Span, Button => Input, Textbox => Input..) Ancak literal kontrolünün herhangi bir HTML çıktısı yoktur ve siz üzerine ne yazarsanız, ekrana onu basar.
        </p>
        <hr />
        <asp:Label ID="lblYaziAlani" runat="server" />
        <asp:Literal ID="ltrYaziAlani" runat="server" />
        <br />
        <asp:Button Text="BAS" ID="btnLiteralvsLabel" OnClick="btnLiteralvsLabel_Click" runat="server" />
    </div>
    </form>
</body>
</html>
