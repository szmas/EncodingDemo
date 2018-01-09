using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace EncodingDemo
{
    public partial class FileDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            using (FileStream fs = new FileStream(Server.MapPath("") + "/file/绩效月报.xls", FileMode.OpenOrCreate))
            {
                int fsLen = (int)fs.Length;
                byte[] heByte = new byte[fsLen];
                fs.Read(heByte, 0, heByte.Length);


                string downloadName = "绩效月报.xls";
                if (Request.Browser.Browser == "InternetExplorer")
                    downloadName = HttpUtility.UrlPathEncode(downloadName);

                Response.ContentType = "application/excel";

                string headerValue = string.Format("attachment; filename=\"{0}\"", downloadName);
                Response.AddHeader("Content-Disposition", headerValue);
                Response.OutputStream.Write(heByte, 0, heByte.Length);
                Response.ContentEncoding = System.Text.Encoding.GetEncoding("utf-8");
                Response.End();
            }


        }
    }
}