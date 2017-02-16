using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TeacherBLL
    {
        TeacherDAL teacher = new TeacherDAL();

        public string SelectTno(Model.Teacher t)
        {
            return teacher.SelectTno(t);
        }
    }
}
