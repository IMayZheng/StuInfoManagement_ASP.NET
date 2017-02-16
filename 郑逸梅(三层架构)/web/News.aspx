<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="web.News" EnableEventValidation="false" %>

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
        .auto-style2
        {
            width: 304px;
            height: 58px;
        }
        .auto-style3
        {
            height: 33px;
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
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="新闻栏目"></asp:Label>
                </td>
                <td style="text-align:right" class="auto-style3">
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="微软雅黑" OnClick="Button1_Click" Text="返回主界面" />
                </td>
            </tr>
            <tr>
                <td>
                    <img id="_img" src="" alt="" style="margin-left:100px"/>
                    <script type="text/javascript">
                        var a = ["images/2.png", "images/3.png", "images/4.png", "images/1.png"];
                        var _img = document.getElementById("_img");
                        var i = 0;
                        function change()
                        {
                            if (i >= a.length)
                            {
                                i = 0;
                            }
                            _img.src = a[i];
                            i++;
                        }
                        setInterval("change()", 3000);
                    </script>
                    &nbsp;</td>
                <td style="border-left-style: solid;">
                    <img alt="" class="auto-style2" src="images/QQ图片20160520102958.png" /><asp:ListView ID="ListView1" runat="server">
                        <LayoutTemplate>
                            <table><tr id="itemPlaceholder" runat="server"><td></td><td></td><td></td></tr></table>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr><td>
                                <img src="images/070.gif" /></td><td>
                                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#Eval("id","SeeNews.aspx?id={0}") %>'
                                         runat="server"><%#Eval("newstitle") %></asp:HyperLink>
                                    </td><td><%#Eval("subdate","{0:d}") %></td></tr>
                        </ItemTemplate>
                    </asp:ListView>
                    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" PageSize="5">
                        <Fields>
                            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                        </Fields>
                    </asp:DataPager>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align:center" colspan="2" >
                    <asp:Label ID="Label2" runat="server" Text="----------------------------------------------------------------------------------------------------"></asp:Label>
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
