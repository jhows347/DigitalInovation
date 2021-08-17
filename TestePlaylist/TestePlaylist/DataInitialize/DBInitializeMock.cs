using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestePlaylist.Models;

namespace TestePlaylist.DataInitialize
{
    public class DBInitializeMock
    {
        private List<Playlists> playlists = new List<Playlists>();

        public DBInitializeMock()
        {
        }

        #region Carregar dados mockados para exemplo
            public List<Playlists> LoadDB()
        {

            return new List<Playlists>(){
                    new Playlists
                    {
                         Id = Guid.NewGuid(),
                         TituloPlaylist = "Rap" ,
                         NomeMusica = "Um Homem na estrada",
                         Artista = new Artistas {  Id = Guid.NewGuid(), Nome = "Racionais"},
                         DuracaoMusica = "06:35",
                         Genero = new GenerosMusicais { Id = Guid.NewGuid(), Genero = "Rap Nacional"}

                    },
                    new Playlists
                    {
                         Id = Guid.NewGuid(),
                         TituloPlaylist = "Rock" ,
                         NomeMusica = "Vermillion",
                         Artista = new Artistas {  Id = Guid.NewGuid(), Nome = "Slipknot"},
                         DuracaoMusica = "03:17",
                         Genero = new GenerosMusicais { Id = Guid.NewGuid(), Genero = "Rock Internacional"}
                    }

                };
        }
        #endregion
    }
}


