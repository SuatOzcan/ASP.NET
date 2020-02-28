using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_DataKontroller_Repeater
{
    public partial class _1_Repeater : System.Web.UI.Page
    {
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            SqlDataAdapter da = new SqlDataAdapter("Select CategoryID,CategoryName from Categories","Server=.;Database=NORTHWND;Integrated Security=true");
            dt = new DataTable();
            da.Fill(dt);

            rptKategoriler.DataSource = dt;
            //Web ortamında, windows ortamından farklı olarak, bir data kontrolüne vermiş olduğunuz veri kaynağındaki tüm verilerin yüklenmesi (Eval metotlarının çalıştırılması) için "DataBind()" denilen metot mutlaka kullanılmalıdır.
            rptKategoriler.DataBind();
        }
        //ItemCreated eventi her bir eleman oluşturulduktan hemen sonra tetiklenir!
        protected void rptKategoriler_ItemCreated(object sender, RepeaterItemEventArgs e)
        {
            //Aslında Header da Footer da bir Item'dır!
            if (e.Item.ItemType == ListItemType.Footer)
            {
                //Label lbl = (Label)e.Item.FindControl("lblToplamKategoriSayisi");
                //lbl.Text
                (e.Item.FindControl("lblToplamKategoriSayisi") as Label).Text = string.Format("<strong>Şu anda toplam {0} kategori bulunmaktadır.</strong>",dt.Rows.Count);
            }
        }
    }
}