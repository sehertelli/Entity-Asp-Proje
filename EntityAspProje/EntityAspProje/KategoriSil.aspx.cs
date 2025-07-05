using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class KategoriSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BONUSASPDBEntities db = new BONUSASPDBEntities();
            int x = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var p = db.TBL_KATEGORI.Find(x);
            db.TBL_KATEGORI.Remove(p);
            db.SaveChanges();
            Response.Redirect("Kategori.aspx");
        }
    }
}