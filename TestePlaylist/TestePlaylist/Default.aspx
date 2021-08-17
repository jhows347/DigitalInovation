<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestePlaylist.Playlist" %>--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestePlaylist.Playlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <hr />
    <h3>Cadastro de Playlists</h3>
        <div>
            Titulo:   <asp:TextBox ID="Titulo" runat="server"></asp:TextBox><br /><br />
            Artistas: <asp:DropDownList ID="DropArtistas" runat="server"></asp:DropDownList> <br /><br /> 
            Generos:  <asp:DropDownList ID="DropGeneros" runat="server"></asp:DropDownList><br /><br />
            Musica :  <asp:TextBox ID="NomeMusica" runat="server"></asp:TextBox><br /><br />
            Duração:  <asp:TextBox ID="Duracao" runat="server"></asp:TextBox><br /><br />
        </div>
        <asp:Button ID="btnCad" runat="server" Text="Cadastrar" OnClick="CadastrarPlaylist_Click" />
 
</asp:Content>




