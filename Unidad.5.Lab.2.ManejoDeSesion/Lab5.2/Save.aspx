﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Save.aspx.cs" Inherits="Lab2.Save" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar" />
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Read.aspx" Target="_self">Ver texto ingresado</asp:HyperLink>
    </form>
</body>
</html>
