<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_FileUpload.aspx.cs" Inherits="YMS5120_StandartKontroller._4_FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="fuDosyaYukleyicisi" runat="server" />
        <br />
        <asp:Button Text="Dosyayı Yükle" ID="btnUpload" OnClick="btnUpload_Click" runat="server" />
    </div>
    </form>
</body>
</html>
