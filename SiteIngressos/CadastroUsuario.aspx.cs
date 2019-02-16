using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.UI;
using System.Web.UI.WebControls;
using Api.Controllers;
using Models.Model;

namespace SiteVendaIngressos
{
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CadastrarUsuario_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                Usuario user = new Usuario();
                user.Nome = Nome.Text;
                user.CPF = CPF.Text;
                user.DataNascimento = Convert.ToDateTime(DataNascimento.Text);
                user.Sexo = Sexo.SelectedValue;
                user.Endereco = Endereco.Text;
                user.BairroEndereco = BairroEndereco.Text;
                user.CidadeEndereco = CidadeEndereco.Text;
                user.CEPEndereco = CEPEndereco.Text;
                user.Email = Email.Text;
                user.Senha = Senha.Text;

                string salvarUsuario = (new UsuarioController().Post(user)).ToString();

                if (salvarUsuario == "OK")
                {
                    Session["autenticado"] = "OK";
                    Session["idUsuario"] = user.Id;
                    Session["nomeUsuario"] = user.Nome;
                    Session["loginUsuario"] = user.Email;
                    Session["senhaUsuario"] = user.Senha;

                    Response.Redirect("/");
                }
            }

        }

        protected bool ValidaCampos()
        {

            if (IsPostBack)
            {
                lblNome.Visible = false;
                lblCPF.Visible = false;
                lblDataNascimento.Visible = false;
                lblSexo.Visible = false;
                lblCPF.Visible = false;
                lblEndereco.Visible = false;
                lblBairroEndereco.Visible = false;
                lblCidadeEndereco.Visible = false;
                lblCEPEndereco.Visible = false;
                lblEmail.Visible = false;
                lblSenha.Visible = false;
            }

            if (Nome.Text == "")
            {
                lblNome.Visible = true;
                lblNome.Text = "Campo Obrigatório";
                Nome.Focus();
                return false;
            }

            if (CPF.Text == "")
            {
                lblCPF.Visible = true;
                lblCPF.Text = "Campo Obrigatório";
                CPF.Focus();
                return false;
            }

            if (DataNascimento.Text == "")
            {
                lblDataNascimento.Visible = true;
                lblDataNascimento.Text = "Campo Obrigatório";
                DataNascimento.Focus();
                return false;
            }

            if (Sexo.SelectedValue == "")
            {
                lblSexo.Visible = true;
                lblSexo.Text = "Campo Obrigatório";
                Sexo.Focus();
                return false;
            }

            if (Endereco.Text == "")
            {
                lblEndereco.Visible = true;
                lblEndereco.Text = "Campo Obrigatório";
                Endereco.Focus();
                return false;
            }

            if (BairroEndereco.Text == "")
            {
                lblBairroEndereco.Visible = true;
                lblBairroEndereco.Text = "Campo Obrigatório";
                BairroEndereco.Focus();
                return false;
            }

            if (CidadeEndereco.Text == "")
            {
                lblCidadeEndereco.Visible = true;
                lblCidadeEndereco.Text = "Campo Obrigatório";
                CidadeEndereco.Focus();
                return false;
            }

            if (CEPEndereco.Text == "")
            {
                lblCEPEndereco.Visible = true;
                lblCEPEndereco.Text = "Campo Obrigatório";
                CEPEndereco.Focus();
                return false;
            }

            if (Email.Text == "")
            {
                lblEmail.Visible = true;
                lblEmail.Text = "Campo Obrigatório";
                Email.Focus();
                return false;
            }

            if (Senha.Text == "")
            {
                lblSenha.Visible = true;
                lblSenha.Text = "Campo Obrigatório";
                Senha.Focus();
                return false;
            }

            return true;
        }
    }
}