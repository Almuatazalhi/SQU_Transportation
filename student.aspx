<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="SQU_Transportation.student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="w-100">
        <tr>
            <td style="width: 166px; height: 29px;">Student ID</td>
            <td style="height: 29px">
                <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 166px">Student Name</td>
            <td>
                <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 24px; width: 166px">College</td>
            <td style="height: 24px">
                <asp:TextBox ID="txtCollege" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 166px">Phone Number</td>
            <td>
                <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 166px; height: 24px;"></td>
            <td style="height: 24px">
            </td>
        </tr>
        <tr>
            <td style="width: 166px">
                <asp:Label ID="lblDestination" runat="server" ForeColor="Black" Text="Destination"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblErrorMsg1" runat="server" ForeColor="#CC3300" Text="Your Transaction was not successfull please try again !" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 166px; height: 30px;">From</td>
            <td style="height: 30px">
                <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 166px; height: 30px;">To</td>
            <td style="height: 30px">
                <asp:TextBox ID="txtTo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 166px; height: 30px;">Depature Time</td>
            <td style="height: 30px">
                <asp:DropDownList ID="ddlDepartureTime" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 166px">Returnt Time</td>
            <td>
                <asp:DropDownList ID="ddlReturnTime" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 166px">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 166px">&nbsp;</td>
            <td>
                <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
            </td>
        </tr>
    </table>
</asp:Content>
