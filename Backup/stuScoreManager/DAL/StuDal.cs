using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using stuScoreManager.Model;
using System.Data.SqlClient;

namespace stuScoreManager.DAL
{
    class StuDal
    {
        /// <summary>
        /// 根据班级编号查询该班所有学生，返回结果集
        /// </summary>
        /// <param name="cno">班级编号</param>
        /// <returns>班级所有学生信息</returns>
        public DataSet GetListByCno(string cno)
        {
            string strSql;
            strSql = "select Sno,Sname,Ssex from student where Cno='" + cno + "'";
            return SQLHelper.Query(strSql);
        }

        /// <summary>
        /// 插入学生信息
        /// </summary>
        /// <param name="model">学生实力类</param>
        /// <returns>是否成功</returns>
        public bool Insert(StuInfo model)
        {
            string strSql;
            strSql = "insert into student (Sno,Sname,Ssex,Cno) values (@Sno,@Sname,@Ssex,@Cno) ";
            SqlParameter[] parameters ={
                                          new SqlParameter("@Sno",SqlDbType.VarChar,20),
                                          new SqlParameter("@Sname",SqlDbType.VarChar,20),
                                          new SqlParameter("@Ssex",SqlDbType.VarChar,20),
                                          new SqlParameter("@Cno",SqlDbType.VarChar,20)
                                      };
            parameters[0].Value = model.Sno;
            parameters[1].Value = model.Sname;
            parameters[2].Value = model.Ssex;
            parameters[3].Value = model.Cno;
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
        /// <param name="model">新的学生实体类</param>
        /// <param name="oldSno">旧的学生编号</param>
        /// <returns>是否成功</returns>
        public bool Update(StuInfo model, string oldSno)
        {
            int i = 0;
            string strSql;
            strSql = "update student set Sno=@Sno,Sname=@Sname,Ssex=@Ssex";
            strSql += " where Sno=@oldSno and Cno=@Cno";
            SqlParameter[] parameters ={
                                          new SqlParameter("@Sno",SqlDbType.VarChar,20),
                                          new SqlParameter("@Sname",SqlDbType.VarChar,20),
                                          new SqlParameter("@Ssex",SqlDbType.VarChar,20),
                                          new SqlParameter("@oldSno",SqlDbType.VarChar,20),
                                          new SqlParameter("@Cno",SqlDbType.VarChar,20)
                                      };
            parameters[0].Value = model.Sno;
            parameters[1].Value = model.Sname;
            parameters[2].Value = model.Ssex;
            parameters[3].Value = oldSno;
            parameters[4].Value = model.Cno;
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
        /// 根据班级编号和学号删除一条记录
        /// </summary>
        /// <param name="cno">班级编号</param>
        /// <param name="sno">学号</param>
        /// <returns>是否成功</returns>
        public bool Delete(String cno,string sno)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from student ");
            strSql.Append("where Cno=@Cno and Sno=@Sno ");
            SqlParameter[] parameters ={
                                          new SqlParameter("@Cno",SqlDbType.VarChar,20),
                                          new SqlParameter("@Sno",SqlDbType.VarChar,20)
                                      };
            parameters[0].Value = cno;
            parameters[1].Value = sno;
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
