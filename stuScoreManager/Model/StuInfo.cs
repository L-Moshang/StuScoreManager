using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stuScoreManager.Model
{
    public class StuInfo
    {
        string sno;

        /// <summary>
        /// 学号
        /// </summary>
        public string Sno
        {
            get { return sno; }
            set { sno = value; }
        }

        string sname;

        /// <summary>
        /// 姓名
        /// </summary>
        public string Sname
        {
            get { return sname; }
            set { sname = value; }
        }

        string ssex;

        /// <summary>
        /// 性别
        /// </summary>
        public string Ssex
        {
            get { return ssex; }
            set { ssex = value; }
        }

        string cno;

        /// <summary>
        /// 所在班级
        /// </summary>
        public string Cno
        {
            get { return cno; }
            set { cno = value; }
        }
    }
}
