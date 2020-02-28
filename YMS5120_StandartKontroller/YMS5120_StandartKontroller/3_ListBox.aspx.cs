using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YMS5120_StandartKontroller.Models;

namespace YMS5120_StandartKontroller
{
    public partial class _3_ListBox : System.Web.UI.Page
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        void KategoriListesi()
        {
            ddlKategoriler.DataSource = db.Categories.ToList();
            ddlKategoriler.DataTextField = "CategoryName";
            ddlKategoriler.DataValueField = "CategoryID";
            ddlKategoriler.DataBind();
        }
        void UrunGetir(int catId)
        {
            lstUrunler.DataSource = db.Products.Where(x => x.CategoryID == catId).ToList();
            lstUrunler.DataTextField = "ProductName";
            //lstUrunler.DataValueField = "ProductID";
            lstUrunler.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Db'den kategoriler listelensin.
            if (IsPostBack) return;
            KategoriListesi();
        }

        protected void ddlKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Kullanıcının seçmiş olduğu kategorideki ürünler listbox'a doldurulsun.
            UrunGetir(Convert.ToInt32(ddlKategoriler.SelectedValue));
        }
    }
}