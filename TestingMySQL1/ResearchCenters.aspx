<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResearchCenters.aspx.cs" Inherits="ResearchMySQLDBMS.ResearchCenters" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Research Centers</title>
</head>
<body>
    <a href="Default.aspx">Home</a>
    <p>Viewing all research centers at USM</p>
    <form id="form1" runat="server">
        <div>
            <center>
             <asp:GridView ID="GridView4" runat="server"><HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" /></asp:GridView></center>
        </div>
    </form>
</body>
</html>
