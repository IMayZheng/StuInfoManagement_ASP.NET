using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    public partial class MainPage : System.Web.UI.Page
    {
        public string is_url;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            labelSname.Text = Session["sname"].ToString();
            if (Session["role"].ToString() == "True")
            {
                if (!IsPostBack)
                {
                    TreeNode nodeparent1 = new TreeNode();
                    nodeparent1.Text = "新闻栏目";
                    nodeparent1.Value = "新闻栏目";
                    TreeView1.Nodes.Add(nodeparent1);

                    TreeNode node1 = new TreeNode();
                    node1.Text = "新闻发布";
                    node1.Value = "新闻发布";
                    TreeView1.Nodes[1].ChildNodes.Add(node1);

                    TreeNode node2 = new TreeNode();
                    node2.Text = "新闻管理";
                    node2.Value = "新闻管理";
                    TreeView1.Nodes[1].ChildNodes.Add(node2);

                    TreeNode nodeparent2 = new TreeNode();
                    nodeparent2.Text = "课程管理";
                    nodeparent2.Value = "课程管理";
                    TreeView1.Nodes.Add(nodeparent2);

                    TreeNode nodeparent3 = new TreeNode();
                    nodeparent3.Text = "学生成绩管理";
                    nodeparent3.Value = "学生成绩管理";
                    TreeView1.Nodes.Add(nodeparent3);
                }
            }
            else 
            {
                if (!IsPostBack)
                {
                    TreeNode nodeparent = new TreeNode();
                    nodeparent.Text = "选课系统";
                    nodeparent.Value = "选课系统";
                    TreeView1.Nodes.Add(nodeparent);

                    TreeNode node1 = new TreeNode();
                    node1.Text = "选课";
                    node1.Value = "选课";
                    TreeView1.Nodes[1].ChildNodes.Add(node1);
                }
            }
        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
                is_url = TreeView1.SelectedNode.NavigateUrl;
                if (TreeView1.SelectedNode.Value == "信息管理")
                {
                    is_url = "InformationManagement.aspx";
                }
                else if (TreeView1.SelectedNode.Value == "选课")
                {
                    is_url = "SelectCourse.aspx";
                }
                else if (TreeView1.SelectedNode.Value == "新闻发布")
                {
                    is_url = "ReleaseNews.aspx";
                }
                else if (TreeView1.SelectedNode.Value == "新闻管理")
                {
                    is_url = "NewsManagement.aspx";
                }
                else if (TreeView1.SelectedNode.Value == "课程管理")
                {
                    is_url = "AddCourse.aspx";
                }
                else if (TreeView1.SelectedNode.Value == "学生成绩管理")
                {
                    is_url = "GradeStudent.aspx";
                }
               
        }

        //此处有个问题就是第二次选择则跳不出页面
        protected void TreeView1_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e)
        {
            is_url = TreeView1.SelectedNode.NavigateUrl;
            if (TreeView1.SelectedNode.Value == "信息管理")
            {
                is_url = "InformationManagement.aspx";
            }
            else if (TreeView1.SelectedNode.Value == "选课")
            {
                is_url = "SelectCourse.aspx";
            }
            else if (TreeView1.SelectedNode.Value == "新闻发布")
            {
                is_url = "ReleaseNews.aspx";
            }
            else if (TreeView1.SelectedNode.Value == "新闻管理")
            {
                is_url = "NewsManagement.aspx";
            }
        }
    }
}