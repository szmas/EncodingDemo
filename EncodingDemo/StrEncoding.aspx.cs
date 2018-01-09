using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace EncodingDemo
{
    public partial class StrEncoding : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        public byte[] GetBytes(string str, Encoding code)
        {
            return code.GetBytes(str);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = TextBox1.Text.Trim();

            //ascii 不能处理中文，中文变?
            var bt1 = GetBytes(str, Encoding.ASCII);
            Response.Write(string.Join(",", bt1) + "<br/>");

            //gb2312 中文一般是两位小数 ，英文是一位
            var bt2 = GetBytes(str, Encoding.Default);
            Response.Write(string.Join(",", bt2) + "<br/>");


            //utf-8 处理7位ascii 一个字节  处理中文 三个字节
            var bt3 = GetBytes(str, Encoding.UTF8);
            Response.Write(string.Join(",", bt3) + "<br/>");

            var bt4 = GetBytes(str, Encoding.Unicode);
            Response.Write(string.Join(",", bt4) + "<br/>");
        }
    }
}