<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ResearchMySQLDBMS.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style ="background-color:grey;">
    <form id="form1" runat="server">
        <div style="margin:0 auto 0 auto; width:100px;">
  <center><a href="https://lh3.googleusercontent.com/XqyRLVPKs2fCPQWK51pJxmWgzrlNjulPETIdBFzapa7PaptWnRBHqSPxohcYe9bFw-He36NanuwTTXWC7wDsPf8qvIIpzUapsnc9YOoFzUQKgTQ3ORqJVg0hK28ttbWIbIrOZvavjw=w2400?source=screenshot.guru"> <img align="left" src="https://lh3.googleusercontent.com/XqyRLVPKs2fCPQWK51pJxmWgzrlNjulPETIdBFzapa7PaptWnRBHqSPxohcYe9bFw-He36NanuwTTXWC7wDsPf8qvIIpzUapsnc9YOoFzUQKgTQ3ORqJVg0hK28ttbWIbIrOZvavjw=w180-h181-p-k" /> </a></center>
           <center> <asp:Label ID="Label1" runat="server" Text="Home Page Research Paper Database" Font-Names="Verdana"></asp:Label></center><br />
           
            
            <center><asp:Label ID="Label2" runat="server" Text="Menu"></asp:Label> </center><br />

            <center><asp:Menu ID="Menu1" runat="server" BackColor="#E3EAEB" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#666666" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#E3EAEB" />
                <DynamicSelectedStyle BackColor="#1C5E55" />
                <Items>
                    <asp:MenuItem  Text="Research Centers" NavigateUrl="ResearchCenters.aspx"></asp:MenuItem>
                    <asp:MenuItem  Text="Faculty Papers" Value="Faculty Papers" NavigateUrl="FacultyPapers.aspx"></asp:MenuItem>
                    <asp:MenuItem  Text="Student Papers" Value="Student Papers" NavigateUrl="StudentPapers.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="All Theses" Value="New Item" NavigateUrl="Theses.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="All Authors" Value="All Researchers" NavigateUrl="Authors.aspx"></asp:MenuItem>
                   
                </Items>
                <StaticHoverStyle BackColor="#666666" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#1C5E55" />
            </asp:Menu></center><br />

            
            <!Table to View Searched Data: Needs to be in another page>

            
        </div>
    </form>
</body>
</html>
