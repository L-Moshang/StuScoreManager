using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using stuScoreManager.Model;
using System.Data.SqlClient;

namespace stuScoreManager.DAL
{
    class ClassDal
    {
        /// <summary>
        /// 查询所有班级
        /// </summary>
        /// <returns>结果集</returns>
        public DataSet GetList()
        {
            string strSql;
            strSql = "select * from class";
            return SQLHelper.Query(strSql);
        }

        public DataSet ccno(string cname)
        {
            string strSql;
            strSql = "select * from class where cname='"+cname+"'";
            return SQLHelper.Query(strSql);
        }

        /// <summary>
        /// 插入班级信息
        /// </summary>
        /// <param name="model">班级实体类</param>
        /// <returns>是否成功</returns>
        public bool Insert(ClassInfo model)
        {
            string strSql;
            strSql = "insert into class(Cno,Cname,Cdept) values (@Cno,@Cname,@Cdept) ";
            SqlParameter[] parameters ={
                                         new SqlParameter("@Cno",SqlDbType.VarChar,20),
                                         new SqlParameter("@Cname",SqlDbType.VarChar,20),
                                         new SqlParameter("@Cdept",SqlDbType.VarChar,20)
                                     };
            parameters[0].Value = model.Cno;
            parameters[1].Value = model.Cname;
            parameters[2].Value = model.Cdept;
            try
            {
                int i = SQLHelper.ExecuteNonQuery(strSql, parameters);
                    if(i>0)
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
        /// 根据班级编号，查询班级信息
        /// </summary>
        /// <param name="cno">班级编号</param>
        /// <returns>返回班级信息</returns>
        public ClassInfo getModel(string cno)
        {
            ClassInfo cInfo = new ClassInfo();
            string strSql;
            strSql = "select Cno,Cname,Cdept from class where Cno=@Cno ";
            SqlParameter[] parameters ={
                                          new SqlParameter("@Cno",SqlDbType.VarChar,20)
                                      };
            parameters[0].Value = cno;
            try
            {
                DataSet ds = SQLHelper.Query(strSql, parameters);
                if (ds != null)
                {
                    cInfo.Cno = ds.Tables[0].Rows[0]["Cno"].ToString();
                    cInfo.Cname = ds.Tables[0].Rows[0]["Cname"].ToString();
                    cInfo.Cdept = ds.Tables[0].Rows[0]["Cdept"].ToString();
                    return cInfo;
                }
                return null;
            }
            catch 
            {
                return null;
            }
        }

        /// <summary>
        /// 更新一条记录
        /// </summary>
        /// <param name="model">修改都班级实体</param>
        /// <param name="oldNo">修改前的班级编号</param>
        /// <returns>是该是否成功</returns>
        public bool Update(ClassInfo model, string oldNo)
        {
            int i = 0;
            string strSql;
            strSql = "update class set Cno=@Cno,Cname=@Cname,Cdept=@Cdept ";
            strSql += "where Cno=@oldNo ";
            SqlParameter[] parameters ={
                                          new SqlParameter("@Cno",SqlDbType.VarChar,20),
                                          new SqlParameter("@Cname",SqlDbType.VarChar,20),
                                          new SqlParameter("@Cdept",SqlDbType.VarChar,20),
                                          new SqlParameter("@oldNo",SqlDbType.VarChar,20)
                                      };
            parameters[0].Value = model.Cno;
            parameters[1].Value = model.Cname;
            parameters[2].Value = model.Cdept;
            parameters[3].Value = oldNo;
            try
            {
                i=SQLHelper.ExecuteNonQuery(strSql,parameters);
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
        /// 根据班级编号删除一条数据
        /// </summary>
        /// <param name="cNo">班级编号</param>
        /// <returns>是否删除成功</returns>
        public bool Delete(String cNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from class ");
            strSql.Append("where Cno=@Cno ");
            SqlParameter[] parameters ={
                                          new SqlParameter("@Cno",SqlDbType.VarChar,20)
                                      };
            parameters[0].Value = cNo;
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
