using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;

namespace EncodingDemo
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Timers.Timer myTimer = new System.Timers.Timer(5000);
            myTimer.Elapsed += new System.Timers.ElapsedEventHandler(myTimer_Elapsed);
            myTimer.Enabled = true;
            myTimer.AutoReset = false;
            File.AppendAllText(Server.MapPath("~") + "/msg.log", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n");
        }

        void myTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            File.AppendAllText(Server.MapPath("~") + "/msg.log", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"\r\n");
        }
    }
}