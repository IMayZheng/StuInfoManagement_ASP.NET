using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class News : System.Web.UI.Page
    {
        BLL.NewsBLL news = new BLL.NewsBLL();

        protected void Page_PreRender(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)
            //{
                ListView1.DataSource = news.ShowNewsTitle();
                ListView1.DataBind();
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}