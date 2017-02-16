using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class SeeNews : System.Web.UI.Page
    {
        BLL.NewsBLL news = new BLL.NewsBLL();
        Model.News n = new Model.News();

        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"].ToString();
            n.ID = id;
            news.UpdateNewsHit(n);
            DataTable dt = news.ShowNewsDetail(n);
            this.lbTitle.Text = dt.Rows[0]["newstitle"].ToString();
            this.lbContent.Text = dt.Rows[0]["newscontent"].ToString();
            this.lbAuthor.Text = dt.Rows[0]["newsauthor"].ToString();
            this.lbDateTime.Text = dt.Rows[0]["subdate"].ToString();
            this.lbHit.Text = dt.Rows[0]["newshit"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}