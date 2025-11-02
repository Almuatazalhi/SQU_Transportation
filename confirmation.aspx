<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="confirmation.aspx.cs" Inherits="SQU_Transportation.confirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <table class="w-100">
            <tr>
                <td style="width: 179px">Trip Reference NO</td>
                <td>
                    <asp:TextBox ID="txtTripReference" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 179px">Student ID</td>
                <td>
                    <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 179px">Car registration No</td>
                <td>
                    <asp:TextBox ID="txtCarRegistration" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 179px">Driver ID</td>
                <td>
                    <asp:TextBox ID="txtDriverID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 179px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 179px">&nbsp;</td>
                <td>
                    <asp:Button ID="btnConfirm" runat="server" Text="confirmation" />
                </td>
            </tr>
        </table>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
