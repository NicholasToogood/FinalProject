<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ProcessPO.aspx.cs" Inherits="Website.ProcessPO" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="main.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <form runat="server">
            <div class="row">
                <div class="col-sm-2 col-xs-6">
                    <asp:ListBox ID="lstOrders" AutoPostBack="true" runat="server" OnSelectedIndexChanged="lstOrders_SelectedIndexChanged"></asp:ListBox>
                </div>
                <div class="col-sm-3 col-xs-6">
                    <asp:RadioButton ID="rdoPending" AutoPostBack="true" runat="server" GroupName="rdoSrh" Text="Pending" Checked="true" OnCheckedChanged="rdoPending_CheckedChanged" /><br />
                    <asp:RadioButton ID="rdoClosed" AutoPostBack="true" runat="server" GroupName="rdoSrh" Text="Closed" OnCheckedChanged="rdoClosed_CheckedChanged" /><br />
                    <asp:RadioButton ID="rdoAll" AutoPostBack="true" runat="server" GroupName="rdoSrh" Text="All Orders" OnCheckedChanged="rdoAll_CheckedChanged" />
                </div>
                <div class="col-sm-7 col-xs-12">
                    <div class="form-group">
                        <asp:Label ID="lblEmpName" CssClass="control-label" runat="server" Text="Employee Name"></asp:Label>
                        <asp:TextBox ID="txtEmpName" CssClass="control-label" runat="server"></asp:TextBox>
                        <br />
                        <br />
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-5">
                    <asp:Label ID="lblOrderNumberLabel" CssClass="control-label" runat="server" Text="Order Number:"></asp:Label>
                    <asp:Label ID="lblOrderNumber" CssClass="control-label" runat="server" Text="00000000"></asp:Label>
                    <br />
                    <asp:Label ID="lblEmpNameLabel" CssClass="control-label" runat="server" Text="Employee Name:"></asp:Label>
                    <asp:Label ID="lblEmpNameOrder" CssClass="control-label" runat="server" Text="Mike Donovan"></asp:Label>
                </div>
                <div class="col-sm-5">
                    <asp:Label ID="lblDateLabel" CssClass="control-label" runat="server" Text="Date:"></asp:Label>
                    <asp:Label ID="lblDate" CssClass="control-label" runat="server" Text="DATE"></asp:Label>
                    <br />
                    <asp:Label ID="lblTotalLabel" CssClass="control-label" runat="server" Text="Total:"></asp:Label>
                    <asp:Label ID="lblTotal" CssClass="control-label" runat="server" Text="$190.93"></asp:Label>
                    <br />
                    <asp:Label ID="lblOrderStatusLabel" CssClass="control-label" runat="server" Text="Order Status:"></asp:Label>
                    <asp:Label ID="lblOrderStatus" CssClass="control-label" runat="server" Text="Pending"></asp:Label>
                </div>
                <div class="col-sm-2">
                    <asp:Button ID="btnSearchName" runat="server" Text="Search By Name" />
                    <asp:Button ID="btnSearchDate" runat="server" Text="Search By Date" />
                </div>
            </div>
            <div class="row">
                <div class="col-xs-12">
                    <asp:GridView ID="grvItems" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="grvItems_SelectedIndexChanged"></asp:GridView>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-12">
                    <asp:Button ID="btnApprove" runat="server" Text="Approve" Visible="false" OnClick="btnApprove_Click" />
                    <asp:Button ID="btnDeny" runat="server" Text="Deny" Visible="false" OnClick="btnDeny_Click" />
                    <asp:Button ID="btnMod" runat="server" Text="Modify" Visible="false" OnClick="btnMod_Click"/>
                    <asp:Button ID="btnClose" runat="server" Text="Close Purchase Order" Visible="false" OnClick="btnClose_Click" />
                </div>
            </div>
            <div class="row">
                <br /><br />
                <div class="col-xs-12 col-sm-4">
                    <asp:Label ID="lblModQty" Visible="false" runat="server" Text="Quantity:"></asp:Label>
                    <asp:TextBox ID="txtModQty" Visible="false" runat="server"></asp:TextBox>
                </div>
                <div class="col-xs-12 col-sm-4">
                    <asp:Label ID="lblModPrice" Visible="false" runat="server" Text="Price:"></asp:Label>
                    <asp:TextBox ID="txtModPrice" Visible="false" runat="server"></asp:TextBox>
                </div>
                <div class="col-xs-12 col-sm-4">
                    <asp:Label ID="lblModLocation" Visible="false" runat="server" Text="Location:"></asp:Label>
                    <asp:TextBox ID="txtModLocation" Visible="false" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-12">
                    <asp:Label ID="lblModReason" Visible="false" runat="server" Text="Reason For Modification:"></asp:Label>
                    <asp:TextBox ID="txtModReason" Visible="false" runat="server"></asp:TextBox>
                </div>
                <div class="col-xs-12">
                    <asp:Button ID="btnModApprove" Visible="false" runat="server" Text="Approve With Modifications" OnClick="btnModApprove_Click" />
                </div>
            </div>
        </form>
    </div>
</asp:Content>
