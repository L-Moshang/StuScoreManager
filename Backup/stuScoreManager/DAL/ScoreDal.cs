using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using stuScoreManager.Model;
using System.Data.SqlClient;

namespace stuScoreManager.DAL
{
    class ScoreDal
    {
        /// <summary>
        /// 根据班级和课程编号查找学生成绩
        /// </summary>
        /// <param name="classNo">班级编号</param>
        /// <param name="courseNo">课程编号</param>
        /// <returns>结果集</returns>
        public DataSet GetList(string classNo, string courseNo)
        {
            string strSql;
            strSql = "select student.Sno,Sname,Grade from score,student where classNo='" + classNo + "'and score.CourseNo='" + courseNo + "'and student.Sno=score.Sno";
            return SQLHelper.Query(strSql);
        }

        /// <summary>
        /// 插入学生成绩信息
        /// </summary>
        /// <param name="model">学生成绩实体类</param>
        /// <returns>是否成功</returns>
        public bool Insert(ScoreInfo model)
        {
            string strSql;
            strSql = "insert into score(Sno,courseNo,Class,Grade) values (@Sno,@courseNo,@ClassNo,@Grade)";
            SqlParameter[] parameters ={
                                          new SqlParameter("@Sno",SqlDbType.VarChar,20),
                                          new SqlParameter("@courseNo",SqlDbType.VarChar,20),
                                          new SqlParameter("@ClassNo",SqlDbType.VarChar,20),
                                          new SqlParameter("@Grade",SqlDbType.VarChar,20)
                                      };
            parameters[0].Value = model.Sno;
            parameters[1].Value = model.CoureNo;
            parameters[2].Value = model.ClassNo;
            parameters[3].Value = model.Grade;
            try
            {
                int i = SQLHelper.ExecuteNonQuery(strSql, parameters);
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
        /// 更新一条记录
        /// </summary>
        /// <param name="model">修改后的成绩信息</param>
        /// <returns>修改是否成功</returns>
        public bool Update(ScoreInfo model)
        {
            int i = 0;
            string strSql;
            strSql = "update score set Grade=@Grade ";
            strSql += "where Sno=@Sno and courseNo=@courseNo and ClassNo=@ClassNo ";
            SqlParameter[] parameters ={
                                          new SqlParameter("@Sno",SqlDbType.VarChar,20),
                                          new SqlParameter("@courseNo",SqlDbType.VarChar,20),
                                          new SqlParameter("@ClassNo",SqlDbType.VarChar,20),
                                          new SqlParameter("@Grade",SqlDbType.VarChar,20)
                                       };
            parameters[0].Value = model.Sno;
            parameters[1].Value = model.CoureNo;
            parameters[2].Value = model.ClassNo;
            parameters[3].Value = model.Grade;
            try
            {
                i = SQLHelper.ExecuteNonQuery(strSql, parameters);
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
