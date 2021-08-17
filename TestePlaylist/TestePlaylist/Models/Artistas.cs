using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using TestePlaylist.Abstract;

namespace TestePlaylist.Models
{
    public class Artistas : IdBase
    {
        [Display(Name = "Nome Artista")]
        public string Nome { get; set; }
    }
}