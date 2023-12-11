<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="university_7b.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Result Page</h2>
            <p>Name: <%= Request.QueryString["Name"] %></p>
            <p>Age: <%= Request.QueryString["Age"] %></p>
            <p>Mobile Number: <%= Request.QueryString["MobileNumber"] %></p>
            <p>Email: <%= Request.QueryString["Email"] %></p>
            <p>Address: <%= Request.QueryString["Address"] %></p>
        </div>
    </form>
</body>
</html>
