<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="InquireEmploymentInformation.aspx.cs" Inherits="Website.InquireEmploymentInformation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="main.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="MainContent">
        <div class="container">
            <form runat="server" class="form-horizontal">
                <div class="row">
                    <div class="col-sm-5 center">
                        <h1>Inquire Personal Information</h1>
                    </div>
                    <div class="col-sm-5"></div>
                </div>
                <div class="row">
                    <div class="col-xs-12 col-sm-6">
                        <div class="form-group">
                            <asp:Label ID="lblError" runat="server" Text="" style="color:red;"></asp:Label><br />
                            <asp:Label ID="lblSuccess" runat="server" Text="" style="color:green;"></asp:Label><br />
                        </div>
                    </div>
                    
                </div>
                <div class="row">
                    <div class="col-xs-12 col-sm-6">
                        <div class="form-group">
                            <asp:Label ID="lblStartDate" runat="server" Text="Start Date: "></asp:Label><br />
                            <asp:Calendar ID="dtpStart" runat="server"></asp:Calendar>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblEndDate" runat="server" Text="End Date: "></asp:Label><br />
                            <asp:Calendar ID="dtpEnd" runat="server"></asp:Calendar>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                        </div>
                    </div>
                    
                </div>
                <div class="row">
                    <div class="col-xs-12">
                        <asp:GridView ID="dgvItems" runat="server" ></asp:GridView>
                    </div>
                </div>
            </form>
        </div>
    </div>
    <div id="clearBoth"></div>
</asp:Content>
