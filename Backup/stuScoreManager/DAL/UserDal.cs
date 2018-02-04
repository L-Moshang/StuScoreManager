using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using stuScoreManager.Model;
using System.Data.SqlClient;
using System.Data;

namespace stuScoreManager.DAL
{
    class UserDal
    {
        /// <summary>
        /// 根据用户名查找用户，返回一个对象
        /// </summary>
        /// <param name="loginName"></param>
        /// <returns></returns>
        public UserInfo GetModel(string loginName)
        {
            string strSql;
            strSql = "select top 1 userName,userPwd from users ";
            strSql += " where userName=@userName ";
            SqlParameter[] parameters ={
                                         new SqlParameter("@userName",SqlDbType.VarChar,20)
                                     };
            parameters[0].Value = loginName;
            DataSet ds = SQLHelper.Query(strSql, parameters);
            UserInfo model = new UserInfo();
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.UserName = ds.Tables[0].Rows[0]["userName"].ToString();
                model.UserPwd = ds.Tables[0].Rows[0]["UserPwd"].ToString();
                return model;
            }

            return null;
        }

        /// <summary>
        /// 插入用户
        /// </summary>
        /// <param name="model">用户实体类</param>
        /// <returns>是否成功</returns>
        public bool Insert(UserInfo model)
        {
            string strSql = "insert into users(userName,userPwd) values (@userName,@userPwd)";
            SqlParameter[] parameters ={
                                          new SqlParameter("@username",SqlDbType.VarChar,20), 
                                          new SqlParameter("@userPwd",SqlDbType.VarChar,50),
                                      };
            parameters[0].Value = model.UserName;
            parameters[1].Value = model.UserPwd;
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
        /// <param name="model">修改后的用户</param>
        /// <param name="oldName">修改前的用户</param>
        /// <returns>修改时候成功</returns>
        public bool Update(UserInfo model, string oldName)
        {
            int i = 0;
            string strSql;
            strSql = "update users set userName=@UserName,UserPwd=@UserPwd ";
            strSql += "where userName=@useroldName ";
            SqlParameter[] parameters ={
                new SqlParameter("@userName",SqlDbType.VarChar,20),
                new SqlParameter("@userPwd",SqlDbType.VarChar,50),
                new SqlParameter("@userOldName",SqlDbType.VarChar,20)
                                       };
            parameters[0].Value = model.UserName;
            parameters[1].Value = model.UserPwd;
            parameters[2].Value = oldName;
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
        /// 根据用户名删除一条数据
        /// </summary>
        /// <param name="loginName">用户名</param>
        /// <returns>是否删除成功</returns>
        public bool Delete(String loginName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from users ");
            strSql.Append("where userName=@userName ");
            SqlParameter[] pararmeters ={
                                           new SqlParameter("@userName",SqlDbType.VarChar,20)
                                       };
            pararmeters[0].Value = loginName;
            try
            {
                int i = SQLHelper.ExecuteNonQuery(strSql.ToString(), pararmeters);
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
