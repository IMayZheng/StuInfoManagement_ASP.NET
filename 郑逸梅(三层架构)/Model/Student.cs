using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        public Student() { }
        private string _Sno;
        private string _Sname;
        private string _Spwd;
        private string _Sex;
        private string _Sclass;
        private string _Sgrade;
        private string _Shobby;

        public string Sno
        {
            set { _Sno = value; }
            get { return _Sno; }
        }
        public string Sname
        {
            set { _Sname = value; }
            get { return _Sname; }
        }
        public string Spwd
        {
            set { _Spwd = value; }
            get { return _Spwd; }
        }
        public string Sex
        {
            set { _Sex = value; }
            get { return _Sex; }
        }
        public string Sclass
        {
            set { _Sclass = value; }
            get { return _Sclass; }
        }
        public string Sgrade
        {
            set { _Sgrade = value; }
            get { return _Sgrade; }
        }
        public string Shobby
        {
            set { _Shobby = value; }
            get { return _Shobby; }
        }
    }
}
