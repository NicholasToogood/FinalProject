<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyPersonalInformation.aspx.cs" Inherits="Website.ModifyPersonalInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblIntroduction" runat="server" Text="Welcome!"></asp:Label>
            <br />
            <hr />
            <br />
            <asp:Label ID="lblWorkPhone" runat="server" Text="Work Phone Number: "></asp:Label>
            <asp:TextBox ID="txtWorkPhone" runat="server"></asp:TextBox>

            <br />

            <asp:Label ID="lblCellPhone" runat="server" Text="Cell Phone Number: "></asp:Label>
            <asp:TextBox ID="txtCellPhone" runat="server"></asp:TextBox>

            <br />

            <asp:Label ID="lblHomeAddress" runat="server" Text="Home Address: "></asp:Label>
            <asp:TextBox ID="txtHomeAddress" runat="server"></asp:TextBox>

            <br />
            <asp:Button ID="btnUpdatePersonalInfo" runat="server" Text="Save" OnClick="btnUpdatePersonalInfo_Click" />
        </div>
    </form>
</body>
</html>
