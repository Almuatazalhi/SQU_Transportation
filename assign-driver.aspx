<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="assign-driver.aspx.cs" Inherits="SQU_Transportation.assign_driver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <table class="w-100">
            <tr>
                <td style="width: 137px">Driver ID</td>
                <td style="width: 180px">
                    <asp:TextBox ID="txtDriverID" runat="server"></asp:TextBox>
                </td>
                <td rowspan="7">
                    <asp:Image ID="imgDriver" runat="server" Height="249px" ImageAlign="Middle" Width="242px" />
                    <br />
                    &nbsp;<br />
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 137px">Driver Name</td>
                <td style="width: 180px">
                    <asp:TextBox ID="txtDriverName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 137px">Status</td>
                <td style="width: 180px">
                    <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 137px">
                    <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="&lt;" Width="72px" />
                </td>
                <td style="width: 180px">
                    <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="&gt;" Width="75px" />
                </td>
            </tr>
            <tr>
                <td style="width: 137px">
                    <asp:Button ID="btnFirst" runat="server" OnClick="btnFirst_Click" Text="&lt;&lt;" Width="74px" />
                </td>
                <td style="width: 180px">
                    <asp:Button ID="btnLast" runat="server" OnClick="btnLast_Click" Text="&gt;&gt;" Width="74px" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="#CC0000" Font-Size="Larger"></asp:Label>
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
