using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Api.Controllers;
using Models.Model;

namespace SiteVendaIngressos
{
    public partial class _Default : Page
    {
        public List<Evento> Eventos;
        protected void Page_Load(object sender, EventArgs e)
        {
            Eventos = new EventoController().GetProximosEventosDisponiveis();
        }
    }
}