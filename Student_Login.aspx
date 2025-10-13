<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student_Login.aspx.cs" Inherits="SQU_Transportation.Student_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="w-100">
        <tr>
            <td style="width: 135px; height: 19px;"></td>
            <td style="height: 19px">
                <asp:Label ID="lblErrorMsg" runat="server" Text="Your login attepmt is not successful please try again" ForeColor="#CC0000" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 135px">Student ID</td>
            <td>
                <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 135px">Password</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 135px">&nbsp;</td>
            <td>
                <br />
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
