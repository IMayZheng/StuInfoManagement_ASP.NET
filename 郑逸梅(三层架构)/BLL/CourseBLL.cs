using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CourseBLL
    {
        DAL.CourseDAL course = new DAL.CourseDAL();

        public DataTable GetSelect(Model.SC sc)
        {
            return course.GetSelect(sc);
        }

        public DataTable GetSelectedCourseName(Model.SC sc)
        {
            return course.GetSelectedCourseName(sc);
        }

        public DataTable GetAllCourse()
        {
            return course.GetAllCourse();
        }

        public DataTable GetAllPointedCourse()
        {
            return course.GetAllPointedCourse();
        }

        public void DeleteCourse(Model.SC sc)
        {
            course.DeleteCourse(sc);
        }

        public DataTable GetSelectedCourseCno(Model.Course c)
        {
            return course.GetSelectedCourseCno(c);
        }

        public bool IsSelected(Model.SC sc)
        {
            return course.IsSelected(sc);
        }

        public void InsertCourse(Model.SC sc)
        {
            course.InsertCourse(sc);
        }

        public void DeletePointedCourse(string id)
        {
            course.DeletePointedCourse(id);
        }
        public bool AddCourse(Model.Course c)
        {
            return course.AddCourse(c);
        }
        public int IsCnoExist(Model.Course c)
        {
            return course.IsCnoExist(c);
        }
        public DataTable ShowCourse(Model.Course c)
        {
            return course.ShowCourse(c);
        }
        public void DeleteSC(Model.SC sc)
        {
            course.DeleteSC(sc);
        }
        public DataTable ShowDefultSC(Model.SC s)
        {
            return course.ShowDefultSC(s);
        }
        public bool SaveSC(Model.SC sc)
        {
            return course.SaveSC(sc);
        }
        public DataTable Search(Model.SC sc, Model.Student stu, string condition)
        {
            return course.Search(sc,stu,condition);
        }
    }
}
