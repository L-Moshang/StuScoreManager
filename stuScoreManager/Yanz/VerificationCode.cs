using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace stuScoreManager
{
    public class VerificationCode
    {
        public string str;

        public Image Yzm()
        {
            str = null;
            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                int rNumber = r.Next(0, 10);
                str += rNumber;
            }
            //创建GDI对象
            Bitmap bmp = new Bitmap(120, 35);
            Graphics g = Graphics.FromImage(bmp);

            string[] fonts = { "微软雅黑", "宋体", "黑体", "隶书", "仿宋" };
            Color[] colors = { Color.Yellow, Color.Blue, Color.Black, Color.Red, Color.Green };

            //随机赋值
            for (int i = 0; i < 5; i++)
            {
                Point p = new Point(i * 20, 0);
                g.DrawString(str[i].ToString(), new Font(fonts[r.Next(0, 5)], 20, FontStyle.Bold), new SolidBrush(colors[r.Next(0, 5)]), p);
            }

            //验证码覆盖线
            for (int i = 0; i < 20; i++)
            {
                Point p1 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                Point p2 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));

                g.DrawLine(new Pen(Brushes.Black), p1, p2);
            }

            //像素颗粒
            for (int i = 0; i < 100; i++)
            {
                Point p = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                bmp.SetPixel(p.X, p.Y, Color.Black);
            }

            //将图片镶嵌在PictureBox中
            return bmp;
        }

        public bool YanZ(string str1)
        {
            if (str1.Trim() == "")
                throw new SystemException("请输入验证码！");
            else if (str1 == "请输入验证码")
                throw new SystemException("请输入验证码！");
            else if (str1 == str)
                return true;
            else
                throw new SystemException("验证码输入错误！");
        }

    }
}
