using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;
namespace EntityAspProje
{
    public partial class KategoriGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
                TxtID.Text = id.ToString();
                var ktgr = db.TBL_KATEGORI.Find(id);
                TxtKategori.Text = ktgr.KATEGORIAD;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var ktgr = db.TBL_KATEGORI.Find(id);
            ktgr.KATEGORIAD = TxtKategori.Text;
            db.SaveChanges();
            Response.Redirect("Kategori.aspx");
        }
    }
}