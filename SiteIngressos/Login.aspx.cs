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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Acesso"] != null && !IsPostBack)
            {
                txtLogin.Text = Request.Cookies["Acesso"]["funcionario"];
                txtSenha.Attributes.Add("value", Request.Cookies["Acesso"]["senha"]);
            }

            if (Request.QueryString["msg"] != null)
                lblMensagem.Text = Request.QueryString["msg"];

            txtLogin.Focus();
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = string.Empty;
            if (txtLogin.Text.Trim() != "") 
            {
                if (txtSenha.Text.Trim() != "")
                {
                    Usuario user = new UsuarioController().Get(txtLogin.Text, txtSenha.Text);
                    if (user != null)
                    {
                        Session["autenticado"] = "OK";
                        Session["idUsuario"] = user.Id;
                        Session["nomeUsuario"] = user.Nome;
                        Session["loginUsuario"] = user.Email;
                        Session["senhaUsuario"] = user.Senha;

                        Response.Redirect("/");
                    }
                    else
                        lblMensagem.Text = "Usuário e/ou senha inválida.";
                } else
                {
                    lblMensagem.Text = "Preencha a Senha.";
                }
            } else
            {
                lblMensagem.Text = "Preencha o Email.";
            }
        }
    }
}