<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ModifyPO.aspx.cs" Inherits="Website.ModifyPO" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="main.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="MainContent">
        <div class="container">
            <form runat="server">
                <div class="row">
                    <div class="col-sm-5 center">
                        <h1>Modify Purchase Order</h1>
                        <h5 id="lblDate" runat="server">DATE</h5>
                        <h6 id="lblError" runat="server" style="color:red"></h6>
                    </div>
                    <div class="col-sm-5"></div>
                    <div class="col-sm-2 pagination-centered">
                        <h5>Mike Donovan</h5>
                        <h5>Information Technology</h5>
                        <h5>John Wick</h5>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-12">
                        <div class="form-group">
                            <asp:Label ID="lblOrderNumber" CssClass="control-label" runat="server" Text="Order Number"></asp:Label>
                            <asp:TextBox ID="txtOrderNumber" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:Button ID="btnId" runat="server" Text="Search By Id" OnClick="btnId_Click" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-12 col-sm-6 col-md-4">
                        <div class="form-group">
                            <asp:Label ID="lblDatePickerS" CssClass="control-label" runat="server" Text="Order Start Date"></asp:Label>
                            <asp:Calendar ID="dtpStart" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                            <asp:TextBox ID="txtStartDate" CssClass="control-label" runat="server"></asp:TextBox>
                            <br />
                            <br />
                        </div>
                    </div>
                    <div class="col-xs-12 col-sm-6 col-md-4">
                        <div class="form-group">
                            <asp:Label ID="lblDatePickerE" CssClass="control-label" runat="server" Text="Order End Date"></asp:Label>
                            <asp:Calendar ID="dtpEnd" runat="server" OnSelectionChanged="dtpEnd_SelectionChanged"></asp:Calendar>
                            <asp:TextBox ID="txtEndDate" CssClass="control-label" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col-xs-12 col-sm-6 col-md-4">
                        <div class="form-group">
                            <asp:Button ID="btnDat" runat="server" Text="Search By Date" OnClick="btnDat_Click" />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-12 col-sm-6">
                        <asp:ListBox ID="lstOrders" AutoPostBack="true" Enabled="false" runat="server" OnSelectedIndexChanged="lstOrders_SelectedIndexChanged"></asp:ListBox>
                    </div>
                    <div class="col-xs-12 col-sm-6">
                        <div class="form-group">
                            <asp:Label ID="lblSub" CssClass="control-label" runat="server" Text="Sub Total: $0.00"></asp:Label><br />
                            <asp:Label ID="lblTax" CssClass="control-label" runat="server" Text="Tax: $0.00"></asp:Label><br />
                            <asp:Label ID="lblTotal" CssClass="control-label" runat="server" Text="Total: $0.00"></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-12">
                        <asp:GridView ID="dgvItems" runat="server" AutoGenerateEditButton="true" OnRowCancelingEdit="dgvItems_RowCancelingEdit" OnRowEditing="dgvItems_RowEditing" OnRowUpdating="dgvItems_RowUpdating"></asp:GridView>
                    </div>
                </div>
            </form>
        </div>
    </div>
    <div id="clearBoth"></div>
</asp:Content>
