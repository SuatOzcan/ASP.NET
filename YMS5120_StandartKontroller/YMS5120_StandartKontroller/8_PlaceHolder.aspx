<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="8_PlaceHolder.aspx.cs" Inherits="YMS5120_StandartKontroller._8_PlaceHolder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .uyari{
            color:green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>PLACEHOLDER</h2>
        <p>
            Sayfada daha önce olmayan ancak belirli bir işlemden sonra dinamik olarak bir kontrolün oluşturulup sayfa üzerine yerleştirilmesi için kullanılan, adından da anlaşılacağı gibi bir yer tutucudur. Eğer sayfa üzerindeki bir kontrol sayfanın geneline hitap etmiyor ve duruma göre kullanıcının karşısına çıkartılması gerekiyorsa bu gibi kontrolleri dinamik olarak oluşturup, kullanıcıya ek yük getirmemeyi sağlayabilirsiniz.
        </p>
        <hr />
        <table border="1">
            <tr>
                <td>Kullanıcı Adınızı Giriniz:</td>
                <td>
                    <asp:TextBox ID="txtKullaniciAdi" runat="server" />  
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button Text="Kaydet" ID="btnKaydet" OnClick="btnKaydet_Click" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:PlaceHolder ID="plcYerTutucu" runat="server" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
