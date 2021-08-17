using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using TestePlaylist.Abstract;

namespace TestePlaylist.Models
{
    public class GenerosMusicais : IdBase
    {
        [Display(Name = "Genero Musical")]
        public string Genero { get; set; }
    }
}