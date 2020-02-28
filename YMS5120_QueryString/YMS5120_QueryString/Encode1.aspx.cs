using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_QueryString
{
    public partial class Encode1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {
            string encoded = Server.UrlEncode(txtEncode.Text);
            Response.Redirect("Encode2.aspx?name=" + encoded);
        }
    }
}