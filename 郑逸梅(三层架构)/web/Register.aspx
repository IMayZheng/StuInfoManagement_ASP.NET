<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="web.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2
        {
            height: 14px;
        }
        .auto-style3
        {
            height: 28px;
        }
        .auto-style4
        {
            width: 1120px;
            height: 227px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:0px auto; width:1125px">
        <table style="width:100%;">
            <tr>
                <td colspan="2">
                    <img alt="" class="auto-style4" src="images/head.png" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">用户注册</asp:HyperLink>
&nbsp;
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Login.aspx">用户登录</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="用户注册" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label2" runat="server" Text="学号:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRSno" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRSno" ErrorMessage="*学号不能为空！" Font-Bold="True" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label3" runat="server" Text="姓名:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRSname" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtRSname" ErrorMessage="*姓名不能为空！" Font-Bold="True" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label4" runat="server" Text="密码:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRSpwd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label8" runat="server" Text="确认密码:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRSpwdConfirm" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtRSpwd" ControlToValidate="txtRSpwdConfirm" ErrorMessage="*密码输入不一致!" Font-Bold="True" Font-Size="Small" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label5" runat="server" Text="性别:"></asp:Label>
                </td>
                <td>
                    <asp:RadioButton ID="rdbMale" runat="server" Checked="True" Text="男" GroupName="Sex" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="rdbFemale" runat="server" Text="女" GroupName="Sex" />
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label6" runat="server" Text="班级:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlSclass" runat="server">
                        <asp:ListItem>计算机一班</asp:ListItem>
                        <asp:ListItem>计算机二班</asp:ListItem>
                        <asp:ListItem>计算机三班</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="text-align:right" class="auto-style3">
                    <asp:Label ID="Label9" runat="server" Text="年级:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlSgrade" runat="server">
                        <asp:ListItem>大一年级</asp:ListItem>
                        <asp:ListItem>大二年级</asp:ListItem>
                        <asp:ListItem>大三年级</asp:ListItem>
                        <asp:ListItem>大四年级</asp:ListItem>
                        <asp:ListItem>研究生一年级</asp:ListItem>
                        <asp:ListItem>研究生二年级</asp:ListItem>
                        <asp:ListItem>研究生三年级</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label10" runat="server" Text="爱好:"></asp:Label>
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
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:Button ID="btnRegister" runat="server" Text="注   册" OnClick="btnRegister_Click" Font-Bold="True" Font-Size="Medium" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Label ID="Label7" runat="server" Text="--------------------------------------------------------------------------------------------------------------------------------------------"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:center" colspan="2" >南京林业大学信息科学技术学院<br />
                版权所有<br />
                联系方式：025-85427464</td>
            </tr>
        </table>
    <div>
    
    </div>
            </div>
    </form>
</body>
</html>
