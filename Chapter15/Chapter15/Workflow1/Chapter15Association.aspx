<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, 
                  PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Register Tagprefix="SharePoint" 
             Namespace="Microsoft.SharePoint.WebControls" 
             Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, 
                      PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" 
             Namespace="Microsoft.SharePoint.Utilities" 
             Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, 
                      PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" 
             Namespace="System.Web.UI" 
             Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, 
                      PublicKeyToken=31bf3856ad364e35" %>

<%@ Page Language="C#" 
    DynamicMasterPageFile="~masterurl/default.master" 
    AutoEventWireup="true" 
    Inherits="Chapter15.Workflow1.Chapter15Association" 
    CodeBehind="Chapter15Association.aspx.cs" %>

<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">
     Admin User:&nbsp;&nbsp; 
     <SharePoint:PeopleEditor 
        AllowEmpty="false"
        ValidatorEnabled="true"
        id="adminUser"
        runat="server"
        ShowCreateButtonInActiveDirectoryAccountCreationMode="true"
        SelectionSet="User" /> <br/><br/>

     Test User:&nbsp;&nbsp;  
     <SharePoint:PeopleEditor 
        AllowEmpty="false"
        ValidatorEnabled="true"
        id="testUser"
        runat="server"
        ShowCreateButtonInActiveDirectoryAccountCreationMode="true"
        SelectionSet="User" /> <br/><br/>

    <asp:Button ID="AssociateWorkflow" 
                runat="server" 
                OnClick="AssociateWorkflow_Click" 
                Text="Associate Workflow" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="Cancel" 
                runat="server" 
                Text="Cancel" 
                OnClick="Cancel_Click" />
</asp:Content>

<asp:Content ID="PageTitle" 
             ContentPlaceHolderID="PlaceHolderPageTitle" 
             runat="server">
    Workflow Association Form
</asp:Content>

<asp:Content ID="PageTitleInTitleArea" 
             runat="server" 
             ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea">
    Workflow Association Form
</asp:Content>