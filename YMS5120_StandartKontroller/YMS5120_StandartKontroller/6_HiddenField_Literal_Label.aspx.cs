using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_StandartKontroller
{
    public partial class _6_HiddenField_Literal_Label : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLiteralvsLabel_Click(object sender, EventArgs e)
        {
            //Literal vermiş olduğunuz yazıyı direkt olarak ekrana basar.
            //Label ise vermiş olduğunuz texti span etiketi içerisine alarak ekrana basacaktır. Bu nedenle codebehinddan bir html kodu gönderecekseniz span etiketi içerisinde div,table gibi html elementleri yazılmaması gerektiğinden literal kullanılmalıdır.
            lblYaziAlani.Text = "YMS5120 bugün çok uykulu!";
            ltrYaziAlani.Text = "<p class=\"yazi\">ARTIK UYANIN!</p>";
        }
    }
}