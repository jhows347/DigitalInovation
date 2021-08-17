using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TestePlaylist.Abstract;

namespace TestePlaylist.Models
{
    public class Playlists : IdBase
    {
        [Display(Name ="Titulo")]
        public string TituloPlaylist { get; set; }

        [Display(Name = "Música")]
        public string NomeMusica { get; set; }

        [Display(Name = "Artista")]
        public Artistas Artista { get; set; }

        [Display(Name = "Gênero")]
        public GenerosMusicais Genero { get; set; }

        [Display(Name = "Duração"), DisplayFormat(DataFormatString = "00:00")]
        public string DuracaoMusica{ get; set; }

    }
}