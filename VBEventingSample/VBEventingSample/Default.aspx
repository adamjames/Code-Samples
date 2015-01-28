<%@ Page Title="Home Page" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Default.aspx.vb" Inherits="VBEventingSample._Default" %>

<%@ Register TagPrefix="uc1" TagName="SimpleUserControl" Src="SimpleUserControl.ascx" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <p>This is a page with a UserControl embedded within it. The UserControl contains buttons which fire various events.</p>
    <p>The page picks up these events and handles them, changing the text shown in the label below.</p>
    
    <br /><br /> <!-- Using line breaks for spacing is poor practice. This is just for illustration.--> 
    
    <asp:Label ID="lblPageLastRefreshed" Font-Bold="true" runat="server"></asp:Label><br /><br />
    <asp:Button ID="btnRefresh" Text="Ordinary Postback" runat="server" /><br /><br /> 

    <!-- Need to register the user control at the top so that we can use it here. -->
    <uc1:SimpleUserControl ID="myUserControl" runat="server" />
</asp:Content>
