<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Day2-ValidationControls.aspx.cs" Inherits="Learning_dot_net.Day2_ValidationControls" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Dot Net validation Controls</h2>
    <div class="form-group">
        <asp:Label ID="lblUserName" runat="server" Text="User Name" CssClass="form-label col-md-4"></asp:Label>
        <div class="col-md-8">
            <asp:TextBox ID="txtUserName" CssClass="form-control" runat="server" BackColor="#CCFFCC" BorderStyle="Solid" BorderWidth="2" Font-Bold="True" Font-Italic="True" Font-Size="X-Large"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="Dynamic" CssClass="text-danger" ControlToValidate="txtUserName" runat="server" ErrorMessage="Please enter user name"></asp:RequiredFieldValidator>
           
            <asp:RangeValidator ID="RangeValidator1"  Display="Dynamic" ControlToValidate="txtUserName"  CssClass="text-danger"
                runat="server" ErrorMessage="Please enter between 3 to 5 char" MaximumValue="5" MinimumValue="3"></asp:RangeValidator>
        </div>
    </div>
    <div class="form-group">
        <asp:Label ID="lblPassword" runat="server" Text="Password" CssClass="form-label col-md-4"></asp:Label>
        <div class="col-md-8">
            <asp:TextBox ID="txtPassword" TextMode="Password" CssClass="form-control" runat="server" ToolTip="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="text-danger"  Display="Dynamic" ControlToValidate="txtPassword" runat="server" ErrorMessage="Please enter password"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="form-group">
        <asp:Label ID="Label1" runat="server" Text="Confirm Password" CssClass="form-label col-md-4"></asp:Label>
        <div class="col-md-8">
            <asp:TextBox ID="txtConfirmPassword" TextMode="Password" CssClass="form-control" runat="server" ToolTip="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="text-danger" ControlToValidate="txtConfirmPassword" runat="server" ErrorMessage="Please enter confirm password" Display="Dynamic"></asp:RequiredFieldValidator>
        
            <asp:CompareValidator ID="CompareValidator1" runat="server" CssClass="text-danger" ControlToValidate="txtPassword" ControlToCompare="txtConfirmPassword" ErrorMessage="Please enter same password" Display="Dynamic"></asp:CompareValidator>
        </div>
    </div>
    <div class="form-group text-center">
        <asp:Button ID="Button1" runat="server" Text="Login" />
    </div>

</asp:Content>
