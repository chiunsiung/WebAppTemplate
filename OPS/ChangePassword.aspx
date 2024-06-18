<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="OPS.ChangePassword" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.16.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="height: 50px" colspan="3">
                <dx:ASPxLabel ID="txtFirstTimeLogin" runat="server" Font-Bold="True" Font-Size="12pt" Text ="Please change your password."
                    ForeColor="Red">
                </dx:ASPxLabel>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 150px; height: 50px">
                <dx:ASPxLabel ID="lblOldPassword" runat="server"  Text="Old Password">
                </dx:ASPxLabel>
            </td>
            <td style="width: 250px">
                <dx:ASPxTextBox ID="txtOldPassword" runat="server" Width="250px" Password="True">
                </dx:ASPxTextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 150px; height: 50px">
                <dx:ASPxLabel ID="lblNewPassword" runat="server" Text="New Password">
                </dx:ASPxLabel>
            </td>
            <td style="width: 250px">
                <dx:ASPxTextBox ID="txtNewPassword" runat="server" Width="250px" ToolTip="Min 8 chars, 1 uppercase & alphanumeric (ie Numoni88)"
                    NullText="Min 8 chars, 1 uppercase &amp; alphanumeric (ie Numoni88)" Password="True">
                </dx:ASPxTextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 150px; height: 50px">
                <dx:ASPxLabel ID="lblConfirmPassword" runat="server"  Text="Retype New Password">
                </dx:ASPxLabel>
            </td>
            <td style="width: 250px">
                <dx:ASPxTextBox ID="txtRetypeNewPassword" runat="server" Width="250px" ToolTip="Min 8 chars, 1 uppercase & alphanumeric (ie Numoni88)"
                    NullText="Min 8 chars, 1 uppercase &amp; alphanumeric (ie Numoni88)" Password="True">
                </dx:ASPxTextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 150px; height: 50px">
            </td>
            <td style="width: 250px">
                <table>
                    <tr>
                        <td>
                            <dx:ASPxButton ID="cmdReset" runat="server" text="Reset">
                            </dx:ASPxButton>
                        </td>
                        <td>
                            <dx:ASPxButton ID="cmdChangePassword" runat="server" Text="Change Password" OnClick="cmdChangePassword_Click">
                                <ClientSideEvents Click="function(s, e) 
                                {
                                  e.processOnServer = confirm('Do you want to change your password?');

                                }" />
                            </dx:ASPxButton>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="height: 50px" colspan="2">
                <dx:ASPxLabel ID="txtMessage" runat="server">
                </dx:ASPxLabel>
            </td>
            <td>
                &nbsp;
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
