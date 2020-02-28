using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_PostbackKavrami
{
    public partial class _1_Postback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * POSTBACK
             * Server tarafından yollanan sayfa üzerindeki verilerin tekrar server'a gönderilmesi ve sayfanın tekrardan hazırlanıp kullanıcıya geri gönderilmesi sürecine "Postback" denir.
             * Sayfanızın ilk istekle (örneğin tarayıcıya adresi yazıp Enter'a basmak vs..) gönderilmesini sağlayan web metodu "Get"'tir.
             */
            if (IsPostBack)
            {
                lblKarsilama.Text = "Sayfa postback sonucu gelmiştir.";
            }
            else
            {
                lblKarsilama.Text = "Sayfa ilk istek sonucu gönderilmiştir.";
            }
        }
    }
}