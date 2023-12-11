<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="univeristy3_b.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Advertisement Rotator</h2>
           <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="XmlDataSource1" />
<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/adver.xml"></asp:XmlDataSource>

            <br />
            <label>Filter by Keyword: </label>
            <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="btnFilter" runat="server" Text="Filter" OnClick="btnFilter_Click" />
        </p>
    </form>
</body>
</html>
