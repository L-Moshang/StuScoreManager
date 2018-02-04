using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using stuScoreManager.DAL;
using stuScoreManager.Model;

namespace stuScoreManager.BLL
{
    class StuBLL
    {
        /// <summary>
        /// 根据班级编号查询该班所有学生
        /// </summary>
        /// <param name="cno">班级编号</param>
        /// <returns>该班所有学生</returns>
        public DataSet getStudentsByCno(string cno)
        {
            StuDal sDal = new StuDal();
            return sDal.GetListByCno(cno);
        }

        /// <summary>
        /// 添加学生信息
        /// </summary>
        /// <param name="model">新学生实体</param>
        /// <returns>是否成功</returns>
        public bool Add(StuInfo model)
        {
            if (model.Cno == "")
                throw new SystemException("学号不能为空");
            else if (model.Sname == "")
                throw new SystemException("姓名不能为空");
            else if (model.Ssex == "")
                throw new SystemException("性别不能为空");
            StuDal sDal = new StuDal();
            return sDal.Insert(model);
        }

        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="model">新学生实体</param>
        /// <param name="oldSno">学生原来的学号</param>
        /// <returns></returns>
        public bool changeStu(StuInfo model, string oldSno)
        {
            if (model.Cno == "")
                throw new SystemException("学号不能为空！");
            else if(model.Sname=="")
                throw new SystemException("姓名不能为空！");
            else if(model.Ssex=="")
                throw new SystemException("性别不能为空！");
            StuDal sDal = new StuDal();
            return sDal.Update(model, oldSno);
        }

        /// <summary>
        /// 根据班级编号和学号删除一条记录
        /// </summary>
        /// <param name="cno">班级编号</param>
        /// <param name="sno">学号</param>
        /// <returns>是否成功</returns>
        public bool removeStu(string cno, string sno)
        {
            StuDal sDal = new StuDal();
            return sDal.Delete(cno, sno);
        }

    }
}
