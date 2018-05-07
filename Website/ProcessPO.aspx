<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ProcessPO.aspx.cs" Inherits="Website.ProcessPO" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="main.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <form runat="server">
            <div class="row">
                <div class="col-sm-3 col-xs-12">
                    <asp:GridView ID="grvOrders" runat="server"></asp:GridView>
                </div>
                <div class="col-sm-9 col-xs-12">

                </div>
            </div>
        </form>
    </div>
</asp:Content>
