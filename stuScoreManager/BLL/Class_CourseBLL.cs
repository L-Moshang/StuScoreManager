using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using stuScoreManager.DAL;
using stuScoreManager.Model;

namespace stuScoreManager.BLL
{
    class Class_CourseBLL
    {
        /// <summary>
        /// 根据课程编号查找上课班级
        /// </summary>
        /// <param name="courseNo">课程编号</param>
        /// <returns>结果集</returns>
        public DataSet selectClasses(string courseNo)
        {
            Class_CourseDal dal = new Class_CourseDal();
            return dal.GetList(courseNo);
        }

        /// <summary>
        /// 添加班级课程信息
        /// </summary>
        /// <param name="model">新班级课程实体类</param>
        /// <returns>是否成功</returns>
        public bool Add(Class_CourseInfo model)
        {
            Class_CourseDal cDal = new Class_CourseDal();
            return cDal.Insert(model);
        }

        /// <summary>
        /// 根据班级编号和课程编号删除一条记录
        /// </summary>
        /// <param name="classNo">班级编号</param>
        /// <param name="courseNo">课程编号</param>
        /// <returns>是否成功</returns>
        public bool Remove(string classNo, string courseNo)
        {
            Class_CourseDal dal = new Class_CourseDal();
            return dal.Deleter(classNo, courseNo);
        }


    }
}
