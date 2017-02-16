using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class UpdateSC : System.Web.UI.Page
    {
        BLL.CourseBLL course = new BLL.CourseBLL();
        BLL.TeacherBLL teacher = new BLL.TeacherBLL();
        Model.Course c = new Model.Course();
        Model.Teacher t = new Model.Teacher();
        Model.SC s = new Model.SC();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                s.ID= id;
                DataTable dt=new DataTable();
                dt=course.ShowDefultSC(s);
                txtCno.Text = dt.Rows[0]["cno"].ToString();
                txtCname.Text = dt.Rows[0]["cname"].ToString();
                txtSno.Text = dt.Rows[0]["sno"].ToString();
                txtGrade.Text = dt.Rows[0]["grade"].ToString();

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            bool flag = false;
            s.Sno = txtSno.Text;
            s.Cno = txtCno.Text;
            s.Grade = float.Parse(txtGrade.Text);
            flag=course.SaveSC(s);
            if (flag)
            {
                Response.Write("<script language='javascript'>alert('修改成功！');</script>");
                Response.Write("<script language=javascript>javascript:location.href='GradeStudent.aspx'</script>");
            }
            else
                Response.Write("<script language='javascript'>alert('修改失败！');</script>");
        }
    }
}