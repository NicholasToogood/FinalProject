﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createpotest.aspx.cs" Inherits="Website.createpotest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" type="text/css" />
    <title></title>
</head>
<body>
    <div class="container">
        <form runat="server" class="form-horizontal">
            <div class="row">
                <%--<div class="col-xs-11" style="background-color: red;">
                    <h1>Create Pruchase Order</h1>
                    <h5 id="lblDate" runat="server">DATE</h5>
                </div>
                <div class="col-xs-1" style="background-color: blue;">
                    <h5>Mike Donovan</h5>
                    <h5>Information Technology</h5>
                    <h5>John Wick</h5>
                </div>--%>
                <div class="col-sm-5 center">
                    <h1>Create Pruchase Order</h1>
                    <h5 id="lblDate" runat="server">DATE</h5>
                </div>
                <div class="col-sm-5"></div>
                <div class="col-sm-2 pagination-centered">
                    <h5>Mike Donovan</h5>
                    <h5>Information Technology</h5>
                    <h5>John Wick</h5>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-12 col-sm-6">
                    <div class="form-group">
                        <asp:Label ID="lblName" CssClass="control-label" runat="server" Text="Item name"></asp:Label>
                        <asp:TextBox ID="txtName" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                        <div class="form-group">
                        <asp:Label ID="lblDesc" CssClass="control-label" runat="server" Text="Description"></asp:Label>
                        <asp:TextBox ID="txtDesc" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblQty" CssClass="control-label" runat="server" Text="Quantity"></asp:Label>
                        <asp:TextBox ID="txtQty" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblPrice" CssClass="control-label" runat="server" Text="Price"></asp:Label>
                        <asp:TextBox ID="txtPrice" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblLocation" CssClass="control-label" runat="server" Text="Location"></asp:Label>
                        <asp:TextBox ID="txtLocation" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblJustification" CssClass="control-label" runat="server" Text="Justification"></asp:Label>
                        <asp:TextBox ID="txtJustification" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" />
                    </div>
                </div>
                <div class="col-xs-12 col-sm-6">
                    <asp:Label ID="lblOrder" runat="server" Text="Order Number:" Visible="false"></asp:Label>
                    <asp:Label ID="lblOrderNum" runat="server" Text="0" Visible="False"></asp:Label>
                    <br /><br />
                    <asp:Label ID="lblSub" runat="server" Text="Sub Total:"></asp:Label>
                    <asp:Label ID="lblSubNum" runat="server" Text="$ 0.00"></asp:Label>
                    <br /><br />
                    <asp:Label ID="lblTax" runat="server" Text="Tax:"></asp:Label>
                    <asp:Label ID="lblTaxNum" runat="server" Text="$ 0.00"></asp:Label>
                    <br /><br />
                    <asp:Label ID="lblTotal" runat="server" Text="Total:"></asp:Label>
                    <asp:Label ID="lblTotalNum" runat="server" Text="$ 0.00"></asp:Label>
                    <br /><br />
                </div>
            </div>
        </form>
    </div>
</body>
</html>