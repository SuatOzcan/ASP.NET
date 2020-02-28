<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="7_Multiview.aspx.cs" Inherits="YMS5120_StandartKontroller._7_Multiview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h2>MULTIVIEW</h2>
        <p>
            Sayfa üzerinde birden fazla şablonun tek bir kontrol içerisinde toplanmasını ve dilediğimiz zaman sayfanın herhangi bir anında, görünümün değiştirilmesine olanak sağlayan kontrolümüzdür. Örneğin, bir kayıt sayfası içerisinde (uyelik.aspx) birden fazla adımdan oluşan bir üyelik paneli oluşturmak gibi.
        </p>
        <hr />
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="view_kayitBir" runat="server">
                <table border="1">
                    <tr>
                        <td>Kullanıcı Adınızı Giriniz:</td>
                        <td>
                            <asp:TextBox ID="txtKullaniciAdi" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button Text="Sonraki Adıma Geç" ID="btnSonrakiAdim" OnClick="btnSonrakiAdim_Click" runat="server" />
                        </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="view_kayitIki" runat="server">
                <table border="1">
                    <tr>
                        <td>Şifrenizi Giriniz:</td>
                        <td>
                            <asp:TextBox ID="txtSifre" runat="server" />  
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button Text="Sonraki Adıma Geç" ID="btnSonrakiAdimaGec_Iki" OnClick="btnSonrakiAdimaGec_Iki_Click" runat="server" />
                        </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="view_kayitUc" runat="server">
                <table border="1">
                    <tr>
                        <td>Girmiş olduğunuz kullanıcı adı:</td>
                        <td>
                            <asp:Label ID="lblKullaniciAdi" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>Girmiş olduğunuz şifre:</td>
                        <td>
                            <asp:Label ID="lblSifre" runat="server" />
                        </td>
                    </tr>
                </table>
            </asp:View>
        </asp:MultiView>
    </div>
    </form>
</body>
</html>
