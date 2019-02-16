<%@ Page Title="Comprar Ingresso" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComprarIngresso.aspx.cs" Inherits="SiteVendaIngressos.ComprarIngresso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="comprarIngresso">
        <div class="comprarIngresso-content">
            <div class="txtComprarIngresso"><p>Comprar Ingresso</p></div>
            <br />
            <table class="tabelaCartao">
                <tr>
                    <td>
                        <asp:HiddenField runat="server" ID="idEvento" Value=""></asp:HiddenField>
                        <asp:Label runat="server" ID="lblInformeDadosCartao" Text="Informe os dados do Cartão"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblNumeroCartao" Text="Número"></asp:Label><br />
                        <asp:TextBox runat="server" ID="NumeroCartao" name="NumeroCartao"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblNomeCartao" Text="Nome Impresso"></asp:Label><br />
                        <asp:TextBox runat="server" ID="NomeCartao" name="NomeCartao"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblValidadeCartao" Text="Validade"></asp:Label><br />
                        <asp:TextBox runat="server" ID="ValidadeCartao" name="ValidadeCartao"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblCVVCartao" Text="CVV"></asp:Label><br />
                        <asp:TextBox runat="server" ID="CVVCartao" name="CVVCartao"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label runat="server" ID="lblQtdIngressos" Text="Quantidade de Ingressos"></asp:Label><br />
                        <asp:TextBox runat="server" ID="QtdIngressos" Font-Names="QtdIngressos" value="1"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="ValorIngresso" name="ValorIngresso" Text="R$ 0,00"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="TotalPedido" name="TotalPedido" Text="R$ 0,00"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblNumParcelas" Text="Número de Parcelas"></asp:Label> <br />
                        <asp:TextBox runat="server" ID="NumParcelas" Font-Names="QtdIngressos" value="1"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                        <asp:Button CssClass="btn btn-default" runat="server" ID="btnConfirmarPagamento" OnClick="ComprarIngresso_Click" Text="Comprar Ingresso"/>
                        <br />
                        <br />
                    </td>
                </tr>
            </table>
        </div>
    </div>

</asp:Content>
