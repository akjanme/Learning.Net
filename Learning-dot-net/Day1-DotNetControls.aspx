<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Day1-DotNetControls.aspx.cs" Inherits="Learning_dot_net.Day1_DotNetControls" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Dot Net Controls</h1>
    <div class="form-group">
        <asp:Label ID="lblName" CssClass="form-label col-md-4 text-right" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txtName" CssClass="form-control col-md-8" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="lblGender" CssClass="form-label col-md-4 text-right" runat="server" Text="Gender"></asp:Label>

        <asp:RadioButton GroupName="gender" ID="rbGenderMale" Text="Male" runat="server" />
        <asp:RadioButton GroupName="gender" ID="rbGenderFeMale" Text="Female" runat="server" />
    </div>
    <div class="form-group">
        <asp:Label ID="lblNationality" runat="server" CssClass="form-label col-md-4 text-right" Text="Nationality"></asp:Label>
        <asp:DropDownList ID="ddlNationality" CssClass="form-control" runat="server">
            <asp:ListItem Value="">Select</asp:ListItem>
            <asp:ListItem Value="Indian"> Indian </asp:ListItem>
            <asp:ListItem Value="US">American</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="form-group">
        <asp:Label ID="lblTechnologies" CssClass="form-label col-md-4 text-right" runat="server" Text="Label"></asp:Label>
        <asp:CheckBox ID="chk_c" CssClass="col-md-2" Text="C Language" runat="server" />
        <asp:CheckBox ID="chk_csharp" CssClass="col-md-2" Text="C# Language" runat="server" />
        <asp:CheckBoxList ID="chklang" CssClass="col-md-4" runat="server">
            <asp:ListItem Value="java">Java</asp:ListItem>
            <asp:ListItem Value="dotnet">Dot Net</asp:ListItem>
        </asp:CheckBoxList>
    </div>
    <div class="form-group">
        <asp:Label ID="lblDob" CssClass="form-label col-md-4 text-right" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="txtDob" CssClass="form-control col-md-4" runat="server"></asp:TextBox>
        <asp:Calendar ID="Calendar1" CssClass="col-md-4" runat="server"></asp:Calendar>
    </div>
    <div class="form-group">
        <asp:Label ID="lblDocs" CssClass="form-label col-md-4 text-right" runat="server" Text="Label"></asp:Label>
        <asp:FileUpload ID="FileUpload1" CssClass="col-md-4 form-control" runat="server" />
    </div>
</asp:Content>
