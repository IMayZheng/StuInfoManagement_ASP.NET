using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class StuAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            Model.Student stu = new Model.Student();
            stu.Sno = txtSno.Text;
            stu.Spwd = txtSpwd.Text;

            BLL.StuBLL student = new BLL.StuBLL();//业务逻辑层的实例化
            bool flag1 = false;
            bool flag2 = false;
            flag1 = student.Search(stu);//判断该用户是否用户名与密码输入正确
            flag2 = student.SearchSname(stu);//是否存在该用户，存在则密码是否输入正确

            string num = this.txtConfirm.Text.Trim();//验证码
            if (Session["ValidateNum"].ToString() == num.ToUpper())
            {
                if (flag1)
                {
                    DataTable dt = new DataTable();
                    dt = student.LoginRecord(stu.Spwd, stu.Sno);
                    if (dt.Rows.Count > 0)
                    {
                        Session["sname"] = dt.Rows[0]["sname"].ToString();
                        Session["sno"] = dt.Rows[0]["sno"].ToString();
                        Session["role"] = dt.Rows[0]["role"].ToString();
                        Response.Redirect("MainPage.aspx");
                     }
                }
                else
                {
                    if (flag2 != true)
                    {
                        Response.Write("<script language='javascript'>alert('该用户名不存在！');</script>");
                        txtSno.Text = "";
                        txtSpwd.Text = "";
                    }
                    else 
                    {
                        Response.Write("<script language='javascript'>alert('密码输入错误！');</script>");
                        txtSpwd.Text = "";
                    }
                }
            }
            else 
            {
                Response.Write("<script language='javascript'>alert('验证码输入错误，请重新输入！');</script>");
                txtConfirm.Text = "";
            }
        }
    }
}