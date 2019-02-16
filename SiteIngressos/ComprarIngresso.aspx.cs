using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteVendaIngressos
{
    public partial class ComprarIngresso : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["autenticado"] != null && Session["autenticado"].ToString() == "OK")
            {
                
            } 
        }

        protected void ComprarIngresso_Click(object sender, EventArgs e)
        {

        }
    }
}