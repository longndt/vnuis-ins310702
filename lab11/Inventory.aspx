<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inventory.aspx.cs" Inherits="lab11.Inventory1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>Inventories Table</strong><br />
            <asp:GridView ID="gvInventories" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="AutoLotModel" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="CarId" HeaderText="CarId" ReadOnly="True" SortExpression="CarId" />
                    <asp:BoundField DataField="Make" HeaderText="Make" ReadOnly="True" SortExpression="Make" />
                    <asp:BoundField DataField="Color" HeaderText="Color" ReadOnly="True" SortExpression="Color" />
                    <asp:BoundField DataField="PetName" HeaderText="PetName" ReadOnly="True" SortExpression="PetName" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:EntityDataSource ID="AutoLotModel" runat="server" ConnectionString="name=AutoLotEntities" DefaultContainerName="AutoLotEntities" EnableFlattening="False" EntitySetName="Inventories" EntityTypeFilter="Inventory" Select="it.[CarId], it.[Make], it.[Color], it.[PetName]">
            </asp:EntityDataSource>
            <br />
        </div>
    </form>
</body>
</html>
