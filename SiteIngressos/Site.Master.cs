using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteVendaIngressos
{
    public partial class SiteMaster : MasterPage
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["autenticado"] != null && Session["autenticado"].ToString() == "OK")
            {
                login.Visible = false;
                logout.Visible = true;
            } else
            {
                login.Visible = true;
                logout.Visible = false;
                Session.Abandon();
            }
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Response.Redirect("Logout.aspx");
        }
    }
}