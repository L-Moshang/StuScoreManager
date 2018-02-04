using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stuScoreManager.Model
{
    class CourseInfo
    {
        string cno;

        public string Cno
        {
            get { return cno; }
            set { cno = value; }
        }

        string cname;

        public string Cname
        {
            get { return cname; }
            set { cname = value; }
        }

        string cteacher;

        public string Cteacher
        {
            get { return cteacher; }
            set { cteacher = value; }
        }
    }
}
