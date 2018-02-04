using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stuScoreManager.Model
{
    public class ClassInfo
    {
        string cno;

        /// <summary>
        ///班级编号
        /// </summary>
        public string Cno
        {
            get { return cno; }
            set { cno = value; }
        }

        string cname;

        /// <summary>
        /// 班级名称
        /// </summary>
        public string Cname
        {
            get { return cname; }
            set { cname = value; }
        }

        string cdept;

        /// <summary>
        /// 班级所属系部
        /// </summary>
        public string Cdept
        {
            get { return cdept; }
            set { cdept = value; }
        }
        

    }
}
