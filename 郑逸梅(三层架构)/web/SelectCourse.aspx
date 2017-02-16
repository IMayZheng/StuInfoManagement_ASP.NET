<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectCourse.aspx.cs" Inherits="web.SelectCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin:0px auto; width:807px">
    
        <table style="width:100%;">
            <tr>
                <td colspan="4">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" Text="用户选课及退选"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="微软雅黑" ForeColor="#6666FF" Text="可选课程一览表         "></asp:Label>
                </td>
                <td colspan="2">
                    <br />
                    <br />
                </td>
                <td style="text-align:left">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="微软雅黑" ForeColor="#6666FF" Text="已选课程一览表"></asp:Label>
                </td>
            </tr>
            <tr>
                <td rowspan="2" style="text-align:right">
                    <asp:ListBox ID="ListBox1" runat="server" Width="195px" Height="273px"></asp:ListBox>
                </td>
                <td style="text-align:center" colspan="2">
                    <asp:Button ID="btnToRight" runat="server" Text="选 课&gt;&gt;" Width="62px" OnClick="btnToRight_Click" Height="31px" />
                    </td>
                <td rowspan="2" style="text-align:left">
                    <asp:ListBox ID="ListBox2" runat="server" Height="273px" Width="195px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:center" colspan="2">
                    <asp:Button ID="btnToLeft" runat="server" Text="&lt;&lt;退 选" Width="62px" OnClick="btnToLeft_Click" Height="31px" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td style="text-align:left">
                    <asp:Button ID="btnOK" runat="server" Text="确 定" OnClick="btnOK_Click" Font-Bold="True" Font-Size="Medium" />
                &nbsp;</td>
                <td style="text-align:right">
                    <asp:Button ID="Button1" runat="server" Text="返 回" Font-Bold="True" Font-Size="Medium" OnClick="Button1_Click" />
                </td>
                <td></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
