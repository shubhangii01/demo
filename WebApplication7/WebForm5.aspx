<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication7.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 295px">
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateEditButton="True" Height="268px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Width="381px" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5">
        </asp:GridView>
    </form>
</body>
</html>
