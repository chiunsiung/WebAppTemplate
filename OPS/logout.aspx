<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="logout.aspx.cs" Inherits="OPS.logout" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.16.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
           <dx:ASPxGridView ID="grdData" runat="server"   >
        <Settings ShowGroupPanel="True" />
        <SettingsSearchPanel Visible="True" />
        
    </dx:ASPxGridView>
    </div>
    </form>
</body>
</html>
