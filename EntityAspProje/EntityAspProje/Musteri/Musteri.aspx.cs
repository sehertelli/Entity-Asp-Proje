using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Musteri
{
    public partial class Musteri : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            
                var degerler = db.TBL_MUSTERI.ToList();
                Repeater1.DataSource = degerler;
                Repeater1.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBL_MUSTERI t = new TBL_MUSTERI();
            t.MUSTERIAD = TextBox1.Text;
            t.MUSTERISOYAD = TextBox2.Text;
            db.TBL_MUSTERI.Add(t);
            db.SaveChanges();
        }
    }
}