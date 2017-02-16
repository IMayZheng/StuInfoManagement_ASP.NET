<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeeNews.aspx.cs" Inherits="web.SeeNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1
        {}
        .auto-style3
        {
            width: 288px;
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
                <td class="auto-style1" colspan="2">
                    <img alt="" class="auto-style4" src="images/head.png" /></td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align:left" colspan="2">
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="微软雅黑" Font-Size="Small" OnClick="Button1_Click" Text="返回主界面" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align:center" colspan="2">
                    <asp:Label ID="lbTitle" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align:center" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" style="text-align:center">&nbsp;</td>
                <td class="auto-style1" style="text-align:center">
                    <asp:Label ID="lbAuthor" runat="server" ForeColor="#6600FF" Text="Label"></asp:Label>
&nbsp;&nbsp;
                    <asp:Label ID="lbDateTime" runat="server" ForeColor="#6600FF" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align:center" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align:center" colspan="2">
                    <asp:Label ID="lbContent" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align:center" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align:center" colspan="2">
                    <asp:Label ID="Label1" runat="server" Font-Size="Small" ForeColor="Gray" Text="阅读点击率："></asp:Label>
                    <asp:Label ID="lbHit" runat="server" Font-Size="Small" ForeColor="Gray" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" style="text-align:center" colspan="2">
                    <asp:Label ID="Label7" runat="server" Text="-------------------------------------------------------------------------------------------------------------------------------------------"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:center" colspan="2">南京林业大学信息科学技术学院<br />
                版权所有<br />
                联系方式：025-85427464</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
