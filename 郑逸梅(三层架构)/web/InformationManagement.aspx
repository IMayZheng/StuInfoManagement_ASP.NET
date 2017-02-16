<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InformationManagement.aspx.cs" Inherits="web.InformationManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 800px;
            height: 200px;
        }
        .auto-style2
        {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin:0px auto; width:807px">
    
        <table style="width:100%;">
            <tr>
                <td style="text-align:left">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" Text="用户个人信息管理"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:center">
                    <asp:Label ID="Label1" runat="server" Text="查询："></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>按姓名查询</asp:ListItem>
                        <asp:ListItem>按学号查询</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="txtChaxun" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:Button ID="btnOK" runat="server" Text="查  询" OnClick="btnOK_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:GridView ID="GridView1" runat="server"  style="margin-left: 48px" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCreated="GridView1_RowCreated" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="5" ForeColor="#333333" Width="704px">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="id" Visible="False" />
                            <asp:BoundField DataField="Sno" HeaderText="学号" />
                            <asp:BoundField DataField="Sname" HeaderText="姓名" />
                            <asp:BoundField DataField="Spwd" HeaderText="密码" />
                            <asp:BoundField DataField="Sex" HeaderText="性别" />
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:CommandField ShowDeleteButton="True" />
                        </Columns>
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                        <SortedDescendingHeaderStyle BackColor="#820000" />
                    </asp:GridView>
                </td>
            </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
