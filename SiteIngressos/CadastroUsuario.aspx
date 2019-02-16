<%@ Page Title="Cadastro de Usuário" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="SiteVendaIngressos.CadastroUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="cadastrousuario">
        <div class="cadastrousuario-content">
            <div class="tituloCadastroUsuario"><p>Cadastro de Usuário</p></div>
            <br />
            <table class="tabelaCadastro">
                <tr>
                    <td>
                        <p>Nome: <br /> 
                            <asp:TextBox runat="server" id="Nome" name="Nome" placeholder="Nome" value="" /><br />
                            <asp:Label CssClass="lblCampoObrigatorio" runat="server" ID="lblNome" Text=""></asp:Label>
                        </p>
                    </td>
                    <td>
                        <p>CPF: <br />
                            <asp:TextBox runat="server" id="CPF" name="CPF" placeholder="CPF" value="" /><br />
                            <asp:Label CssClass="lblCampoObrigatorio" runat="server" ID="lblCPF" Text=""></asp:Label>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p>Data de Nascimento: <br />
                            <asp:TextBox ID="DataNascimento" OnKeyUp="mascaraData(this);" runat="server" MaxLength="10"></asp:TextBox><br />
                            <asp:Label CssClass="lblCampoObrigatorio" runat="server" ID="lblDataNascimento" Text=""></asp:Label>
                        </p>
                    </td>
                    <td>
                        <p>Sexo: <br /> 
                            <asp:DropDownList runat="server" id="Sexo" CssClass="SexoUsuario">
                                <asp:ListItem value="">Selecione</asp:ListItem>
                                <asp:ListItem value="M">Masculino</asp:ListItem>
                                <asp:ListItem value="F">Feminino</asp:ListItem>
                            </asp:DropDownList><br />
                            <asp:Label CssClass="lblCampoObrigatorio" runat="server" ID="lblSexo" Text=""></asp:Label>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p>Endereço: <br />
                            <asp:TextBox id="Endereco" name="Endereco" runat="server" placeholder="Endereço" value="" /> <br />
                            <asp:Label CssClass="lblCampoObrigatorio" runat="server" ID="lblEndereco" Text=""></asp:Label>
                        </p>
                    </td>
                    <td>
                        <p>Bairro: <br />
                            <asp:TextBox id="BairroEndereco" name="BairroEndereco" runat="server" placeholder="Bairro" value="" /><br />
                            <asp:Label CssClass="lblCampoObrigatorio" runat="server" ID="lblBairroEndereco" Text=""></asp:Label>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p>Cidade: <br />
                            <asp:TextBox id="CidadeEndereco" name="CidadeEndereco" runat="server" placeholder="Cidade" value="" /><br />
                            <asp:Label CssClass="lblCampoObrigatorio" runat="server" ID="lblCidadeEndereco" Text=""></asp:Label>
                        </p>
                    </td>
                    <td>
                        <p>CEP: <br />
                            <asp:TextBox id="CEPEndereco" name="CEPEndereco" runat="server" placeholder="CEP" value="" /><br />
                            <asp:Label CssClass="lblCampoObrigatorio" runat="server" ID="lblCEPEndereco" Text=""></asp:Label>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p>Email: <br />
                            <asp:TextBox id="Email" name="Email" runat="server" placeholder="Email: example@example.com" value="" /><br />
                            <asp:Label CssClass="lblCampoObrigatorio" runat="server" ID="lblEmail" Text=""></asp:Label>
                        </p>
                    </td>
                    <td>
                        <p>Senha: <br />
                            <asp:TextBox id="Senha" name="Senha" runat="server" placeholder="Senha" value="" /><br />
                            <asp:Label CssClass="lblCampoObrigatorio" runat="server" ID="lblSenha" Text=""></asp:Label>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="linhaBotaoCadastrarUsuario">
                        <br />
                        <asp:Button ID="cadastrarUsuario" CssClass="btn btn-default btnCadastrarUsuario" name="cadastrarUsuario" runat="server" OnClick="CadastrarUsuario_Click" Text="Confirmar" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
