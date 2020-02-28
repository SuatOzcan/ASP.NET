using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_QueryString
{
    public partial class Bilgi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ad"]))
            {
                lblGelenBilgi.Text = Request.QueryString["ad"];
            }
            //lblKAdi.Text = Request.QueryString["KullaniciAdi"];
            lblKAdi.Text = Request.QueryString[0];
            lblSifre.Text = Request.QueryString["Sifre"];
        }
    }
}