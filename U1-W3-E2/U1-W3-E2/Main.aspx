<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="U1_W3_E2.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span>USERNAME:<asp:TextBox ID="User" runat="server"></asp:TextBox><%--<asp:CustomValidator ID="CustomValidator1" ControlToValidate="User" runat="server" ErrorMessage="Non hai inserito un Username"></asp:CustomValidator>--%></span>
            <span>PASSWORD:<asp:TextBox ID="Password" runat="server"></asp:TextBox></span>
            <asp:Button ID="Submit" runat="server" Text="Button" onclick="Submit_Click"/>
        </div>
    </form>
</body>
</html>
