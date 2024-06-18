<%@ Page Title="VMS Portal" Language="C#" MasterPageFile="~/MasterLogin.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OPS.Login" %>


<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.16.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table cellpadding="0" cellspacing="0" width="100%" class="TextFont"
        border="0">
        <tr>
            <td>
                <br />
                <br />
                <table class="style1">
                    <tr>
                        <td class="style2" width="40%">&nbsp;</td>
                        <th colspan="2" class="style2">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Logo.png" Height="200px" Width="200px" />
                        </th>
                        <td class="style2" width="40%">&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td width="40%">&nbsp;
                        </td>
                        <td colspan="2">
                            <hr />
                        </td>
                        <td width="40%">&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td width="40%">&nbsp;
                        </td>
                        <td colspan="2">
                            <dx:ASPxLabel ID="lblUserLogin" runat="server" Font-Size="Large" Font-Names="verdana"
                                Text="BCOS Portal login" Font-Bold="True" Font-Overline="False" ForeColor="Black" />
                        </td>
                        <td width="40%">&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td width="40%">&nbsp;
                        </td>
                        <td width="150px">
                            <dx:ASPxLabel ID="lblEmail" runat="server" Font-Size="Small" Font-Names="verdana"
                                Text="Username" />
                        </td>
                        <td class="style2" width="300px">
                            <dx:ASPxTextBox ID="txtUsername" runat="server">
                            </dx:ASPxTextBox>
                        </td>
                        <td width="40%">&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td width="40%">&nbsp;
                        </td>
                        <td width="150px">
                            <dx:ASPxLabel ID="lblPassword" runat="server" Font-Size="Small" Font-Names="verdana"
                                Text="Password" />
                        </td>
                        <td class="style2" width="300px">
                            <dx:ASPxTextBox ID="txtPassword" runat="server" TextMode="Password" Password="True">
                            </dx:ASPxTextBox>
                        </td>
                        <td width="40%">&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td width="40%" style="width: 450px">&nbsp;
                        </td>
                        <td width="150px" colspan="2" style="width: 450px">
                            <table>
                                <tr>
                                    <td>
                                        <dx:ASPxButton runat="server" ID="cmdLogin" Text="Login" CausesValidation="true"
                                            CssClass="button" OnClick="cmdLogin_Click" />
                                    </td>
                                    <td class="auto-style1">
                                        <dx:ASPxButton runat="server" ID="cmdForgotPassword" Text="Forgot Password" CausesValidation="false"
                                            CssClass="button" OnClick="cmdForgotPassword_Click" />
                                    </td>

                                </tr>
                            </table>
                        </td>
                        <td width="40%" style="width: 450px">&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td width="40%" style="width: 450px">&nbsp;
                        </td>
                        <td width="150px" colspan="2" style="width: 450px">
                            <dx:ASPxLabel runat="server" ID="txtErrorMsg" ForeColor="Red" Font-Size="Small" Font-Names="verdana" />
                        </td>
                        <td width="40%" style="width: 450px">&nbsp;
                        </td>
                    </tr>
                </table>
                <br />
            </td>
        </tr>
    </table>

    <dx:ASPxPopupControl ClientInstanceName="pcMain" Width="400px" Height="50px" MinHeight="50px"
        MinWidth="150px" ID="pcMain" runat="server" EnableViewState="false" CloseAction="OuterMouseClick"
        AllowDragging="True" ShowCloseButton="true" HeaderText="MessageBox" PopupHorizontalAlign="WindowCenter"
        PopupVerticalAlign="WindowCenter">
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxLabel ID="txtPopupMessage" runat="server">
                </dx:ASPxLabel>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
</asp:Content>
