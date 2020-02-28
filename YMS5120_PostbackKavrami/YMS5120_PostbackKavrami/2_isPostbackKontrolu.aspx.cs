using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_PostbackKavrami
{
    public partial class _2_isPostbackKontrolu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * Page_Load eventi, sayfa istemciye her gonderildiginde calisan bir eventtir. DropDownList'in de kendiliginden uzerindeki elemanlari koruma yetenegi vardir. Dolayisiyla siz sayfayi her istediginizde "if (IsPostBack) return;" bu bloğun olmadığı durumda onun aşağısındaki kodlar defalarca çalışacağı için ayni elemanlar defalarca eklencektir.
             * Çözüm; isPostback kontroludur. Boylece sayfa postback sonucu karsimiza gelmisse, ayni elemanlarin eklenmemesi - aslında o kodlarin calismamasini - saglamis oluruz...
             */
            if (IsPostBack) return;

            ddlSehirler.Items.Add("İstanbul");
            ddlSehirler.Items.Add("İzmir");
            ddlSehirler.Items.Add("Ankara");
        }
    }
}