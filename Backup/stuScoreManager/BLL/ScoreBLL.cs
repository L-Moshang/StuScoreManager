using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using stuScoreManager.DAL;
using stuScoreManager.Model;

namespace stuScoreManager.BLL
{
    class ScoreBLL
    {
        /// <summary>
        /// 根据班级和课程编号获得所有学生的成绩信息
        /// </summary>
        /// <param name="classNo">班级编号</param>
        /// <param name="courseNo">课程编号</param>
        /// <returns>结果集</returns>
        public DataSet getScore(string classNo, string courseNo)
        {
            ScoreDal dal = new ScoreDal();
            return dal.GetList(classNo,courseNo);
        }

        /// <summary>
        /// 添加成绩
        /// </summary>
        /// <param name="model">新成绩实体类</param>
        /// <returns>是否成功</returns>
        public bool Add(ScoreInfo model)
        {
            ScoreDal sDal = new ScoreDal();
            return sDal.Insert(model);
        }

        /// <summary>
        /// 修改成绩信息
        /// </summary>
        /// <param name="model">新成绩信息</param>
        /// <returns>是否修改成功</returns>
        public bool changeGrade(ScoreInfo model)
        {
            ScoreDal sDal = new ScoreDal();
            return sDal.Update(model);
        }


    }
}
