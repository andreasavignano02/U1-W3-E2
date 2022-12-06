<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecondaPagina.aspx.cs" Inherits="U1_W3_E2.SecondaPagina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="UserText" runat="server" Text=""></asp:Label>
            <asp:Button ID="DeleteCookie" runat="server" Text="Delete" onclick="DeleteCookie_Click"/>
        </div>
    </form>
</body>
</html>
