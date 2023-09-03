<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:Button ID="Button1" runat="server" Text="Celsius to Fahrenheit" OnClick="Button1_Click" />
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br />
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Fahrenheit to Celsius" />
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
<br />
<br />
<br />
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Sort" />
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
<br />

</asp:Content>
