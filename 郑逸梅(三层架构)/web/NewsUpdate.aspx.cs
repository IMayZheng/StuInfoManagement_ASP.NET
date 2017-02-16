using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class NewsUpdate : System.Web.UI.Page
    {
        //Boolean flag = true;
        BLL.NewsBLL news = new BLL.NewsBLL();
        Model.News n = new Model.News();

        //显示数据的函数
        public void BingGridView(DataTable dt)
        {
            txtTitle.Text = dt.Rows[0]["NewsTitle"].ToString();
            txtContent.Text = dt.Rows[0]["NewsContent"].ToString();
            txtAuthor.Text = dt.Rows[0]["NewsAuthor"].ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack)//解决网页回传数据问题
            {
                //if (flag == true)
                //{
                    string id = Request.QueryString["id"].ToString();
                    n.Title = id;
                    DataTable dt = news.SearchIDNews(n);
                    BingGridView(dt);
                //}
            }

        }

        protected void txtOK_Click(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            string id = Request.QueryString["id"].ToString();

            String title = txtTitle.Text;
            String content = txtContent.Text;
            String author = txtAuthor.Text;

            if (title == null || content == null||author==null)
            {
                Response.Write("<script language='javascript'>alert('不能为空！');</script>");
            }
            else
            {
                n.Title = txtTitle.Text;
                n.Content = txtContent.Text;
                n.Author = txtAuthor.Text;
                bool flag = false;
                flag = news.UpdateNews(n);
                if (flag)
                {
                    Response.Redirect("NewsManagement.aspx");
                }

                n.Title = id;
                DataTable dt = news.SearchIDNews(n);
                BingGridView(dt);
            }
        }
    }
}