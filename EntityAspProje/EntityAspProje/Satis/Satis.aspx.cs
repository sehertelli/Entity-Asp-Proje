using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;
namespace EntityAspProje.Satis
{
    public partial class Satis : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            // var satislar = db.TBL_SATIS.ToList();
            var satislar = (from x in db.TBL_SATIS
                            select new
                            {
                                x.SATISID,
                                x.TBL_URUNLER.URUNAD,
                                x.TBL_PERSONEL.PERSONELADSOYAD,
                                MUSTERI = x.TBL_MUSTERI.MUSTERIAD + " " + x.TBL_MUSTERI.MUSTERISOYAD,
                                x.FIYAT
                            }).ToList();
            Repeater1.DataSource = satislar;
            Repeater1.DataBind();
        }
    }
}