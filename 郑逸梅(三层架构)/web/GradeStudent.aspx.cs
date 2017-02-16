using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class GradeStudent : System.Web.UI.Page
    {
        BLL.CourseBLL course = new BLL.CourseBLL();
        BLL.TeacherBLL teacher = new BLL.TeacherBLL();
        Model.Course c = new Model.Course();
        Model.Teacher t = new Model.Teacher();
        Model.SC s = new Model.SC();
        Model.Student stu = new Model.Student();

        public void Unique(DataTable dt)
        {
            //LINQ
            var GetNews =
            from ne in dt.AsEnumerable()
            select ne;

            this.GridView1.DataSource = GetNews.CopyToDataTable<DataRow>();
            this.GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Unique(course.ShowCourse(c));
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = this.GridView1.SelectedRow.Cells[0].Text;
            Response.Redirect("UpdateSC.aspx?id=" + ID);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //执行数据库删除
            s.ID = int.Parse(this.GridView1.DataKeys[e.RowIndex].Value.ToString());
            course.DeleteSC(s);
            //刷新页面，显示数据
            Unique(course.ShowCourse(c));
        }

        protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            Unique(course.ShowCourse(c));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string searchCondition = null;
            searchCondition = DropDownList1.SelectedItem.Text;
            s.Sno = txtSearch.Text;
            stu.Sclass = txtSearch.Text;
            Unique(course.Search(s, stu, searchCondition));
        }

        
    }
}