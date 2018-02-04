using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using stuScoreManager.Model;
using System.Data.SqlClient;

namespace stuScoreManager.DAL
{
    class Class_CourseDal
    {
        /// <summary>
        /// 根据课程编号查找上课班级
        /// </summary>
        /// <param name="courseNo">上课编号</param>
        /// <returns>结果集</returns>
        public DataSet GetList(string courseNo)
        {
            string strSql;
            strSql = "select classNo,class.Cname from class_course,class where CourseNo='" + courseNo + "' and class.Cno=class_course.classNo";
            return SQLHelper.Query(strSql);
        }

        /// <summary>
        /// 插入班级课程信息
        /// </summary>
        /// <param name="model">班级课程实体类</param>
        /// <returns>是否成功</returns>
        public bool Insert(Class_CourseInfo model)
        {
            string strSql;
            strSql = "insert into class_course(Classno,CourseNo) values (@Classno,@CourseNo)";
            SqlParameter[] pararmeters ={
                                           new SqlParameter("@ClassNo",SqlDbType.VarChar,20),
                                           new SqlParameter("@CourseNo",SqlDbType.VarChar,20)
                                       };
            pararmeters[0].Value = model.ClassNo;
            pararmeters[1].Value = model.CourseNo;
            try
            {
                int i = SQLHelper.ExecuteNonQuery(strSql,pararmeters);
                if (i > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 根据班级和课程编号删除一条记录
        /// </summary>
        /// <param name="classNo">班级编号</param>
        /// <param name="courseNo">课程编号</param>
        /// <returns>是否成功</returns>
        public bool Deleter(string classNo, string courseNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from class_course");
            strSql.Append(" where classNo=@classNo and courseNo=@courseNo");
            SqlParameter[] parameters ={
                                          new SqlParameter("@classNo",SqlDbType.VarChar,20),
                                          new SqlParameter("@courseNo",SqlDbType.VarChar,20)
                                      };
            parameters[0].Value = classNo;
            parameters[1].Value = courseNo;
            try
            {
                int i = SQLHelper.ExecuteNonQuery(strSql.ToString(), parameters);
                if (i > 0)
                    return true;
                else
                    return false;
            }
            catch 
            {
                return false;
            }
        }


    }
}
