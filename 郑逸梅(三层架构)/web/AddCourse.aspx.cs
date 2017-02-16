using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class AddCourse : System.Web.UI.Page
    {
        BLL.CourseBLL course = new BLL.CourseBLL();
        BLL.TeacherBLL teacher = new BLL.TeacherBLL();
        Model.Course c = new Model.Course();
        Model.Teacher t = new Model.Teacher();

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
            Unique(course.GetAllPointedCourse());
        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
                {
                    ((LinkButton)e.Row.Cells[3].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('您确定删除吗？')");

                }
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            Unique(course.GetAllPointedCourse());
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //执行数据库删除
           string id = this.GridView1.DataKeys[e.RowIndex].Value.ToString();
            course.DeletePointedCourse(id);
            //刷新页面，显示数据
            Unique(course.GetAllPointedCourse());
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            c.Cno = txtCno.Text;
            int count = course.IsCnoExist(c);
            if (count > 0)
            {
                Response.Write("<script language='javascript'>alert('课程号已存在！');</script>");
                txtCno.Text = null;
            }
            else
            {
                c.Cname = txtCname.Text;
                t.Tname = ddlTeacher.SelectedItem.Text;
                c.Tno = teacher.SelectTno(t);
                bool flag = course.AddCourse(c);
                if (flag)
                    Response.Write("<script language='javascript'>alert('课程添加成功！');</script>");
                else
                    Response.Write("<script language='javascript'>alert('课程添加失败！');</script>");
            }
        }
    }
}