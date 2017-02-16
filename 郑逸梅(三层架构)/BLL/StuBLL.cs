using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public  class StuBLL
    {
       DAL.Student Stu = new DAL.Student();
       public bool Insert(Model.Student st)
       {
           return Stu.Insert(st);
       }

       public bool Search(Model.Student st)
       {
           return Stu.Search(st);
       }

       public DataTable LoginRecord(string password, string number)
       {
           DataTable dt = new DataTable();
           return dt=Stu.LoginRecord(password, number);
       }

       public bool SearchSname(Model.Student st)
       {
           return Stu.SearchSname(st);
       }

       public DataTable IsAdmin(string limit,string number)
       {
           return Stu.IsAdmin(limit,number);
       }

       public void DeleteInformation(int ID)
       {
           Stu.DeleteInformation(ID);
       }
       //
       public DataTable StudentInfoSearchSno(Model.Student st)
       {
           return Stu.StudentInfoSearchSno(st);
       }
       public DataTable StudentInfoSearchSname(Model.Student st)
       {
           return Stu.StudentInfoSearchSname(st);
       }
       //

       public DataTable ShowInformation(Model.Student st)
       {
           return Stu.ShowInformation(st);
       }

       public bool UpdateInformation(Model.Student st)
       {
           return Stu.UpdateInformation(st);
       }
    }
}
