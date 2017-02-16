using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class InformationManagement : System.Web.UI.Page
    {
        BLL.StuBLL student = new BLL.StuBLL();
        Model.Student stu = new Model.Student();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["sno"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    ShowInformation();
                }
            }
        }

        //根据权限显示信息
        public void ShowInformation()
        {
            if (Session["role"].ToString() != "True")
            {
                this.Label1.Visible = false;
                this.DropDownList1.Visible = false;
                this.txtChaxun.Visible = false;
                this.btnOK.Visible = false;
                this.GridView1.Columns[6].Visible = false;
            }
            DataTable dt = new DataTable();
            string sno = Session["sno"].ToString();
            dt = student.IsAdmin(Session["role"].ToString(), sno);
            this.GridView1.DataSource = dt.DefaultView;
            this.GridView1.DataBind();
        }
        //

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            //……权限
            ShowInformation();
        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
                {
                    ((LinkButton)e.Row.Cells[6].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('您确定删除吗？')");

                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = this.GridView1.SelectedRow.Cells[1].Text;
            Response.Redirect("InformationUpdate.aspx?id=" + ID);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //执行数据库删除
            int id = 0;
            id = int.Parse(this.GridView1.DataKeys[e.RowIndex].Value.ToString());
            student.DeleteInformation(id);
            //刷新页面，显示数据
            ShowInformation();
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //根据不同的查询条件显示不同的查询结果
            if (DropDownList1.SelectedValue == "按学号查询")
            {
                if (txtChaxun.Text == null)
                {
                    ShowInformation();//此处有问题？？？
                }
                else
                {
                    stu.Sno = txtChaxun.Text;
                    this.GridView1.DataSource = student.StudentInfoSearchSno(stu);
                    this.GridView1.DataBind();
                }
            }
            else if (DropDownList1.SelectedValue == "按姓名查询")
            {
                if (txtChaxun.Text == null)
                {
                    ShowInformation();
                }
                else
                {
                    stu.Sname = txtChaxun.Text;
                    this.GridView1.DataSource = student.StudentInfoSearchSname(stu);
                    this.GridView1.DataBind();
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //为了防止下拉列表变化时对应的数据。表数据显示为空
            //txtChaxun.Text = null;
            //ShowInformation();
        }


    }
}