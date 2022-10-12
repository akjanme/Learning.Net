<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Day4-Jquery.aspx.cs" Inherits="Learning_dot_net.Day4_Jquery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3></h3>
    <div class="form-group">
        <asp:Label ID="lblName" CssClass="form-label col-md-4 text-right" runat="server" Text="Name"></asp:Label>
        <input type="text" id="txtName" onkeypress="setName()" class="form-control col-md-8"></input>
        <br />
        <br />
        <span id="spnName"></span>
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
    </div>
    <div class="form-group">
        <asp:Label ID="lblDocs" CssClass="form-label col-md-4 text-right" runat="server" Text="Label"></asp:Label>
        <asp:FileUpload ID="FileUpload1" CssClass="col-md-4 form-control" runat="server" />
    </div>
    <p>We recommend reading this tutorial, in the sequence listed in the menu.</p>

    <p>If you have a large screen, the menu will always be present on the left.</p>

    <p>If you have a small screen, open the menu by clicking the top menu sign <span class="w3-xlarge">☰</span>.</p>
    
    <p>
        Examples are better than 1000 words. Examples are often easier to understand 
than text explanations.
    </p>


    <script>
        function setName() {
            $('#spnName').text($('#txtName').val());
        }
    </script>

</asp:Content>
