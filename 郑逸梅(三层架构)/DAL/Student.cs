using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAL.App_Code;

namespace DAL
{
  public class Student
    {
        DBOperation db = new DBOperation();//作为公共的实例化
        ProOperation pr = new ProOperation();

      //数据的插入(注册)
      public bool Insert(Model.Student stu)
      {
          bool flag = false;
          //此处判断学号是否已经被注册……
          string SQL = "select * from student where sno='"+stu.Sno+"'";
          DataTable dt = db.SQLGetDataTable(SQL);
          if (dt.Rows.Count == 0)
          {
              IDataParameter[] parameter = { 
                                                            new SqlParameter("@Sno",SqlDbType.VarChar,50),
                                                            new SqlParameter("@Sname",SqlDbType.VarChar,50),
                                                            new SqlParameter("@Spwd",SqlDbType.VarChar,50),
                                                            new SqlParameter("@Sex",SqlDbType.VarChar,50),
                                                            new SqlParameter("@Sclass",SqlDbType.VarChar,50),
                                                            new SqlParameter("@Sgrade",SqlDbType.VarChar,50),
                                                            new SqlParameter("@Shobby",SqlDbType.VarChar,50)
                                     };
              parameter[0].Value = stu.Sno;
              parameter[1].Value = stu.Sname;
              parameter[2].Value = stu.Spwd;
              parameter[3].Value = stu.Sex;
              parameter[4].Value = stu.Sclass;
              parameter[5].Value = stu.Sgrade;
              parameter[6].Value = stu.Shobby;
              flag = pr.ExecuteProcedure("InsertStudentInformation", parameter);
              return flag;
          }
          else
          {
              return flag;
          }
      }

      //数据的查询(登录)
      public bool Search(Model.Student stu)
      {
          bool flag = false;
          IDataParameter[] parameter = { 
                                                            new SqlParameter("@Spwd",SqlDbType.VarChar,50),
                                                            new SqlParameter("@Sno",SqlDbType.VarChar,50)
                                     };
          parameter[0].Value = stu.Spwd;
          parameter[1].Value = stu.Sno;
          DataSet ds = pr.GetDataSet("Search",parameter);
          if (ds.Tables[0].Rows.Count > 0)
              flag = true;
          return flag;
      }

      //登录时数据的返回
      public DataTable LoginRecord(string spwd,string sno)
      {
          string SQL = "select * from student where spwd='" + spwd + "' and sno='" + sno + "'";
          DataTable dt = new DataTable();
          return dt = db.SQLGetDataTable(SQL);
      }

      //数据的查询(看用户是否存在)
      public bool SearchSname(Model.Student stu)
      {
          bool flag = false;
          IDataParameter[] parameter = { 
                                                            new SqlParameter("@Sno",SqlDbType.VarChar,50)
                                     };
          parameter[0].Value = stu.Sno;
          DataSet ds = pr.GetDataSet("SearchSname", parameter);
          if (ds.Tables[0].Rows.Count > 0)
              flag = true;
          return flag;
      }

      //判断是否为管理员
      public DataTable IsAdmin(string role,string sno)
      {
          DataTable dt = new DataTable();
          if (role != "True")
          {
              String SQL = "select id,sno,sname,spwd,sex from student where sno='" + sno+ "'";
              return  dt = db.SQLGetDataTable(SQL);
          }
          else
          {
              String SQL = "select id,sno,sname,spwd,sex from student order by sno asc ";
              return dt = db.SQLGetDataTable(SQL);
          }
      }

      //数据库里学生信息的删除
      public void DeleteInformation(int id)
      {
          IDataParameter[] parameter = { 
                                                            new SqlParameter("@ID",SqlDbType.Int,32)
                                     };
          parameter[0].Value = id;
          pr.ExcutePro("DeleteInfomation", parameter);
      }

      //学生信息管理界面数据查询--学号
      public DataTable StudentInfoSearchSno(Model.Student stu)
      {
          string SQL = "select id,sno,sname,spwd,sex from student where sno='" + stu.Sno + "'";
          DataTable dt=db.SQLGetDataTable(SQL);
          return dt;
      }
      //学生信息管理界面数据查询--姓名
     public DataTable StudentInfoSearchSname(Model.Student stu)
      {
          string SQL = "select id,sno,sname,spwd,sex from student where sname='" + stu.Sname + "'";
          DataTable dt=db.SQLGetDataTable(SQL);
          return dt;
      }
      //

      //用户修改界面数据的查询
     public DataTable ShowInformation(Model.Student stu)
     {
         string SQL = "select * from student where sno='" + stu.Sno + "'";
         DataTable dt = db.SQLGetDataTable(SQL);
         return dt;
     }

      //用户修改界面的数据更新
     public bool UpdateInformation(Model.Student stu)
     {
         bool flag = false;
         IDataParameter[] parameter = { 
                                                            new SqlParameter("@Sno",SqlDbType.VarChar,50),
                                                            new SqlParameter("@Sname",SqlDbType.VarChar,50),
                                                            new SqlParameter("@Spwd",SqlDbType.VarChar,50),
                                                            new SqlParameter("@Sex",SqlDbType.VarChar,50),
                                                            new SqlParameter("@Sclass",SqlDbType.VarChar,50),
                                                            new SqlParameter("@Sgrade",SqlDbType.VarChar,50),
                                                            new SqlParameter("@Shobby",SqlDbType.VarChar,50)
                                     };
         parameter[0].Value = stu.Sno;
         parameter[1].Value = stu.Sname;
         parameter[2].Value = stu.Spwd;
         parameter[3].Value = stu.Sex;
         parameter[4].Value = stu.Sclass;
         parameter[5].Value = stu.Sgrade;
         parameter[6].Value = stu.Shobby;
         flag = pr.ExecuteProcedure("UpdateInfomation",parameter);
         return flag;
     }

    }
}
