﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class SelectCourse : System.Web.UI.Page
    {
        BLL.CourseBLL course = new BLL.CourseBLL();
        Model.Course c = new Model.Course();
        Model.SC sc = new Model.SC();

        //得到学生已选的课程
        public void GetSelectedCourse()
        {
            sc.Sno = Session["Sno"].ToString();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            dt1=course.GetSelect(sc);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                sc.Cno = dt1.Rows[i]["Cno"].ToString();//先获取SC表中学生已选课程的课程号
                dt2 = course.GetSelectedCourseName(sc);//再通过外键—课程号查找Course表里的课程名
                ListBox2.Items.Add(dt2.Rows[0]["Cname"].ToString());
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetSelectedCourse();
                DataTable dt = new DataTable();
                dt = course.GetAllCourse();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    bool flag = true;
                    for (int j = 0; j < ListBox2.Items.Count; j++)
                    {
                        if (dt.Rows[i]["Cname"].ToString() == ListBox2.Items[j].ToString())
                            flag = false;
                    }
                    if (flag == true)
                        ListBox1.Items.Add(dt.Rows[i]["Cname"].ToString());
                }
            }
        }

        protected void btnToRight_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                if (ListBox1.Items[i].Selected == true)
                {
                    ListBox2.Items.Add(ListBox1.Items[i].Text);
                    ListBox1.Items.Remove(ListBox1.Items[i]);
                }
            }
        }

        protected void btnToLeft_Click(object sender, EventArgs e)
        {
            c.Cname = ListBox2.SelectedItem.Text;
            DataTable dt = new DataTable();
            dt = course.GetSelectedCourseCno(c);
            sc.Cno = dt.Rows[0]["Cno"].ToString();
            sc.Sno = Session["Sno"].ToString();
            course.DeleteCourse(sc);
            Response.Write("<script language='javascript'>alert('退选成功！');</script>");
            for (int i = 0; i < ListBox2.Items.Count; i++)
            {
                if (ListBox2.Items[i].Selected == true)
                {
                    ListBox1.Items.Add(ListBox2.Items[i].Text);
                    ListBox2.Items.Remove(ListBox2.Items[i]);
                }
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for (int i = 0; i < ListBox2.Items.Count; i++)
            {
                c.Cname = ListBox2.Items[i].ToString();
                DataTable dt = new DataTable();
                dt = course.GetSelectedCourseCno(c);
                sc.Cno = dt.Rows[0]["Cno"].ToString();
                sc.Sno = Session["Sno"].ToString();
                flag = course.IsSelected(sc);
                if (flag != true)
                {
                    course.InsertCourse(sc);
                }
                Response.Write("<script language='javascript'>alert('选课成功！');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("InformationManagement.aspx");
        }
    }
}