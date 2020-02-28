using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_StandartKontroller
{
    public partial class _7_Multiview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void btnSonrakiAdim_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnSonrakiAdimaGec_Iki_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
            lblKullaniciAdi.Text = txtKullaniciAdi.Text;
            lblSifre.Text = txtSifre.Text;
        }
    }
}