<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="SchoolWeb.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
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
                <asp:Label ID="lblGender" CssClass="form-label text-right col-md-6" runat="server" Text="Mother's Name"></asp:Label>
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
                <asp:Label ID="lblPhone" CssClass="form-label text-right col-md-6" runat="server" Text="Phone"></asp:Label>
                <asp:TextBox ID="txtPhone" CssClass="form-control col-md-6" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblImage" CssClass="form-label text-right col-md-6" runat="server" Text="Image"></asp:Label>
                <asp:FileUpload ID="fileImage" runat="server" />
            </div> 
            <div class="form-group">
                <asp:Label ID="lblAddress" CssClass="form-label text-right col-md-6" runat="server" Text="Address"></asp:Label>
                <asp:TextBox ID="txtAddress" CssClass="form-control col-md-6" TextMode="MultiLine" runat="server"></asp:TextBox>
            </div>
            <div class="form-group text-center">
                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-success" OnClick="btnSave_Click" />
                <asp:Label ID="lblMessage" CssClass="form-label text-right col-md-6" runat="server" Text=""></asp:Label>

                </div>
        </div>
    </div>
    <div class="row">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField runat="server" HeaderText="Name" DataField="Name" > 
                </asp:BoundField>
                <asp:BoundField runat="server" HeaderText="Father's Name" DataField="FatherName" > 
                </asp:BoundField>
                <asp:BoundField runat="server" HeaderText="Mother's Name" DataField="MotherName" > 
                </asp:BoundField>
                <asp:BoundField runat="server" HeaderText="Gender" DataField="Gender" > 
                </asp:BoundField>
                <asp:BoundField runat="server" HeaderText="Phone" DataField="Phone" > 
                </asp:BoundField>
                <asp:BoundField runat="server" HeaderText="Address" DataField="Address" > 
                </asp:BoundField>
                <asp:TemplateField HeaderText="Photo">
                    <ItemTemplate>
                        <asp:Image runat="server" Width="100px" ImageUrl='<%#Eval("ImagePath","~\\StudentImages\\{0}") %>'></asp:Image>
                    </ItemTemplate>
                </asp:TemplateField>
             </Columns>
        </asp:GridView>
    </div>
</asp:Content>
