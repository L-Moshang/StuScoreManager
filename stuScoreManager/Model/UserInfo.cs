using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stuScoreManager.Model
{
    class UserInfo
    {
        string userName;

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        string userPwd;

        /// <summary>
        /// 密码
        /// </summary>
        public string UserPwd
        {
            get { return userPwd; }
            set { userPwd = value; }
        }
    }
}
