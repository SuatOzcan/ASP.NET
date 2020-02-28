using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_QueryString
{
    public partial class Urunler : System.Web.UI.Page
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            int id = int.Parse(Request.QueryString["kategoriId"]);
            grdUrunler.DataSource = db.Products.Where(x => x.CategoryID == id).ToList();
            grdUrunler.DataBind();
        }
    }
}