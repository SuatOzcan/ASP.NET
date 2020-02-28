using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_PostbackKavrami
{
    public partial class _3_AutoPostBack : System.Web.UI.Page
    {
        /*
         * AUTOPOSTBACK
         * Bazı kontrollerin Autopostback özelliği sayesinde kullanıcının kontrolden ayrılması anında, veriler sunucuya postalanır. Yani postalama işleminin yapılması için button'a tıklama ya da farklı bir olayın tetiklenmesi beklenmez. Bu özelliğin kullanılabilmesi için sayfa tasarımı sırasında, verinin hemen postalanması istenen kontrolün AutoPostBack özelliğinin aktif hale getirilmesi yeterlidir.
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack) return;
            if (!IsPostBack)
            {
                ddlIl.Items.Add("Lütfen Seçiniz..");
                ddlIl.Items.Add("İstanbul");
                ddlIl.Items.Add("Ankara");
                ddlIl.Items.Add("İzmir");
                ddlIlce.Items.Add("Lütfen Seçiniz..");
            }
        }

        protected void ddlIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlIlce.Items.Clear();
            if (ddlIl.SelectedIndex == 1)
            {
                ddlIlce.Items.Add("Bakırköy");
                ddlIlce.Items.Add("Kadıköy");
                ddlIlce.Items.Add("Beşiktaş");
            }
            else if (ddlIl.SelectedIndex == 2)
            {
                ddlIlce.Items.Add("Çankaya");
                ddlIlce.Items.Add("Gölbaşı");
                ddlIlce.Items.Add("Mamak");
            }
            else if (ddlIl.SelectedIndex == 3)
            {
                ddlIlce.Items.Add("Karşıyaka");
                ddlIlce.Items.Add("Konak");
                ddlIlce.Items.Add("Göztepe");
            }
        }
    }
}