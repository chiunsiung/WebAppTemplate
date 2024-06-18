<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmDebug.aspx.cs" Inherits="OPS.Form.Debug.frmDebug" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.16.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Src="../../Control/Debug/ucDebugListing.ascx" TagName="DebugListing" TagPrefix="uc" %>
<%@ Register Src="../../Control/Debug/ucSecondPage.ascx" TagName="SecondPage" TagPrefix="uc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="p-3 pb-0">
        <dx:ASPxLabel ID="lblDebugLabel" runat="server" 
        Font-Bold="true" Font-Size="Medium" Text="Debug Only"></dx:ASPxLabel>
    </div>
    <dx:ASPxPageControl ID="ASPxPageControl1" Width="100%" runat="server" ActiveTabIndex="0">
        <TabPages>
            <dx:TabPage Text="Debug Listing">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl" runat="server">
                        <uc:DebugListing ID="DebugListing" runat="server" />
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Add User">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl2" runat="server">
                        <uc:SecondPage ID="SecondPage" runat="server" />
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
        </TabPages>
    </dx:ASPxPageControl>
</asp:Content>
