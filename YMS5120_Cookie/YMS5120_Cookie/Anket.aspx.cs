using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_Cookie
{
    public partial class Anket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Anket"] != null)
            {
                HttpCookie cerez = Request.Cookies["Anket"];
                rlbTakim.SelectedValue = cerez["secim"];
                Response.Write("Daha önce oy kullandınız!");
                btnOyVer.Enabled = false;
                rlbTakim.Enabled = false;
            }
        }

        protected void btnOyVer_Click(object sender, EventArgs e)
        {
            HttpCookie cerez = new HttpCookie("Anket");
            cerez["secim"] = rlbTakim.SelectedValue;
            cerez.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(cerez);
        }
    }
}