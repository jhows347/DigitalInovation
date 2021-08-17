using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace TestePlaylist.Abstract
{
    public abstract class IdBase
    {

        [Display(Name = "Código")]
        public Guid Id { get; set; }   
    }
}