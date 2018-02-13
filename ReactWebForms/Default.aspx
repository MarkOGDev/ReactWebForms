<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ReactWebForms._Default" %>

<%@ Register Assembly="ReactWebForms" Namespace="ReactWebForms.Controls" TagPrefix="ReactWebForms" %>

 

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>ReactJs.Net Web Forms</h1>
    <p>Using React.Component</p>

 

    <div style="border: 1px solid green; min-height: 50px;">
        <ReactWebForms:ReactComponentSelector ID="ReactComponentSelector1" runat="server" ComponentName="HelloWorld" HelloWorldUserName="Mr Mark" />
        <ReactWebForms:ReactComponentSelector ID="ReactComponentSelector2" runat="server" ComponentName="HelloWorld2" HelloWorldUserName="Mr Ben" />
        <ReactWebForms:ReactComponentSelector ID="ReactComponentSelector3" runat="server" ComponentName="ReactImage" ReactImageName="MyImageName" />
    </div>
     
</asp:Content>
