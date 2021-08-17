using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestePlaylist.DataInitialize;
using TestePlaylist.Models;
using TestePlaylist.Repository;

namespace TestePlaylist
{
    public partial class Playlist : System.Web.UI.Page
    {
        private  DBInitializeMock dBInitializeMock;
        private ArtistasRepository _artistasRepository = new ArtistasRepository();
        private GenerosRepository _generosRepository = new GenerosRepository();
        private PlaylistRepository _playlistRepository = new PlaylistRepository();
        private Playlists playlist;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                dBInitializeMock = new DBInitializeMock();

                var artistas = _artistasRepository.ListarTodos();
                var generos = _generosRepository.ListarTodos();

                if (DropArtistas.Items.Count <= 0 && DropGeneros.Items.Count <= 0)
                {
                    foreach (var artista in artistas)
                    {
                        DropArtistas.Items.Add(artista.Nome);
                    }
                    foreach (var genero in generos)
                    {
                        DropGeneros.Items.Add(genero.Genero);
                    }
                }

            }

        }

        protected void CadastrarPlaylist_Click(object sender, EventArgs e)
        {
            playlist = new Playlists();
            playlist.Id = Guid.NewGuid();
            playlist.TituloPlaylist = Titulo.Text;
            playlist.NomeMusica = NomeMusica.Text;
            playlist.DuracaoMusica = Duracao.Text;
            playlist.Artista = new Artistas { Id = Guid.NewGuid(), Nome = DropArtistas.SelectedValue };
            playlist.Genero = new GenerosMusicais { Id = Guid.NewGuid(), Genero = DropGeneros.SelectedValue };

            _playlistRepository.AddInMemory(playlist);


            var ListaPlaylist = _playlistRepository.ListarTodos();

        }
    }
}