<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InformationUpdate.aspx.cs" Inherits="web.InformationUpdate" %>

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
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="用户信息修改"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label2" runat="server" Text="学号："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSno" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label3" runat="server" Text="用户名："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSname" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label4" runat="server" Text="密码："></asp:Label>
                </td>
                <td >
                    <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label5" runat="server" Text="请再次输入密码："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPwdConfirm" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPwd" ControlToValidate="txtPwdConfirm" ErrorMessage="CompareValidator" Font-Bold="True" Font-Size="Small" ForeColor="Red">*密码输入不一致！</asp:CompareValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label6" runat="server" Text="性别："></asp:Label>
                </td>
                <td>
                    <asp:RadioButton ID="rbMale" runat="server" Checked="True" GroupName="Sex" Text="男" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="rbFemale" runat="server" Text="女" GroupName="Sex" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label7" runat="server" Text="班级："></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>计算机一班</asp:ListItem>
                        <asp:ListItem>计算机二班</asp:ListItem>
                        <asp:ListItem>计算机三班</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label8" runat="server" Text="年级："></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlSgrade" runat="server">
                        <asp:ListItem>大一</asp:ListItem>
                        <asp:ListItem>大二</asp:ListItem>
                        <asp:ListItem>大三</asp:ListItem>
                        <asp:ListItem>大四</asp:ListItem>
                        <asp:ListItem>研究生一年级</asp:ListItem>
                        <asp:ListItem>研究生二年级</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label9" runat="server" Text="爱好："></asp:Label>
                </td>
                <td>
                    <asp:CheckBoxList ID="cblHobby" runat="server" RepeatColumns="2" Width="165px">
                        <asp:ListItem>篮球</asp:ListItem>
                        <asp:ListItem>足球</asp:ListItem>
                        <asp:ListItem>羽毛球</asp:ListItem>
                        <asp:ListItem>唱歌</asp:ListItem>
                        <asp:ListItem>跳舞</asp:ListItem>
                        <asp:ListItem>读书</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnSave" runat="server" Font-Bold="True" Font-Size="Medium" Text="保  存" OnClick="btnSave_Click" />
                &nbsp;
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Medium" OnClick="Button1_Click" Text="返  回" />
                </td>
                <td>&nbsp;</td>
            </tr>
            </table>
    <div>
    
    </div>
            </div>
    </form>
</body>
</html>
