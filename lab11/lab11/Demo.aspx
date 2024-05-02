<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="lab11.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 490px">
    <form id="form1" runat="server">
        <div>
            ADD NEW STUDENT<br />
            <br />
            Username</div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Password<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Gender"></asp:Label>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        Graduated ?<br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Yes" />
        <br />
        <br />
        Avatar<br />
        <asp:Image ID="Image1" runat="server" Height="275px" ImageUrl="~/Images/student.jpg" Width="307px" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
    </form>
</body>
</html>
