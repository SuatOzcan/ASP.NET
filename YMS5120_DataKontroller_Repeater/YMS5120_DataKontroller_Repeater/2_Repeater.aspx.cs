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
    public partial class _2_Repeater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Ekrana çalışanların adı soyadı - ev telefonu sıra sıra repeater ile listelensin. (ul li içerisinde listelensin.) Alternating Item Template de kullanın.
            if (IsPostBack) return;
            SqlDataAdapter da = new SqlDataAdapter("Select FirstName + ' ' + LastName as AdSoyad,HomePhone from Employees","Server=.;Database=NORTHWND;Integrated Security=true");
            DataTable dt = new DataTable();
            da.Fill(dt);

            rptCalisanlar.DataSource = dt;
            rptCalisanlar.DataBind();
        }
    }
}