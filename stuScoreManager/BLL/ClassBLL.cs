using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using stuScoreManager.DAL;
using stuScoreManager.Model;

namespace stuScoreManager.BLL
{
    class ClassBLL
    {
        /// <summary>
        /// 获取所有班级信息
        /// </summary>
        /// <returns>返回一个DataSet结果集</returns>
        public DataSet getClasses()
        {
            ClassDal cDal = new ClassDal();
            return cDal.GetList();
        }

        /// <summary>
        /// 根据班级名称获取班级编号
        /// </summary>
        /// <param name="cname"></param>
        /// <returns></returns>
        public DataSet getclassno(string cname)
        {
            ClassDal cDal = new ClassDal();
            return cDal.ccno(cname);
        }

        /// <summary>
        /// 添加班级
        /// </summary>
        /// <param name="model">新班级实体类</param>
        /// <param name="oldNo">是否成功</param>
        /// <returns></returns>
        public bool Add(ClassInfo model)
        {
            if (model.Cno == "")
                throw new SystemException("班级编号不能为空！");
            else if(model.Cname=="")
                throw new SystemException("班级名称不能为空！");
            else if(model.Cdept=="")
                throw new SystemException("班级所属系部不能为空！");
            ClassDal cDal = new ClassDal();
            ClassInfo cInfo = cDal.getModel(model.Cno);
            if (cInfo != null)
                throw new SystemException("班级已经存在，添加失败！");
            return cDal.Insert(model);
        }

        /// <summary>
        /// 修改班级信息
        /// </summary>
        /// <param name="model">新班级</param>
        /// <param name="oldNo">旧班级编号</param>
        /// <returns>是否修改成功</returns>
        public bool changeClass(ClassInfo model, string oldNo)
        {
            if (model.Cno == "")
                throw new SystemException("班级编号不能为空！");
            else if(model.Cname=="")
                throw new SystemException("班级名称不能为空！");
            else if(model.Cdept=="")
                throw new SystemException("班级所属系部不能为空！");
            ClassDal cDal = new ClassDal();
            ClassInfo cInfo = cDal.getModel(oldNo);
            if(cInfo==null)
                throw new SystemException("请选择班级！");
            return cDal.Update(model, oldNo);
        }

        /// <summary>
        /// 根据班级编号删除班级
        /// </summary>
        /// <param name="cNo">班级编号</param>
        /// <returns>是否删除成功</returns>
        public bool removeClass(string cNo)
        {
            ClassDal cDal = new ClassDal();
            if (cNo == null)
                throw new SystemException("请选择班级！");
            ClassInfo cInfo = cDal.getModel(cNo);
            if(cInfo==null)
                throw new SystemException("班级不存在，请重新选择班级！");
            return cDal.Delete(cNo);
        }



    }
}
