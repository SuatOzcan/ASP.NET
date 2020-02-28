using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_QueryString
{
    public partial class Default : System.Web.UI.Page
    {
        /*
         * QUERY STRING
         * 
         * QueryString web sayfaları arasında veri taşırken kullanılır.
         * 
         * İstenen bilgiyi gidilecek olan sayfanın adresine (url'ine) ekleyerek taşımanızı sağlar. Veriler, istekte bulunan istemcinin tarayıcısı aracılığı ile taşınır. Dolayısıyla client-side bir yöntemdir.
         * 
         * Web sayfalarında sıkça gördüğünüz ? operatörü ile kullanılmaktadır. Key value mekanizması ile çalışır. Soru işaretinden sonra key belirtilir eşittir operatörü ile değeri verilir birden fazla querystring kullanılacaksa & (ampersant) işareti kullanılır.
         * 
         * Querystring key ve değerleri kullanıcıdan yani web sitesi ziyaretçilerinden saklanamazlar. Çünkü adres çubuğunda querystring key ve value bilgisi görünmektedir.
         * 
         * URL adresinin içerisinde bulunmasından dolayı, sayfanın yerimlerine kaydedilmesi durumunda kendisi de saklanır. Böylece yer imine gidildiğinde, sayfanın saklandığı haldeki şekliyle açılır.
         */
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGoster_Click(object sender, EventArgs e)
        {
            //Button click'inde sayfa yönlendirme
            Response.Redirect("Bilgi.aspx?KullaniciAdi=" + txtKAdi.Text + "&Sifre=" + txtSifre.Text);
        }

        protected void btnBul_Click(object sender, EventArgs e)
        {
            
            Response.Redirect();
        }
    }
}