using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;

namespace EncodingDemo
{
    public partial class CreateMD5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public static string MD5(string data, Encoding code)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dataHash = md5.ComputeHash(code.GetBytes(data));
            StringBuilder sb = new StringBuilder();
            foreach (byte b in dataHash)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = TextBox1.Text.Trim();

            Response.Write(MD5(str, Encoding.UTF8) + "<br/>");
            Response.Write(MD5(str, Encoding.Unicode) + "<br/>");
            Response.Write(MD5(str, Encoding.ASCII) + "<br/>");
            Response.Write(MD5(str, Encoding.GetEncoding("gb2312")) + "<br/>");
            Response.Write(MD5(str, Encoding.Default) + "<br/>");
        }

    }
}