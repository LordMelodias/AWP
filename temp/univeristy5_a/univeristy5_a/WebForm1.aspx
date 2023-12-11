<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="univeristy5_a.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBoxQuery" runat="server" Width="300"></asp:TextBox><br /><br />
            <asp:Button ID="ButtonQuery" runat="server" Text="Query Data" OnClick="ButtonQuery_Click" /><br /><br />
            <br />
            <asp:TextBox ID="TextBoxResult" runat="server" TextMode="MultiLine" Rows="5" Width="300"></asp:TextBox>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:universityConnectionString %>" ProviderName="<%$ ConnectionStrings:universityConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Students]"></asp:SqlDataSource>
    </form>
</body>
</html>
