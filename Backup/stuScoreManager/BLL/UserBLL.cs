using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using stuScoreManager.DAL;
using stuScoreManager.Model;

namespace stuScoreManager.BLL
{
    class UserBLL
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name">登录名</param>
        /// <param name="password">密码</param>
        /// <returns>如果登录成功，则返回true，否则返回false</returns>
        public bool Login(string name, string password)
        {
            UserDal yhDal = new UserDal();
            UserInfo user = yhDal.GetModel(name);
            if (name == "")
            {
                throw new System.Exception("用户名不能为为空");
            }
            else if (password == "")
            {
                throw new System.Exception("密码不能为为空");
            }
            if (user == null)
            {
                throw new System.Exception("用户名错误，请重新输入");
                //return false;
            }
            if (user.UserPwd == password)           //MD5Encryption.EncryptWithMD5()
                return true;
            else
            {
                throw new System.Exception("密码错误，请再重新输入");
                //return false;
            }
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="model">新用户实体类</param>
        /// <param name="comfirmPwd">新用户的确认密码</param>
        /// <returns>是否成功</returns>
        public bool Add(UserInfo model, string comfirmPwd)
        {
            if (model.UserName=="")
                throw new System.Exception("用户名不能为空！");
            else if(model.UserPwd=="")
                throw new System.Exception("密码不能为空！");
            else if(model.UserPwd!=comfirmPwd)
                throw new System.Exception("两次输入密码不一致！");
            UserDal yhDal = new UserDal();
            UserInfo user = yhDal.GetModel(model.UserName);
            if (user != null)
                throw new System.Exception(model.UserName + " 用户名已存在，添加失败！");
            else
                return yhDal.Insert(model);
        }

        /// <summary>
        /// 根据用户名查找用户
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public UserInfo getUser(string name)
        {
            if (name == "")
                throw new System.Exception("请输入用户名！");
            UserDal yhDal = new UserDal();
            return yhDal.GetModel(name);
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="model">新用户</param>
        /// <param name="oldName">旧用户</param>
        /// <returns>是否修改成功</returns>
        public bool changeUser(UserInfo model, string oldName)
        {
            if(model.UserName=="")
                throw new System.Exception("用户名不能为空！");
            else if(model.UserPwd=="")
                throw new System.Exception("密码不能为空！");
            UserDal yhDal = new UserDal();
            UserInfo user = yhDal.GetModel(oldName);
            if(user==null)
                throw new System.Exception("要删除的用户名错误，请重新输入！");
            return yhDal.Update(model, oldName);
        }

        /// <summary>
        /// 根据用户名删除用户
        /// </summary>
        /// <param name="name">用户名</param>
        /// <returns>是否删除成功</returns>
        public bool removeUser(string name)
        {
            if (name == "")
                throw new System.Exception("用户名不能为空");
            UserDal yhDal = new UserDal();
            UserInfo user = yhDal.GetModel(name);
            if(user==null)
                throw new System.Exception("修改前的用户名错误，请重新输入");
            return yhDal.Delete(name);
        }
    }
}
