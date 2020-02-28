using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_StandartKontroller
{
    public partial class _5_LinkButton_HyperLink_ImageButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (LinkButton1.CommandName == "yonlendir")
                Response.Redirect(LinkButton1.CommandArgument);
        }

        protected void lnkTikla_Click(object sender, EventArgs e)
        {
            //Hangi linkbutton'a tıkladığımızı sender objecti sayesinde algıladık.
            LinkButton lb = (LinkButton)sender;
            if (lb.CommandName == "yonlendir")
            {
                if (lb.CommandArgument == "GoogleaGit")
                {
                    Response.Redirect("//google.com");
                }
            }
            else if(lb.CommandName == "degisiklik")
            {
                Title = lb.CommandArgument;
            }
        }
    }
}