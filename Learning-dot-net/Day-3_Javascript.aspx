<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Day-3_Javascript.aspx.cs" Inherits="Learning_dot_net.Day_3_Javascript" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <script>  
       let str = "Apple, Banana, Kiwi"; 
        console.log(str.length);
        console.log(str.toLowerCase());
        console.log(str.split(','));
        console.log(str.substr(5, 7));
        console.log(str.substring(0, 5));

        class Car { 
            constructor(name, year) {
                this.name = name;
                this.year = year; 
            }
        }
        var car = new Car("name", 2022);
        console.log(car.name + " " + car.year);

    </script>
</asp:Content>
