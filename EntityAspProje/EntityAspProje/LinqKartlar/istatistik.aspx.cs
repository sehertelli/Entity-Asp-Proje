using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;
namespace EntityAspProje.LinqKartlar
{
    public partial class istatistik : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBL_URUNLER.Count().ToString();
            Label2.Text = db.TBL_MUSTERI.Count().ToString();
            Label3.Text = db.TBL_SATIS.Sum(x=>x.FIYAT).ToString();
            Label4.Text = db.TBL_KATEGORI.Count().ToString();
            Label5.Text = db.TBL_URUNLER.Count(x=>x.DURUM==true).ToString();
            Label6.Text = db.TBL_URUNLER.Count(x=>x.DURUM==false).ToString();
            Label7.Text = (from x in db.TBL_URUNLER orderby x.URUNSTOK descending select x.URUNAD).FirstOrDefault();
        }
    }
}