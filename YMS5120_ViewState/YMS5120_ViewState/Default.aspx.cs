using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_ViewState
{
    public partial class Default : System.Web.UI.Page
    {
        /*
        * ViewState (Görüntü Durumu)
        * 
        * Verileri saklamak için default olarak kullanılan tekniktir.
        * Sayfa postback olduğunda ve geri geldiğinde aynı sayfadaki değerlerin saklanması işlemini viewstate yapar.
        * Kısacası sayfanın tarayıcıdan dönerkenki haline ulaşabilmenizi ve sayfa geri gönderilirken otomatikman tekrar bu bilgilerle gitmesini sağlar. Dolayısıyla sayfalar arası veri taşımaz.
        * 
        * Peki ViewState nasıl çalışır?
        * 
        * Asp.net arkada gizli bir input kontrolü oluşturur. Bu input kontrolünün içinde, sayfadaki istenilen kontrollerin bazı property'lerini base64 koduna çevirerek saklar. Bu gizlenmiş ViewState kontrolü sayfayla birlikte yaşar ve seyahat eder. Dolayısıyla eğer dikkatli ve kontrollü kullanılmazsa ViewState kontrolümüz gittikçe şişer ve ciddi performans sıkıntılara sebep olur.
        * 
        * ViewState üzerinde tutulan değerler bulunduğu sayfada saklandığı için, ViewState'lerin ömrü sayfanın ömrü kadardır.
        */
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            txtViewState.BackColor = Color.HotPink;
            txtViewState.ForeColor = Color.DarkViolet;
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            lblFalse.Text = "Bu label'ın EnableViewState özelliği kapalı..";
            lblTrue.Text = "Bu label'ın EnableViewState özelliği açık..";
        }
    }
}