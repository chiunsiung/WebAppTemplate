<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucDebugListing.ascx.cs" Inherits="OPS.Control.Debug.ucDebugListing" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.16.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<div class="d-flex flex-column gap-3 pt-3" style="width: 60%">
    <div class="row">
        <div class="col">
            <div class="d-flex align-items-center gap-3">
                <dx:ASPxLabel ID="lblTitle" runat="server" Text="Title"></dx:ASPxLabel>
                <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="col">
            <div class="d-flex align-items-center gap-3">
                <dx:ASPxLabel ID="lblCategory" runat="server" Text="Category"></dx:ASPxLabel>
                <asp:DropDownList ID="cbbCategory" runat="server" CssClass="form-select" DataSourceID="sqlCategory"
                    DataTextField="TextField" DataValueField="ValueField" ValueType="System.String" />
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col">
            <div class="d-flex align-items-center gap-3">
                <dx:ASPxButton ID="cmdSearch" runat="server" Text="Search">
                </dx:ASPxButton>
                <dx:ASPxButton ID="cmdExportExcel" runat="server" Text="Export Excel"
                    OnClick="cmdExportExcel_Click">
                </dx:ASPxButton>
            </div>
        </div>
    </div>
</div>

<dx:ASPxGridViewExporter ID="grdExport" runat="server" GridViewID="grdData">
</dx:ASPxGridViewExporter>

<dx:ASPxGridView ID="grdData" runat="server" Width="100%" AutoGenerateColumns="False" DataSourceID="SqlDataSource" KeyFieldName="Id">

    <Templates>
        <DetailRow>
            <dx:ASPxGridView ID="grdDetails" ClientInstanceName="grdDetails"
                runat="server" 
                DataSourceID="sqlMasterDevice" KeyFieldName="Id"
                OnBeforePerformDataSelect="grdDetails_DataSelect">

                <SettingsPager PageSize="20" />
                <Settings ShowFilterRow="True" />
                <SettingsBehavior ConfirmDelete="true" />
                <SettingsText ConfirmDelete="Are you sure you want to delete the row?" />

                <Columns>
                    <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowNewButtonInHeader="True" VisibleIndex="0">
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="Id" VisibleIndex="1">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Title" VisibleIndex="2">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="TempId" VisibleIndex="3">
                    </dx:GridViewDataTextColumn>
                </Columns>
            </dx:ASPxGridView>
        </DetailRow>
    </Templates>

    <SettingsDetail ShowDetailRow="true" />
    <Settings ShowFilterRow="True" ShowGroupPanel="True" />
    <SettingsSearchPanel Visible="True" />
    <SettingsBehavior ConfirmDelete="true" />
    <SettingsText ConfirmDelete="Are you sure you want to delete the row?" />
    <Columns>
        <dx:GridViewCommandColumn ShowClearFilterButton="True" ShowDeleteButton="True" ShowEditButton="True" ShowNewButtonInHeader="True" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" VisibleIndex="1">
            <EditFormSettings Visible="False" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="Title" VisibleIndex="2">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="Quantity" VisibleIndex="3">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="Price" VisibleIndex="4">
            <PropertiesTextEdit DisplayFormatString="#.00#"></PropertiesTextEdit>  
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataComboBoxColumn FieldName="Category" VisibleIndex="5">
            <PropertiesComboBox DataSourceID="sqlCategory_Normal" TextField="TextField" ValueField="ValueField">
            </PropertiesComboBox>
        </dx:GridViewDataComboBoxColumn>
        <dx:GridViewDataDateColumn FieldName="Create_At" Caption="Added" VisibleIndex="7">
            <PropertiesDateEdit DisplayFormatString="yyyy-MM-dd HH:mm:ss" EditFormatString="yyyy-MM-dd HH:mm:ss">
            </PropertiesDateEdit>
        </dx:GridViewDataDateColumn>
    </Columns>
</dx:ASPxGridView>


<asp:SqlDataSource ID="SqlDataSource" runat="server" 
    ConnectionString="<%$ ConnectionStrings:TestingDBConnectionString %>" 
    SelectCommand="NSP_TTemp_SelectByTitleAndCategory" SelectCommandType="StoredProcedure"
    DeleteCommand="NSP_TTemp_Delete" DeleteCommandType="StoredProcedure" 
    InsertCommand="NSP_TTemp_Insert" InsertCommandType="StoredProcedure" 
    UpdateCommand="NSP_TTemp_Update" UpdateCommandType="StoredProcedure">
    <DeleteParameters>
        <asp:Parameter Name="Id" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="Title" Type="String" />
        <asp:Parameter Name="Quantity" Type="Int32" />
        <asp:Parameter Name="Price" Type="Decimal" />
        <asp:Parameter Name="Category" Type="String" />
        <asp:Parameter Name="MetaData" Type="String" />
        <asp:Parameter Name="Create_By" Type="String" />
        <asp:Parameter Name="Create_At" Type="DateTime" />
    </InsertParameters>
    <SelectParameters>
        <asp:ControlParameter ControlID="txtTitle" DefaultValue="%" Name="Title" PropertyName="Text" Type="String" />
        <asp:ControlParameter ControlID="cbbCategory" DefaultValue="%" Name="Category" PropertyName="SelectedValue" Type="String" />
    </SelectParameters>
    <UpdateParameters>
        <asp:Parameter Name="Id" Type="Int32" />
        <asp:Parameter Name="Title" Type="String" />
        <asp:Parameter Name="Quantity" Type="Int32" />
        <asp:Parameter Name="Price" Type="Decimal" />
        <asp:Parameter Name="Category" Type="String" />
        <asp:Parameter Name="MetaData" Type="String" />
        <asp:Parameter Name="Create_By" Type="String" />
        <asp:Parameter Name="Create_At" Type="DateTime" />
    </UpdateParameters>
</asp:SqlDataSource>

<asp:SqlDataSource ID="sqlCategory" runat="server"
    ConnectionString="<%$ ConnectionStrings:TestingDBConnectionString %>"
    SelectCommand="NSP_TTemp_Select_For_DropDown" SelectCommandType="StoredProcedure">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="SelectedAll" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>

<asp:SqlDataSource ID="sqlCategory_Normal" runat="server"
    ConnectionString="<%$ ConnectionStrings:TestingDBConnectionString %>"
    SelectCommand="NSP_TTemp_Select_For_DropDown" SelectCommandType="StoredProcedure">
    <SelectParameters>
        <asp:Parameter DefaultValue="0" Name="SelectedAll" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>

<asp:SqlDataSource runat="server" ID="sqlMasterDevice" 
    ConnectionString="<%$ ConnectionStrings:TestingDBConnectionString %>" 
    SelectCommand="NSP_TTempDetail_SelectByTempId" SelectCommandType="StoredProcedure"
    DeleteCommand="NSP_TTempDetail_Delete" DeleteCommandType="StoredProcedure" 
    InsertCommand="NSP_TTempDetail_Insert" InsertCommandType="StoredProcedure" 
    UpdateCommand="NSP_TTempDetail_Update" UpdateCommandType="StoredProcedure">
    <SelectParameters>
        <asp:SessionParameter DefaultValue="-1" Name="TempId" SessionField="TempId" Type="Int32" />
    </SelectParameters>
    <DeleteParameters>
        <asp:Parameter Name="Id" Type="Int32" />
    </DeleteParameters>
    <UpdateParameters>
        <asp:Parameter Name="Id" Type="Int32" />
        <asp:Parameter Name="Title" Type="String" />
        <asp:Parameter Name="TempId" Type="Int32" />
    </UpdateParameters>
    <InsertParameters>
        <asp:Parameter Name="Title" Type="String" />
        <asp:Parameter Name="TempId" Type="Int32" />
    </InsertParameters>
</asp:SqlDataSource>