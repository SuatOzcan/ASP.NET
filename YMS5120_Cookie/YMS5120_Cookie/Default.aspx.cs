using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_Cookie
{
    public partial class Default : System.Web.UI.Page
    {
        /*
        * İstemcide, bilgisayarınızda sakladığınız dosyalardır.
        * 
        * Çerezler bilgileri düz metin şeklinde saklarlar.
        * 
        * Eğer kullanıcının bilgisayarında saklamaya ihtiyaç duyduğunuz bilgiler varsa kullanabilirsiniz.
        * 
        * En basitinden çoğu sitede kullanıcı giriş kısmında beni hatırla seçeneği vardır. Siz beni hatırla diyip giriş yapınca sizin bilgisayarınıza kullanıcı adı ve şifre bilgilerinizi barındıran bir belge yani cookie bırakılır.
        * 
        * Böylece siz bir daha aynı siteye girince kullanıcı girişi yapmazsınız. Sizin tarayıcınızdaki cookielerden verileriniz çekilir.
        * 
        * Çerezlerin dezavantajı 4KB büyüklüğünde değer tutuyor olmasıdır.
        * 
        * Çerezler eklenirken geçerlilik tarihi belirtiriz.
        */
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["bilgi"] != null)
            {
                HttpCookie cerez = Request.Cookies["bilgi"];
                Label1.Text = cerez["tarih"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Burada sizden isim ister. Bu isim ile istemciden sunucuya gönderilebilsin diye.
            HttpCookie cerez = new HttpCookie("bilgi");
            //Bir cookie birden fazla datayı içerisinde tutabilir.
            cerez["tarih"] = DateTime.Now.ToString();
            //Göndermeden önce bu cookie ne kadar yaşayacak demeliyiz. Eğer bunu yapmazsak birçok browser cookienizi reddedecektir.
            cerez.Expires = DateTime.Now.AddDays(7);
            //Bu noktadan sonra istemciye cookie'nizi gönderebilirsiniz.
            Response.Cookies.Add(cerez);
        }
    }
}