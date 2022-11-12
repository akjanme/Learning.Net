<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="SchoolWeb.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    <div class="row">
        <div class="form-horizontal">
            <div class="form-group">
                <asp:Label ID="lblName" CssClass="form-label text-right col-md-6" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="txtName" CssClass="form-control col-md-6" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblFname" CssClass="form-label text-right col-md-6" runat="server" Text="Father' Name"></asp:Label>
                <asp:TextBox ID="txtFatherName" CssClass="form-control col-md-6" runat="server"></asp:TextBox>
            </div> 
            <div class="form-group">
                <asp:Label ID="lblGender" CssClass="form-label text-right col-md-6"  runat="server" Text="Mother's Name"></asp:Label>
                <asp:RadioButtonList ID="rdoGender" runat="server" RepeatDirection="Horizontal">
                     <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                    <asp:ListItem Text="FeMale" Value="FeMale"></asp:ListItem>
                </asp:RadioButtonList>
                </div>
            <div class="form-group">
                <asp:Label ID="lblMotherName" CssClass="form-label text-right col-md-6" runat="server" Text="Mother's Name"></asp:Label>
                <asp:TextBox ID="txtMotherName" CssClass="form-control col-md-6" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblImage" CssClass="form-label text-right col-md-6" runat="server" Text="Image"></asp:Label>
                <asp:FileUpload ID="fileImage" runat="server" />
                </div>
            <div class="form-group text-center">
                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-success" />
            </div>
        </div>
    </div>
</asp:Content>
