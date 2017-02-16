using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Teacher
    {
        public Teacher() { }
        private string _Tno;
        private string _Tname;
        private string _Tpwd;
        private string _Role;

        public string Tno
        {
            set { _Tno = value; }
            get { return _Tno; }
        }
        public string Tname
        {
            set { _Tname = value; }
            get { return _Tname; }
        }
        public string Tpwd
        {
            set { _Tpwd = value; }
            get { return _Tpwd; }
        }
        public string Role
        {
            set { _Role = value; }
            get { return _Role; }
        }
    }
}
