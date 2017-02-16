<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCourse.aspx.cs" Inherits="web.AddCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin:0px auto; width:807px">
    
        <table style="width:100%;">
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="微软雅黑" Font-Size="Medium" Text="已有课程详情"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="799px" AllowPaging="True" DataKeyNames="Cno" OnRowCreated="GridView1_RowCreated" PageSize="4" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDeleting="GridView1_RowDeleting">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Cno" HeaderText="课程编号" />
                            <asp:BoundField DataField="Cname" HeaderText="课程名称" />
                            <asp:BoundField DataField="Tname" HeaderText="任课老师" />
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
            <tr>
                <td colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="微软雅黑" Font-Size="Medium" Text="课程添加"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label2" runat="server" Text="课程编号："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCno" runat="server"></asp:TextBox>
                &nbsp;<asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="微软雅黑" Font-Size="Small" ForeColor="Red" Text="*该课程编号已存在!" Visible="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label3" runat="server" Text="课程名称："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCname" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right" class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="任课老师："></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:DropDownList ID="ddlTeacher" runat="server" Width="145px" Height="28px">
                        <asp:ListItem>赵老师</asp:ListItem>
                        <asp:ListItem>钱老师</asp:ListItem>
                        <asp:ListItem>孙老师</asp:ListItem>
                        <asp:ListItem>李老师</asp:ListItem>
                        <asp:ListItem>周老师</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td style="text-align:right">
                    &nbsp;</td>
                <td style="text-align:right">
                    <asp:Button ID="btnOK" runat="server" Font-Names="微软雅黑" Text="确认添加" OnClick="btnOK_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
