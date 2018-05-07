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
                    <asp:ListBox ID="lstOrders" runat="server"></asp:ListBox>
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
        </form>
    </div>
</asp:Content>
