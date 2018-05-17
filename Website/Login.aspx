<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"  CodeBehind="Login.aspx.cs" Inherits="Website.Login" %>

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
                        <img src="sneakers.png" style="width:150px; height:auto;" /><br />
                        <H3>Sneaky Sneakers</H3>
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
                    <div class="col-xs-12 col-sm-6" id="loginDiv" runat="server">
                        <div class="form-group">
                            <asp:Label ID="lblEmployeeID" runat="server" Text="Employee ID: "></asp:Label><br />
                            <asp:TextBox ID="txtEmployeeID" runat="server" ></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label><br />
                            <asp:TextBox ID="txtPassword" runat="server" type="password"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
                        </div>
                    </div>
                    <div class="col-xs-12 col-sm-6" id="logoutDiv" runat="server">
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="You're currently logged in as:"></asp:Label><br />
                            <asp:Label ID="lblCurrentLoginID" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
                        </div>
                    </div>
                    
                </div>
            </form>
        </div>
    </div>
    <div id="clearBoth"></div>
</asp:Content>
