using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SC
    {
        public SC() { }
        private int id;
        private string sno;
        private string cno;
        private float grade;

        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public string Cno
        {
            set { cno = value; }
            get { return cno; }
        }
        public string Sno
        {
            set { sno = value; }
            get { return sno; }
        }
        public float Grade
        {
            set { grade = value; }
            get { return grade; }
        }
    }
}
