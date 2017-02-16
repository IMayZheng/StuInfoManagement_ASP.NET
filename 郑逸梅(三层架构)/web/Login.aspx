<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="web.StuAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1
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
                    <img alt="" class="auto-style1" src="images/head.png" /></td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">用户注册</asp:HyperLink>
&nbsp;
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Login.aspx">用户登录</asp:HyperLink>
                </td>
                <td style="text-align:right">
                    <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#CC33FF" NavigateUrl="~/News.aspx">查看新闻</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">学号：</td>
                <td>
                    <asp:TextBox ID="txtSno" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSno" ErrorMessage="*学号不能为空！" Font-Bold="True" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">密码：</td>
                <td>
                    <asp:TextBox ID="txtSpwd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">验证码：</td>
                <td>
                    <asp:TextBox ID="txtConfirm" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:Image ID="Image1" runat="server" Height="22px" ImageUrl="~/ValidateNum.aspx" Width="58px" />
&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="请输入图片中的验证码！"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="Btn1" runat="server" OnClick="Btn1_Click" Text="登    录" />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Label ID="Label2" runat="server" Text="--------------------------------------------------------------------------------------------------------------------------------------------"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:center" colspan="2" >南京林业大学信息科学技术学院<br />
                版权所有<br />
                联系方式：025-85427464</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
