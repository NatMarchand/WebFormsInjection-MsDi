<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" CodeBehind="Index.aspx.cs" Inherits="Autofac.Integration.Web.Sample.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>Hi from Index</h1>
    <div><%=Dependency.GetFormattedTime() %></div>
    <div>Dependency #<%=Dependency.Id %></div>
</asp:Content>
