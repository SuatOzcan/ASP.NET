using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YMS5120_StandartKontroller
{
    public partial class _4_FileUpload : System.Web.UI.Page
    {
        /*
         * FileUpload, dış dünyadan bir dosyanın server içerisine yüklenmesi için kullanılan bir kontroldür. Bazı özellikleri;
         * 1) HasFile => FileUpload üzerinde bir dosyanın seçimli durumda olup olmadığını size döndürür.
         * 2) PostedFile => Eğer bir dosya versa, o dosya ile ilgili temel özellikleri (dosyanın boyutu, Mime tipi, dosya adı vs..) size teslim eder.
         *      a) ContentLength => Dosyanın boyutunu byte biriminden teslim eder. 1mb=> 1.048.576 byte
         *      b) ContentType => Dosyanın Mime tipini teslim eder.
         *      c) FileName => Yüklenmek istenen dosyanın adını size teslim eder.
         * 3) SaveAs => Dosyanın server'a kaydedilmesi için kullandığımız metottur. Kayıt edilip edilmediğiyle ilgili bir bildirim dönmez. Bunun için System.IO.File sınıfını kullanabilirsiniz.
         * 
         */
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            //Path.GetExtension() dosyanın uzantısını size teslim eder.
            //Solution Explorer içerisinde olmayan ama gerçekten proje dosyasında olan bir veriyi solution explorer üzerinde Show All Files diyerek görüntüleyebilir, istediğiniz dosyaya sağ tıklayıp include project diyerek projeye ekleyebilirsiniz. (Dosya var ama solution explorerda yüklü gözükmüyorsa bunu yapabilirsiniz.)
            bool sonuc = false;
            if (fuDosyaYukleyicisi.HasFile)
            {
                HttpPostedFile yuklenecek = fuDosyaYukleyicisi.PostedFile;
                if (yuklenecek.ContentLength < 1000000000)
                {
                    if (yuklenecek.ContentType.Contains("jpeg"))
                    {
                        //string dosyaAdi = yuklenecek.FileName;
                        Guid benzersiz = Guid.NewGuid();

                        fuDosyaYukleyicisi.SaveAs(Server.MapPath("images/" + benzersiz + ".jpg"));
                        sonuc = File.Exists(Server.MapPath("images/" + benzersiz + ".jpg"));
                    }
                }
            }
            Response.Write(sonuc ? "Dosya başarıyla kaydedildi!" : "Dosya kaydetme esnasında bir hata oluştu!");
        }
    }
}