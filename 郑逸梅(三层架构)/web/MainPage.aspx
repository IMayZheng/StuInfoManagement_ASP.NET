<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="web.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2
        {
            width: 116px;
        }
        .auto-style3
        {
            width: 116px;
            height: 25px;
        }
        .auto-style4
        {
            height: 52px;
        }
        .auto-style5
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
                    <img alt="" class="auto-style5" src="images/head.png" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    欢迎您，<asp:Label ID="labelSname" runat="server" Text="Label"></asp:Label>
                    的到来!&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label8" runat="server" Text="导 航 栏" Font-Bold="True" Font-Names="微软雅黑" Font-Size="X-Large" ForeColor="#CC00CC"></asp:Label>
                </td>
                <td rowspan="12">
                    <iframe id="rightPane" name="right" frameborder="0" style="width:1000px; height:400px" src="<%=is_url%>"></iframe></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TreeView ID="TreeView1" runat="server" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" OnTreeNodeCheckChanged="TreeView1_TreeNodeCheckChanged" Font-Names="微软雅黑" Font-Size="Medium" ForeColor="#6600CC" ImageSet="Arrows">
                        <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                        <Nodes>
                            <asp:TreeNode Text="信息管理" Value="信息管理" Target="right"></asp:TreeNode>
                        </Nodes>
                        <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                        <ParentNodeStyle Font-Bold="False" />
                        <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
                    </asp:TreeView>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="border-right-style: double; border-left-style: double; text-align:center" class="auto-style2">
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="#FF3300" NavigateUrl="~/Login.aspx">注 销</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label2" runat="server" Text="--------------------------------------------------------------------------------------------------------------------------------------------"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="auto-style4" style="text-align:center">南京林业大学信息科学技术学院<br />
                版权所有<br />
                联系方式：025-85427464</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
