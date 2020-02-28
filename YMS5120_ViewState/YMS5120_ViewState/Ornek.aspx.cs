using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_ViewState
{
    public partial class Ornek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["sayi"] == null)
                ViewState["sayi"] = 0;
        }
        protected void btnArttir_Click(object sender, EventArgs e)
        {
            int sayi = (int)ViewState["sayi"];
            lblSayi.Text = sayi.ToString();
            sayi++;
            ViewState["sayi"] = sayi;
        }
    }
}