using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.App_Code
{
    public class DBOperation
    {
        public DBOperation()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    /// <summary>
    /// 执行SQL语句的增删改语句，无返回值
    /// </summary>
    /// <param name="SQL">要执行的SQL语句</param>
    public void SQLExecute(String SQL)
    {
        //获取数据库链接字符串
        string ConnString = "";
        ConnString = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
        //创建数据库链接
        SqlConnection conn = new SqlConnection(ConnString);
        //
        SqlCommand cmd = new SqlCommand(SQL,conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }

    /// <summary>
    /// 有返回值的，执行SQL的增删改
    /// </summary>
    /// <param name="SQL">要执行的SQL语句</param>
    /// <returns>返回受影响的行数</returns>
    public int SQLExecuteReturn(string SQL)
    {
        int count = 0;
        //获取数据库链接字符串
        string ConnString = "";
        ConnString = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
        //创建数据库链接
        SqlConnection conn = new SqlConnection(ConnString);
        //
        SqlCommand cmd = new SqlCommand(SQL, conn);
        conn.Open();
        count=cmd.ExecuteNonQuery();//count用于接收返回值
        conn.Close();
        return count;
    }

    /// <summary>
    /// 执行SQL语句，返回DataTable，里面填充所查询的数据
    /// </summary>
    /// <param name="SQL">要执行的SQL语句</param>
    /// <returns>返回DataTable，里面填充所查询的数据</returns>
    public DataTable SQLGetDataTable(string SQL)
    {
        DataTable dt = new DataTable();
        string ConnString = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
        //创建数据库链接
        SqlConnection conn = new SqlConnection(ConnString);
        //
        SqlDataAdapter adp = new SqlDataAdapter(SQL, conn);//建立数据适配器，用于数据库多行数据的读取
        DataSet ds = new DataSet();//定义数据集ds
        //方法一
        adp.Fill(ds, "items");//通过适配器向数据集填充(其中的items的名字无所谓只要上下统一就行)
        dt = ds.Tables["items"];//将数据集中的数据导入到数据表中
        //
        //方法二(但如果select语句查不出数据，这种方法会出错！)
        //adp.Fill(ds);
        //dt=ds.Tables[0];
        //
        return dt;
    }

    //public void BindGridView(string SQL, GridView dv)
    //{
    //    dv.DataSource = SQLGetDataTable(SQL);//调用另一个函数
    //    dv.DataBind();
    //}

    //public void BindListView(string SQL, ListView lv)
    //{
    //    lv.DataSource = SQLGetDataTable(SQL);
    //    lv.DataBind();
    //}

    ////显示GridView中的数据(可自定义数据表)
    //public void BindGridViewTable(string table, GridView gv)
    //{
    //    string SQL = "select * from "+table;
    //    gv.DataSource = SQLGetDataTable(SQL);
    //    gv.DataBind();
    //}

    ////显示GridView中的数据(可排序)
    //public void BindGridViewTable2(string table, string order,GridView gv)
    //{
    //    string SQL = "select * from " + table+"order by"+order+"desc";
    //    gv.DataSource = SQLGetDataTable(SQL);
    //    gv.DataBind();
    //}

    public void ExcuteProInsertStu(IDataParameter[] parameter)
    {
        string ConnString = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
        SqlConnection conn = new SqlConnection(ConnString);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "InsertIntoStudent";
        cmd.CommandType = CommandType.StoredProcedure;
        foreach (SqlParameter para in parameter)
        {
            cmd.Parameters.Add(para);
        }
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    }
}
