using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_WebForms
{
    public partial class Default : System.Web.UI.Page
    {
        /*
         * Bir asp.net web uygulaması geliştiriyorsanız anasayfanızın adı çoğunlukla default olarak karşınıza çıkar. 
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDeger.Text = "Merhaba";
        }
        // Yazdığınız C# kodu sunucuda çalışır, html kodu istemcide çalışır!
        protected void Button1_Click(object sender, EventArgs e)
        {
            lblKelime.Text = txtKelime.Text;
        }
    }
}