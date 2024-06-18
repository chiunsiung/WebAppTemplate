<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionExpiry.aspx.cs" Inherits="OPS.SessionExpiry" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 64px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 60%;">
            <tr>
                <td class="style1" rowspan="6">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.png" />
                </td>
                <td colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" Font-Names="Tahoma" Font-Size="9pt" 
                        
                        Text="Your current login session is expired, please click the Link to re-login."></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Names="Tahoma" 
                        Font-Size="9pt" NavigateUrl="login.aspx" Target="_parent">VT Payment Ops Login</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
