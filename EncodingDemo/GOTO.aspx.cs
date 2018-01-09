using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EncodingDemo
{
    public partial class GOTO : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            goto C;
        A:
            Response.Write("A");

        B:
            Response.Write("B");

        C:
            Response.Write("C");


            int n = 0;

            while (true)
            {
                while (true)
                {
                    if (n == 10)
                        goto D;

                    n++;
                }
            }
        D:
            n = 0;
        }
    }
}