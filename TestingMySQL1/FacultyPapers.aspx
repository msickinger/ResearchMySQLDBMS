<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FacultyPapers.aspx.cs" Inherits="ResearchMySQLDBMS.FacultyPapers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Faculty Research Papers</title>
</head>
<body>
    
    <a href="Default.aspx">Home</a>
    <p>Viewing all faculty research papers</p>
    <form id="form1" runat="server">
        <div>
            <center>
            <asp:GridView ID="GridView3" runat="server"><HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" /></asp:GridView>

            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Insert Data for Faculty Paper (inserts into database)"></asp:Label>
            <br />
            <asp:TextBox ID="f_id" Text="Enter faculty ID here" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="f_name" Text="Enter Name here" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="dept_name" Text="Enter department name here" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="title" Text="Enter paper title here" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="type" Text="Enter type of paper here" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="p_year" Text="Enter year of publication" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="center_name" Text="Enter name of research center here" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="j_name" Text="Enter journal name" runat="server"></asp:TextBox><br />
                <asp:TextBox ID="volume" Text="Enter volume of journal" runat="server"></asp:TextBox><br />
                <asp:TextBox ID="number" Text="Enter issue of journal" runat="server"></asp:TextBox><br />
               
           
            <asp:Button ID="submitFacultyInfo" runat="server" Text="Submit data" OnClick="submitFacInfoEvent"/>
            </center>
        </div>
    </form>
</body>
</html>
