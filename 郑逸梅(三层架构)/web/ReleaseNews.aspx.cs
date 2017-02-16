using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class ReleaseNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtOK_Click(object sender, EventArgs e)
        {
            BLL.NewsBLL n = new BLL.NewsBLL();
            Model.News news = new Model.News();

            news.Title = txtTitle.Text;
            news.Content = txtContent.Text;
            news.Author = txtAuthor.Text;

            bool flag = n.InsertNews(news);
            if (txtTitle.Text == ""||txtContent.Text==""||txtAuthor.Text=="")
            {
                Response.Write("<script language='javascript'>alert('请将内容填写完整！');</script>");
            }
            else
            {
                if (flag)
                    Response.Write("<script language='javascript'>alert('新闻发布成功！');</script>");
                else
                    Response.Write("<script language='javascript'>alert('新闻发布失败！');</script>");
            }
        }
    }
}