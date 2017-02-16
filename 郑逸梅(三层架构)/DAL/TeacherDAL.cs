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
    public class TeacherDAL
    {
        ProOperation pr = new ProOperation();

        //查找教师编号
        public string SelectTno(Model.Teacher teacher)
        {
            string tno = null;
            IDataParameter[] parameter = { 
                                                            new SqlParameter("@Tname",SqlDbType.VarChar,50)
                                     };
            parameter[0].Value = teacher.Tname;
            DataSet ds = pr.GetDataSet("SelectTno", parameter);
            if (ds.Tables[0].Rows.Count > 0)
                tno = ds.Tables[0].Rows[0]["Tno"].ToString();
            return tno;
        }
    }
}
