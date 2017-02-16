using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class NewsManagement : System.Web.UI.Page
    {
        BLL.NewsBLL news = new BLL.NewsBLL();
        Model.News n = new Model.News();

        //查询后分页的问题
        int count = 0;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            ShowInformation();
            if (IsPostBack)
            {
                count ++;
            }
        }
        
        //显示信息的公共函数
        public void ShowInformation()
        {
            Unique(news.SearchNews(n));
            ////LINQ
            //var GetNews =
            //from ne in news.SearchNews(n).AsEnumerable()   
            //select ne;
            //foreach (var item in GetNews)
            //{
            //    if (item["NewsContent"].ToString().Length > 10) //前提是字符串的长度要大于10
            //    {
            //        item.SetField<string>("NewsContent", item["NewsContent"].ToString().Substring(0, 7) + "...");//只显示字符串前7位下标为'7'的字符不包含
            //    }
            //}
            //this.GridView1.DataSource = GetNews.CopyToDataTable<DataRow>();
            //this.GridView1.DataBind();
        }
        //

        //主要用于显示新闻内容的前7个字
        public void Unique(DataTable dt)
        {
            //LINQ
            var GetNews =
            from ne in dt.AsEnumerable()
            select ne;
            //显示新闻内容的前7个字
            foreach (var item in GetNews)
            {
                if (item["NewsContent"].ToString().Length > 10) //前提是字符串的长度要大于10
                {
                    item.SetField<string>("NewsContent", item["NewsContent"].ToString().Substring(0, 7) + "...");//只显示字符串前7位下标为'7'的字符不包含
                }
            }
            //
            this.GridView1.DataSource = GetNews.CopyToDataTable<DataRow>();
            this.GridView1.DataBind();
        }
        //

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
                this.GridView1.PageIndex = e.NewPageIndex;
            //查询后分页问题？？
                //if (count == 0)
                    ShowInformation();
                //else
                //{
                //    string year = ddlYears.SelectedItem.Value.ToString();
                //    string month = ddlMonths.SelectedItem.Value.ToString();

                //    this.GridView1.DataSource = news.SearchPointedNews(month, year);
                //    this.GridView1.DataBind();
                //}
        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
                {
                    ((LinkButton)e.Row.Cells[7].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('您确定删除吗？')");

                }
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //执行数据库删除
            int id = 0;
            id = int.Parse(this.GridView1.DataKeys[e.RowIndex].Value.ToString());
            news.DeleteInformation(id);
            //刷新页面，显示数据
            ShowInformation();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = this.GridView1.SelectedRow.Cells[1].Text;
            Response.Redirect("NewsUpdate.aspx?id=" + ID);
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            string d = this.SearchBox.Value;
            string date = Convert.ToDateTime(d).ToString("yyyy/MM/dd");
            //Response.Write(date);
            Unique(news.SearchPointedNews(date));

            //count = 0; //查询数据后
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            ShowInformation();
            count=count-1; //回复原始数据
           
        }
    }
}