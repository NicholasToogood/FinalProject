<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ModifyPersonalInformation.aspx.cs" Inherits="Website.ModifyPersonalInformation" %>

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
                        <h1>Modify Personal Information</h1>
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
                            <asp:Label ID="lblWorkPhone" runat="server" Text="Work Phone Number: "></asp:Label><br />
                            <asp:TextBox ID="txtWorkPhone" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblCellPhone" runat="server" Text="Cell Phone Number: "></asp:Label><br />
                            <asp:TextBox ID="txtCellPhone" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblHomeAddress" runat="server" Text="Street Address: "></asp:Label><br />
                            <asp:TextBox ID="txtHomeAddress" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblCity" runat="server" Text="City: "></asp:Label><br />
                            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblPostalCode" runat="server" Text="Postal Code: "></asp:Label><br />
                            <asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="btnUpdatePersonalInfo" runat="server" Text="Save" OnClick="btnUpdatePersonalInfo_Click" />
                        </div>
                    </div>
                    
                </div>
            </form>
        </div>
    </div>
    <div id="clearBoth"></div>
</asp:Content>
