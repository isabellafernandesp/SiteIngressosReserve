<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SiteVendaIngressos.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
     <div class="login">
        <div class="login-content">
            <div class="txtEfetueLogin"><p>Efetue o Login</p></div>
            <br />
            <br />
            <asp:Label ID="lblLogin" runat="server" Text="Email: "></asp:Label>
            <br />
            <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblSenha" runat="server" Text="Senha: "></asp:Label>
            <br />
            <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnEntrar" CssClass="btn btn-default" runat="server" onclick="btnEntrar_Click" 
                Text="Entrar" />
            <br />
            <br />
            <p>Caso não possua cadastro, <a href="/CadastroUsuario">cadastre-se</a>.</p>
            <br />
            <br />
        </div>
    </div>
</asp:Content>
