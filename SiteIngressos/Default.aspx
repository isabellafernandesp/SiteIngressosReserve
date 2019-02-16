<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SiteVendaIngressos._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content">
        <% foreach(var evento in Eventos){ %>
            <div class="jumbotron">
                <h2><%= evento.TituloEvento %></h2>
                <p class="lead"><%= evento.DescricaoEvento %></p>
                <p>
                    Data: <%= evento.DataHoraEvento.ToString("dd/MM/yyyy") %> 
                    Horário: <%= evento.DataHoraEvento.ToString("HH:MM") %> 
                    <br />
                    <a class="btn btn-default" href="ComprarIngresso/<%= evento.Id %>">Comprar Ingresso</a>
                </p>
            </div>
            <br />
        <% } %>
    </div>
</asp:Content>
