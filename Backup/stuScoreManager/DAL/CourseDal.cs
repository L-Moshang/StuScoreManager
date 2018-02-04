using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using stuScoreManager.Model;
using System.Data.SqlClient;

namespace stuScoreManager.DAL
{
    class CourseDal
    {
        /// <summary>
        /// 查询所有课程，返回结果集
        /// </summary>
        public DataSet GetList()
        {
            string strSql;
            strSql = "select Cno,Cname,Cteacher from course ";
            return SQLHelper.Query(strSql);
        }

        /// <summary>
        /// 插入课程信息
        /// </summary>
        /// <param name="model">课程实体类</param>
        /// <returns>是否成功</returns>
        public bool Insert(CourseInfo model)
        {
            string strSql;
            strSql = "insert into course(Cno,Cname,Cteacher) values (@Cno,@Cname,@Cteacher)";
            SqlParameter[] parameters ={
                                          new SqlParameter("@Cno",SqlDbType.VarChar,20),
                                          new SqlParameter("@Cname",SqlDbType.VarChar,20),
                                          new SqlParameter("@Cteacher",SqlDbType.VarChar,20)
                                      };
            parameters[0].Value = model.Cno;
            parameters[1].Value = model.Cname;
            parameters[2].Value = model.Cteacher;
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
        /// <param name="model">新的班级实体</param>
        /// <param name="oldCno">旧的班级编号</param>
        /// <returns>是否成功</returns>
        public bool Update(CourseInfo model, string oldCno)
        {
            int i = 0;
            string strSql;
            strSql = "update course set Cno=@Cno,Cname=@Cname,Cteacher=@Cteacher";
            strSql += " where Cno=@oldCno";
            SqlParameter[] parameters ={
                                         new SqlParameter("@Cno",SqlDbType.VarChar,20),
                                         new SqlParameter("@Cname",SqlDbType.VarChar,20),
                                         new SqlParameter("@Cteacher",SqlDbType.VarChar,20),
                                         new SqlParameter("@oldCno",SqlDbType.VarChar,20)
                                     };
            parameters[0].Value = model.Cno;
            parameters[1].Value = model.Cname;
            parameters[2].Value = model.Cteacher;
            parameters[3].Value = oldCno;
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

        /// <summary>
        /// 根据课程编号删除一条记录
        /// </summary>
        /// <param name="cno">课程编号</param>
        /// <returns>是否成功</returns>
        public bool Delete(String cno)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from course ");
            strSql.Append("where Cno=@Cno");
            SqlParameter[] parmeters ={
                                         new SqlParameter("@Cno",SqlDbType.VarChar,20)
                                     };
            parmeters[0].Value = cno;
            try
            {
                int i = SQLHelper.ExecuteNonQuery(strSql.ToString(), parmeters);
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
