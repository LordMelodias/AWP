<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="university3_a.WebForm1" %>
<%@ Register Src="~/WebUserControl1.ascx" TagName="Footer" TagPrefix="uc" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 align="center" >Valia College</h1><br /><br />
            <uc:Footer ID="Footer1" runat="server" />
        </div>
    </form>
</body>
</html>
