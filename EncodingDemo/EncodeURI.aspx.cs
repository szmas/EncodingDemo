using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Text.RegularExpressions;

namespace EncodingDemo
{
    public partial class EncodeURI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            var bytes = Encoding.UTF8.GetBytes("春节");

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("X2"));
            }


            string s1 = builder.ToString();

            string s2 = HttpUtility.UrlEncodeUnicode("春节");

        }
    }
}