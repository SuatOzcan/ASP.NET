<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="5_LinkButton_HyperLink_ImageButton.aspx.cs" Inherits="YMS5120_StandartKontroller._5_LinkButton_HyperLink_ImageButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ol>
                <li>LinkButton => LinkButton'un içerisinde bulunduğu form elementinde yer alan tüm değerleri, "PostbackURL" attribute'üne vermiş olduğunuz adrese "post" web metodu yardımıyla taşır. Ayrıca, HyperLink'ten farklı olarak çok önemli iki evente sahiptir. Bunlardan bir tanesi Click eventidir. LinkButton'a basıldığı zaman veriler içinde bulunulan sayfaya post edilir ancak Click eventi altına yazdığınız kodları da çalıştırabilir. Bir de Command eventi vardır. Bu event te CommandName (ilgili kontrolün üzerinde taşıyabileceği gizli komut) ve CommandArgument (o komutla beraber taşınabilecek özel bir nesne) özellikleriyle birlikte çalışmaktadır. Bir komuttan gelen verileri işleyebilme özelliğine sahiptir.
                </li>
                <li>ImageButton => LinkButton'un yaptığı her işi yapar. Aradaki tek fark biri yazı ile link verirken biri image ile link verir.
                </li>
                <li>HyperLink => Standart bir a href elementinden başka birşey oluşturmaz.
                </li>
            </ol>
            <hr />
            <asp:LinkButton Text="Google'a Gider" ID="LinkButton1" OnClick="LinkButton1_Click" CommandName="yonlendir" CommandArgument="http://www.google.com" runat="server" />
            <hr />
            <asp:ImageButton ImageUrl="~/images/29153314-0139-4e0b-837e-fb4baaa6c7ee.jpg" PostBackUrl="http://www.hepsiburada.com" runat="server" />
            <hr />
            <asp:HyperLink NavigateUrl="http://www.google.com" Text="Google'a Gider" Target="_blank" runat="server" />
            <br />
            <hr />
            <asp:LinkButton Text="Tıkla Gitsin" ID="lnkTikla" CommandName="yonlendir" CommandArgument="GoogleaGit" OnClick="lnkTikla_Click" runat="server" />
            <asp:LinkButton Text="Title Değiştir" CommandName="degisiklik" CommandArgument="Hehehe Title Böyle Değişti." OnClick="lnkTikla_Click" runat="server" />
        </div>
    </form>
</body>
</html>
