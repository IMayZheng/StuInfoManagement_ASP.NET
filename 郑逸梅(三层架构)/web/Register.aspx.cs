using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Model.Student stu = new Model.Student();
            stu.Sno = txtRSno.Text;
            stu.Sname = txtRSname.Text;
            stu.Spwd = txtRSpwd.Text;
            if (rdbMale.Checked == true)
            {
                stu.Sex = "男";
            }
            else {
                stu.Sex = "女";
            }
            stu.Sclass = ddlSclass.SelectedItem.Text;
            stu.Sgrade = ddlSgrade.SelectedItem.Text;
            string Hobby = "";
            for (int i = 0; i < this.cblHobby.Items.Count; i++)
            {
                if (this.cblHobby.Items[i].Selected == true)
                {
                    Hobby = Hobby + this.cblHobby.Items[i].Text;
                }
            }
            stu.Shobby = Hobby;

            BLL.StuBLL student = new BLL.StuBLL();
            bool flag = false;
            flag = student.Insert(stu);

            if (flag)
            {
                //Response.Write("<script language='javascript'>alert('登录成功！');</script>");
                Response.Redirect("Login.aspx");
            }
            else Response.Write("<script language='javascript'>alert('注册失败！此用户已存在！');</script>");
        }
    }
}