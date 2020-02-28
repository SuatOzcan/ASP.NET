using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_DataKontroller_GridView
{
    public partial class _3_GridView : System.Web.UI.Page
    {
        void KategorileriDoldur()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select CategoryID,CategoryName from Categories", "Server=.;Database=NORTHWND;Integrated Security=true");
            DataTable dt = new DataTable();
            da.Fill(dt);

            ddlKategoriler.DataSource = dt;
            ddlKategoriler.DataTextField = "CategoryName";
            ddlKategoriler.DataValueField = "CategoryID";
            ddlKategoriler.DataBind();
        }
        void UrunleriDoldur(int katID)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select ProductID,ProductName,UnitPrice,UnitsInStock,CategoryID from Products where CategoryID=@ID", "Server=.;Database=NORTHWND;Integrated Security=true");
            da.SelectCommand.Parameters.AddWithValue("@ID", katID);
            DataTable dt = new DataTable();
            da.Fill(dt);

            grdUrunler.DataSource = dt;
            grdUrunler.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Kategoriler dropdownlist'e doldurulsun. (Metot)
            if (IsPostBack) return;
            KategorileriDoldur();
        }

        protected void ddlKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kullanıcının seçmiş olduğu kategorinin ürünleri gridview'e listelensin. (Metot)
            UrunleriDoldur(int.Parse(ddlKategoriler.SelectedValue));
        }
    }
}