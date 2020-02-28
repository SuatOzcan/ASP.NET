using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_StandartKontroller
{
    public partial class _2_DropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            KategorileriGetir();
        }
        void KategorileriGetir()
        {
            //DropDownList aslında Windows ortamındaki Combobox'ın karşılığıdır. Web ortamındaki render edilme durumundan dolayı object tipinde değil, string ya da ListItem tipinde değer alır.
            SqlDataAdapter da = new SqlDataAdapter("Select CategoryID,CategoryName from Categories", "Server=.;Database=NORTHWND;Integrated Security=true");
            DataTable dt = new DataTable();
            da.Fill(dt);

            ddlKategoriler.DataSource = dt;
            ddlKategoriler.DataTextField = "CategoryName";//DisplayMember'ın birebir karşılığıdır.
            ddlKategoriler.DataValueField = "CategoryID";//ValueMember'ın birebir karşılığıdır.
            //Web ortamının Windows ortamından data kontroller bakımından en fazla ayrılan yönü, verilerin bind edilmesi (yüklenmesi) zorunluluğudur. Bir kontrolün dataSource'una vermiş olduğunu değerleri, o kontrole bind etmeden veriler yüklenmez..
            ddlKategoriler.DataBind();
        }
        protected void btnPostbackYap_Click(object sender, EventArgs e)
        {
            Response.Write(string.Format("Seçmiş olduğunuz kategorinin adı: {0} <br/>Seçmiş olduğunuz kategorinin ID'si: {1}",ddlKategoriler.SelectedItem,ddlKategoriler.SelectedValue));
        }
    }
}