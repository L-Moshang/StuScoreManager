using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using stuScoreManager.DAL;
using stuScoreManager.Model;

namespace stuScoreManager.BLL
{
    class CourseBLL
    {
        /// <summary>
        /// 获取所有课程信息
        /// </summary>
        /// <returns>返回一个DataSet结果集</returns>
        public DataSet getCourse()
        {
            CourseDal cdal = new CourseDal();
            return cdal.GetList();
        }


        /// <summary>
        /// 添加课程信息
        /// </summary>
        /// <param name="modle">新课程实体</param>
        /// <returns>是否成功</returns>
        public bool Add(CourseInfo modle)
        {
            if (modle.Cno == "")
                throw new SystemException("课程编号不能为空！");
            else if(modle.Cname=="")
                throw new SystemException("课程名称不能为空！");
            else if(modle.Cteacher=="")
                throw new SystemException("任课教师不能为空！");
            CourseDal cDal = new CourseDal();
            return cDal.Insert(modle);
        }

        /// <summary>
        /// 修改课程信息
        /// </summary>
        /// <param name="model">新课程实体</param>
        /// <param name="oldCno">课程原编号</param>
        /// <returns></returns>
        public bool changeCourse(CourseInfo model, string oldCno)
        {
            if (model.Cno == "")
                throw new SystemException("课程编号不能为空！");
            else if(model.Cname=="")
                throw new SystemException("课程名称不能为空！");
            else if(model.Cteacher=="")
                throw new SystemException("任课教师不能为空！");
            CourseDal cDal = new CourseDal();
            return cDal.Update(model, oldCno);
        }

        /// <summary>
        /// 根据课程编号删除一条记录
        /// </summary>
        /// <param name="cno">课程编号</param>
        /// <returns>是否成功</returns>
        public bool removeCourse(string cno)
        {
            CourseDal cDal = new CourseDal();
            return cDal.Delete(cno);
        }
    }
}
