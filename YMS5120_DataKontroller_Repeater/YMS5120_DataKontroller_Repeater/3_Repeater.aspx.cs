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
    public partial class _3_Repeater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Products", "Server=.;Database=NORTHWND;Integrated Security=true");
            DataTable dt = new DataTable();
            da.Fill(dt);

            rptUrunler.DataSource = dt;
            rptUrunler.DataBind();
        }
    }
}