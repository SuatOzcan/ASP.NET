using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_StandartKontroller
{
    public partial class _8_PlaceHolder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Label lbl_Uyari = new Label();
            lbl_Uyari.ID = "lblUyari";
            lbl_Uyari.Text = string.Format("{0} adlı kullanıcı başarıyla kaydedildi!",txtKullaniciAdi.Text);
            lbl_Uyari.Attributes.Add("class", "uyari");
            //Yukarıdaki ID ve Text gibi özellikleri de lbl_Uyari.Attributes.Add() diyerek ekleyebilirdik.
            plcYerTutucu.Controls.Add(lbl_Uyari);
        }
    }
}