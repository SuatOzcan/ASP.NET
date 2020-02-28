using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_StandartKontroller
{
    public partial class _1_Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //Takvim üzerinde bir tarih seçimi gerçekleştiğinde devreye girecek olay SelectionChanged olayıdır. Buradan seçili olan bir tarihi alabilirsiniz.

            //Bir değeri sayfa üzerine yazdırmak için;
            Response.Write(Calendar1.SelectedDate);
        }
    }
}