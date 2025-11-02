<%@ Page Title="" Language="C#" MasterPageFile="~/SiteDriver.Master" AutoEventWireup="true" CodeBehind="process-transaction.aspx.cs" Inherits="SQU_Transportation.process_transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="grdTranscations" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="grdTranscations_SelectedIndexChanged" Width="1000px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <br />
    <br />
    <table class="w-100">
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 180px">Reference No</td>
            <td>
                <asp:TextBox ID="txtReference" runat="server" OnTextChanged="txtReference_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 180px">StudentID</td>
            <td>
                <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 180px">From</td>
            <td>
                <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 180px">Destination</td>
            <td>
                <asp:TextBox ID="txtDestination" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 180px">Departure Time</td>
            <td>
                <asp:TextBox ID="txtDepartureTime" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 180px">Return Time</td>
            <td>
                <asp:TextBox ID="txtReturnTime" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 180px">Date</td>
            <td>
                <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 180px">Time</td>
            <td>
                <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 180px">Approved</td>
            <td>
                <asp:TextBox ID="txtApproved" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Content>
