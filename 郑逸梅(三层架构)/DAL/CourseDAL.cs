using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.App_Code;

namespace DAL
{
    public class CourseDAL
    {
        DBOperation db = new DBOperation();//作为公共的实例化
        ProOperation pr = new ProOperation();

        //得到学生已选的课程信息
        public DataTable GetSelect(Model.SC sc)
        {
            string SQL = "select * from SC where sno='" + sc.Sno + "'";
            DataTable dt = db.SQLGetDataTable(SQL);
            return dt;
        }

        //得到学生已选课程的课程名称
        public DataTable GetSelectedCourseName(Model.SC sc)
        {
            string SQL = "select * from Course where cno='" + sc.Cno + "'";
            DataTable dt = db.SQLGetDataTable(SQL);
            return dt;
        }

        //从数据库选数据
        public DataTable GetAllCourse()
        {
            string SQL = "select * from Course";
            DataTable dt = db.SQLGetDataTable(SQL);
            return dt;
        }

        public DataTable GetAllPointedCourse()
        {
            string SQL = "select Cno,Cname,Teacher.Tname from Course,Teacher where Course.Tno=Teacher.Tno";
            DataTable dt = db.SQLGetDataTable(SQL);
            return dt;
        }

        //退选课程
        public void DeleteCourse(Model.SC sc)
        {
            string SQL = "delete from SC where cno='" + sc.Cno + "' and sno='" + sc.Sno + "'";
            db.SQLExecute(SQL);
        }

        //得到对应的课程名的课程号
        public DataTable GetSelectedCourseCno(Model.Course course)
        {
            string SQL = "select * from Course where cname='"+course.Cname+"'";
            DataTable dt = db.SQLGetDataTable(SQL);
            return dt;
        }

        //判断此门课是否被选
        public bool IsSelected(Model.SC sc)
        {
            bool flag = false;
            string SQL = "select * from SC where cno='"+sc.Cno+"' and sno='"+sc.Sno+"'";
            DataTable dt = new DataTable();
            dt = db.SQLGetDataTable(SQL);
            if (dt.Rows.Count > 0)
                flag = true;
            return flag;
        }

        //选中课程
        public void InsertCourse(Model.SC sc)
        {
            string SQL = "insert into sc(sno,cno)values('" + sc.Sno + "','" +sc.Cno+"')";
            db.SQLExecute(SQL);
        }

        //删除所选择的课程
        public void DeletePointedCourse(string id)
        {
            IDataParameter[] parameter = { 
                                                            new SqlParameter("@Cno",SqlDbType.VarChar,50)
                                     };
            parameter[0].Value = id;
            pr.ExcutePro("DeletePointedCourse", parameter);
        }

        //查看课程编号是否存在
        public int IsCnoExist(Model.Course course)
        {
            int count = 0;
            string SQL = "select * from Course where Cno='"+course.Cno+"'";
            DataTable dt = new DataTable();
            dt = db.SQLGetDataTable(SQL);
            if (dt.Rows.Count > 0)
                count = 1;
            return count;
        }

        //课程的添加
        public bool AddCourse(Model.Course course)
        {
            bool flag = false;
            IDataParameter[] parameter = { 
                                                            new SqlParameter("@Cno",SqlDbType.VarChar,50),
                                                            new SqlParameter("@Cname",SqlDbType.VarChar,50),
                                                            new SqlParameter("@Tno",SqlDbType.VarChar,50)
                                     };
            parameter[0].Value = course.Cno;
            parameter[1].Value = course.Cname;
            parameter[2].Value = course.Tno;
            flag = pr.ExecuteProcedure("AddCourse", parameter);
            return flag;
        }

        //显示学生选的课程
        public DataTable ShowCourse(Model.Course course)
        {
            string SQL = "select sc.id,sc.cno,course.cname,sc.sno,student.sclass,grade from sc,course,student where sc.cno=course.cno and student.sno=sc.sno";
            DataTable dt = db.SQLGetDataTable(SQL);
            return dt;     
        }

        //删除所选择的课程
        public void DeleteSC(Model.SC sc)
        {
            IDataParameter[] parameter = { 
                                                            new SqlParameter("@ID",SqlDbType.Int,32)
                                     };
            parameter[0].Value =sc.ID ;
            pr.ExcutePro("DeleteSC", parameter);
        }

        //显示要修改学生成绩的默认信息
        public DataTable ShowDefultSC(Model.SC sc)
        {
            string SQL = "select sc.cno,course.cname,sno,grade from sc,course where sc.cno=course.cno and id='"+sc.ID+"'";
            DataTable dt = db.SQLGetDataTable(SQL);
            return dt;
        }

        //保存已修改过的学生信息
        public bool SaveSC(Model.SC sc)
        {
            bool flag = false;
            IDataParameter[] parameter = { 
                                                            new SqlParameter("@Sno",SqlDbType.VarChar,50),
                                                            new SqlParameter("@Cno",SqlDbType.VarChar,50),
                                                            new SqlParameter("@grade",SqlDbType.Float)
                                     };
            parameter[0].Value = sc.Sno;
            parameter[1].Value = sc.Cno;
            parameter[2].Value = sc.Grade;
            flag = pr.ExecuteProcedure("SaveSC", parameter);
            return flag;
        }

        //根据不同的查询条件返回不同的结果
        public DataTable Search(Model.SC sc, Model.Student stu,string condition)
        {
            if (condition == "按学号查询")
            {
                string SQL = "select sc.id,sc.cno,course.cname,sc.sno,student.sclass,grade from sc,course,student where sc.cno=course.cno and student.sno=sc.sno and sc.sno='"+sc.Sno+"'";
                DataTable dt = db.SQLGetDataTable(SQL);
                return dt;
            }
            else if (condition == "按班级查询")
            {
                string SQL = "select sc.id,sc.cno,course.cname,sc.sno,student.sclass,grade from sc,course,student where sc.cno=course.cno and student.sno=sc.sno and student.sclass= '" + stu.Sclass + "'";
                DataTable dt = db.SQLGetDataTable(SQL);
                return dt;
            }
            else
            {
                string SQL = "select sc.id,sc.cno,course.cname,sc.sno,student.sclass,grade from sc,course,student where sc.cno=course.cno and student.sno=sc.sno";
                DataTable dt = db.SQLGetDataTable(SQL);
                return dt;
            }
        }
    }
}
