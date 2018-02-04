using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace stuScoreManager.Model
{
    class SQLHelper
    {
        static string connString = "server=Moshang-PC;database=stuScoreManager;Integrated Security=True";
        //static string connString = "server=.;database=stuScoreManager;Integrated Security=True";
        
        //static string connString = "server=USER-20141022LE\\SQLEXPRESS;database=stuScoreManager;Integrated Security=True";
        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <param name="cmdParms"></param>
        /// <returns>返回查询结果数据表</returns>
        public static DataSet Query(string SQLString, params SqlParameter[] cmdParms)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = SQLString;
            cmd.CommandType = CommandType.Text;
            if (cmdParms != null)
            {
                foreach (SqlParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) && (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds, "ds");
                cmd.Parameters.Clear();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            return ds;
        }

        /// <summary>
        /// 执行查询语句，返回所受影响行数
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <param name="ps">参数</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] ps)
        {
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = System.Data.CommandType.Text;
            if (ps != null)
            {
                command.Parameters.AddRange(ps);
                connection.Open();
                int i = command.ExecuteNonQuery();
                connection.Close();
                return i;
            }
            else
                return -1;
        }


    }
}
