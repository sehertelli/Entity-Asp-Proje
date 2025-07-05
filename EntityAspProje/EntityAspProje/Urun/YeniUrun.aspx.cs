using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class YeniUrun : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var kate = (from x in db.TBL_KATEGORI select new { x.KATEGORIID, x.KATEGORIAD }).ToList();
                DropDownList1.DataTextField = "KATEGORIAD";
                DropDownList1.DataValueField = "KATEGORIID";
                DropDownList1.DataSource = kate;
                DropDownList1.DataBind();
            }            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBL_URUNLER t = new TBL_URUNLER();
            t.URUNAD = txtUrunAd.Text;
            t.URUNMARKA = txtMarka.Text;
            t.URUNKATEGORI = byte.Parse(DropDownList1.SelectedValue.ToString());
            t.URUNFIYAT = Decimal.Parse(txtFiyat.Text);
            t.URUNSTOK = short.Parse(txtStok.Text);
            db.TBL_URUNLER.Add(t);
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}