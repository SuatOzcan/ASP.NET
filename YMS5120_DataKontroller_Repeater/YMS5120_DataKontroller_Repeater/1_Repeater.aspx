<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Repeater.aspx.cs" Inherits="YMS5120_DataKontroller_Repeater._1_Repeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>REPEATER</h2>
            <p>
                Repeater, tasarlanan bir kalıp çerçevesinden belirlenin bir veri kaynağındaki tüm verilerin baştan sonra okunarak, tekrarlı bir şekilde HTML çıktısı halinde ekrana basılmasını sağlayan ASP.NET kontrolüdür. Data kontroller arasında en hızlı veri gösterme kontrolüdür. Bu kontrol üzerinden Insert,Update,Delete işlemleri gerçekleştirilmez! Sadece veri gösterme işini yapar.
            </p>
            <p>
                Bir data kontrolünün, herhangi bir şablonuna veri kaynağının bir bölümünü (DataTable => DataColumnName, Class => Property, vs..) bağlamak için #Eval("bolumAdi") ifadesi kullanılır. Eval ile bind edilmiş (yüklenmiş) veri ilgili kontrole atanır, # ile yazdırılır.
            </p>
            <p>
                Repeater hiçbir şekilde size bir HTML desteği sunmaz. Tüm tasarımsal içerik yazılımcının sorumluluğu altındadır. Yalnızca bir takım templateler kullanıma açıktır. Bu templateler;
            </p>
            <ul>
                <li>ItemTemplate => Olmazsa olmaz template'dir. Repeater bağlanan veri kaynağındaki verilerin sıralı halde gösterilmesine olanak sağlar.</li>
                <li>AlternatingItemTemplate => ItemTemplate'e alternatif olarak bir görünüm oluşturmanızı sağlar. Kullanımı tıpkı ItemTemplate gibidir.</li>
                <li>FooterTemplate => Sadece bir defa çalışan template'dir ve tüm veriler listelendikten sonra çalışır. En son aşama olarak adlandırılabilir..</li>
                <li>HeaderTemplate => En başta çalışan template'dir. Başlık görevi görür. İsterseniz bir başlık atayabilir ya da kısa bir açıklama gerçekleştirebilirsiniz.</li>
                <li>SeperatorTemplate => Ayraç template'i olarak adlandırılır. Bir template'i diğerinden ayırmak için kullanabilirsiniz. (Kısa bir çizgi çekmek vs..)</li>
            </ul>
            <hr />
        <table border="1">
            <tr>
                <td>KategoriID</td>
                <td>Kategori Adı</td>
            </tr>
            <asp:Repeater ID="rptKategoriler" OnItemCreated="rptKategoriler_ItemCreated" runat="server">
                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:Label Text='<%#Eval("CategoryID") %>' runat="server" />
                        </td>
                        <td>
                            <asp:Label Text='<%#Eval("CategoryName") %>' runat="server" />
                        </td>
                    </tr>
                </ItemTemplate>
                <AlternatingItemTemplate>
                     <tr style="background-color:pink">
                        <td>
                            <asp:Label ID="lblCategoryID" Text='<%#Eval("CategoryID") %>' runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblCategoryName" Text='<%#Eval("CategoryName") %>' runat="server" />
                        </td>
                    </tr>
                </AlternatingItemTemplate>
                <FooterTemplate>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblToplamKategoriSayisi" runat="server" />
                        </td>
                    </tr>
                </FooterTemplate>
            </asp:Repeater>
        </table>
    </div>
    </form>
</body>
</html>
