using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;
namespace EntityAspProje.Urun
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var kate = (from x in db.TBLKATEGORI select new { x.KATEGORIID, x.KATEGORIAD }).ToList();
                DropDownList1.DataTextField = "KATEGORIAD";
                DropDownList1.DataValueField = "KATEGORIID";
                DropDownList1.DataSource = kate;
                DropDownList1.DataBind();

                int id = Convert.ToInt32(Request.QueryString["URUNID"]);
                var p = db.TBLURUNLER.Find(id);
                TxtUrunAd.Text = p.URUNAD;
                TxtStok.Text = p.URUNSTOK.ToString();
                TxtMarka.Text = p.URUNMARKA.ToString();
                TxtFiyat.Text = p.URUNFIYAT.ToString();
                DropDownList1.SelectedValue = p.URUNKATEGORI.ToString();

           }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["URUNID"]);
            var p = db.TBLURUNLER.Find(id);
            p.URUNAD = TxtUrunAd.Text;
            p.URUNSTOK = short.Parse(TxtStok.Text);
            p.URUNMARKA = TxtMarka.Text;
            p.URUNFIYAT = decimal.Parse(TxtFiyat.Text);
            p.URUNKATEGORI = byte.Parse(DropDownList1.SelectedValue.ToString());
            db.SaveChanges();
            Response.Redirect("Urunler.Aspx");
        }
    }
}