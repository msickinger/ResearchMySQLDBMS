<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentPapers.aspx.cs" Inherits="ResearchMySQLDBMS.StudentPapers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Research Papers</title>
</head>
<body>
    <p>Viewing all student research papers</p>
    <a href="Default.aspx">Home</a> 
    <form id="form1" runat="server">
        <div>
          <center>  <asp:GridView ID="GridView2" runat="server"> <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" />
            </asp:GridView></center>
        </div>
    </form>
</body>
</html>
