<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_GridView.aspx.cs" Inherits="YMS5120_DataKontroller_GridView._2_GridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Gridview kendiliğinden update,delete gibi işlemleri destekleyen, ,sayfalama ve sıralama gerçekleştirebilen gelişmiş bir kontroldür. Sayfalama ve sıralama için smart tag'i kullanmanız yeterli olacaktır. En önemli özellik sayfa başına kaç kayıt geleceğini atayan "PageSize" özelliğidir.</p>
            <hr />
            <asp:GridView runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataKeyNames="ShipperID" DataSourceID="SqlDataSource1" ForeColor="Black" PageSize="2">
                <Columns>
                    <asp:BoundField DataField="ShipperID" HeaderText="KargoID" InsertVisible="False" ReadOnly="True" SortExpression="ShipperID" />
                    <asp:BoundField DataField="CompanyName" HeaderText="Şirket Adı" SortExpression="CompanyName" />
                    <asp:BoundField DataField="Phone" HeaderText="Telefon" SortExpression="Phone" />
                     <asp:CommandField ShowDeleteButton="True" DeleteText="Kaldır" SelectText="Seçiniz" UpdateText="Güncelleştir" EditText="Düzen" ShowEditButton="True" ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString %>" DeleteCommand="Delete from Shippers where ShipperID=@ShipperID" InsertCommand="Insert into Shippers (CompanyName,Phone) values (@CompanyName,@Phone)" SelectCommand="Select ShipperID,CompanyName,Phone from Shippers" UpdateCommand="Update Shippers Set CompanyName=@CompanyName, Phone=@Phone where ShipperID=@ShipperID">
                <DeleteParameters>
                    <asp:Parameter Name="ShipperID" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="CompanyName" />
                    <asp:Parameter Name="Phone" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="CompanyName" />
                    <asp:Parameter Name="Phone" />
                    <asp:Parameter Name="ShipperID" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
