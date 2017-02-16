﻿<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="ReleaseNews.aspx.cs" Inherits="web.ReleaseNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            height: 20px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
    <div style="margin:0px auto; width:807px">
    
        <table style="width:100%;" border="1">
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="新闻发布"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label2" runat="server" Text="新闻标题："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTitle" runat="server" Width="427px" BorderStyle="Solid"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label3" runat="server" Text="新闻内容："></asp:Label>
                </td>
                <td>
                     <script src="js/nicEdit.js" type="text/javascript"></script>
                                <script type="text/javascript">
                                    bkLib.onDomLoaded(function () {
                                        new nicEditor({ fullPanel: true }).panelInstance('txtContent');
                                    });</script>
                    <asp:TextBox ID="txtContent" runat="server" Height="376px" TextMode="MultiLine" Width="427px" BorderStyle="Solid"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    <asp:Label ID="Label4" runat="server" Text="新闻发布者："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAuthor" runat="server" BorderStyle="Solid"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="txtOK" runat="server" Font-Bold="True" Font-Size="Medium" Text="发  布" OnClick="txtOK_Click" />
                </td>
            </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
