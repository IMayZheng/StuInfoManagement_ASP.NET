using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class InformationUpdate : System.Web.UI.Page
    {
        //string sno1 = null;
        Boolean flag = true;
        BLL.StuBLL student = new BLL.StuBLL();//对业务逻辑层的实例化
        Model.Student stu = new Model.Student();

        //显示数据的函数
        public void BingGridView(DataTable dt)
        {
            txtSno.Text = dt.Rows[0]["sno"].ToString();
            txtSname.Text = dt.Rows[0]["sname"].ToString();
            txtPwd.TextMode = TextBoxMode.SingleLine;
            txtPwd.Text = dt.Rows[0]["spwd"].ToString();

            string sex = dt.Rows[0]["sex"].ToString();
            if (sex == "女")
            {
                rbFemale.Checked = true;
            }
            else if (sex == "男")
            {
                rbMale.Checked = true;
            }
            string sclass = dt.Rows[0]["sclass"].ToString();
            DropDownList1.Text = sclass;
            string sgrade = dt.Rows[0]["sgrade"].ToString();
            ddlSgrade.Text = sgrade;
        }

        //页面加载
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack)//解决网页回传数据问题
            {
                if (flag == true)
                {
                    string id = Request.QueryString["id"].ToString();
                    stu.Sno = id;
                    DataTable dt = student.ShowInformation(stu);
                    BingGridView(dt);
                }
                else if (flag == false)
                {
                    string sno = txtSno.Text;
                    stu.Sno = sno;
                    DataTable dt = student.ShowInformation(stu);
                    BingGridView(dt);
                }
            }
        }

        //单击"保存"按钮的事件
        protected void btnSave_Click(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            string id = Request.QueryString["id"].ToString();

            //if (IsPostBack)
            //{
            flag = false;
            String name = txtSname.Text;
            String password = txtPwd.Text;
            String sex = null;
            if (rbFemale.Checked == true)
            {
                sex = "女";
            }
            else if (rbMale.Checked == true)
            {
                sex = "男";
            }
            string sclass = DropDownList1.SelectedItem.Text;
            string sgrade = ddlSgrade.SelectedItem.Text;
            string Hobby = "";
            for (int i = 0; i < this.cblHobby.Items.Count; i++)
            {
                if (this.cblHobby.Items[i].Selected == true)
                {
                    Hobby = Hobby + this.cblHobby.Items[i].Text;
                }
            }

            if (name == null || password == null)
            {
                Response.Write("<script language='javascript'>alert('用户名或密码不能为空！');</script>");
            }
            else
            {
                bool flagen = false;
                stu.Sno = id;
                stu.Sname = name;
                stu.Spwd = password;
                stu.Sex = sex;
                stu.Sclass = sclass;
                stu.Sgrade = sgrade;
                stu.Shobby = Hobby;
                flagen = student.UpdateInformation(stu);
                if (flagen)
                {
                    Response.Redirect("InformationManagement.aspx");
                }

                stu.Sno = id;
                DataTable dt = student.ShowInformation(stu);
                BingGridView(dt);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("InformationManagement.aspx");
        }


    }
}