<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsManagement.aspx.cs" Inherits="web.NewsManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style2
        {
        }
        .auto-style3
        {
            height: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin:0px auto; width:807px">
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="新闻信息管理"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:center" class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="查询："></asp:Label>
                    &nbsp;<script src="My97DatePicker/WdatePicker.js" type="text/javascript"></script>
                    <input  type="text" onclick="WdatePicker()" id="SearchBox" runat="server"/>
                    &nbsp;
                    <asp:Button ID="btnOK" runat="server" Text="查  询" OnClick="btnOK_Click" />
                &nbsp;
                    <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="返  回" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:GridView ID="GridView1" runat="server"  style="margin-left: 0px" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCreated="GridView1_RowCreated" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="5" Width="802px" ForeColor="#333333">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="id" Visible="False" />
                            <asp:BoundField DataField="NewsTitle" HeaderText="新闻标题" />
                            <asp:BoundField DataField="NewsContent" HeaderText="新闻内容" />
                            <asp:BoundField DataField="NewsHit" HeaderText="新闻点击率" />
                            <asp:BoundField DataField="NewsAuthor" HeaderText="新闻作者" />
                            <asp:BoundField DataField="Subdate" HeaderText="新闻发布时间" />
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
